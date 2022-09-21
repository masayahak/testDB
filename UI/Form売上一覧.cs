using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static テストDB.共通UI.Uc社員検索;
using static テストDB.共通UI.Uc得意先検索;
using テストDB.ViewModel;
using static テストDB.共通UI.UcPager;

namespace テストDB.UI
{
    public partial class Form売上一覧 : Form
    {
        // ----------------------------------------------------------------
        // 表示する一覧の定義
        // ----------------------------------------------------------------
        public class ds売上一覧
        {
            public int No { get; set; }
            public int ID { get; set; }
            public DateTime 売上日 { get; set; }
            public string 得意先CD { get; set; }
            public string 得意先名 { get; set; }
            public string 担当社員番号 { get; set; }
            public string 担当社員名 { get; set; }
            public int 売上高 { get; set; }
        }

        public enum ds売上一覧_Col
        {
            No = 0,
            ID = 1,
            売上日 = 2,
            得意先CD = 3,
            得意先名 = 4,
            担当社員番号 = 5,
            担当社員名 = 6,
            売上高 = 7,
        }

        private ViewModel売上 vm売上;

        // ----------------------------------------------------------------
        // パラメータの受け取り
        // ----------------------------------------------------------------
        public DateTime 期間開始 = DateTime.Today;
        public DateTime 期間終了 = DateTime.Today;
        public string 得意先CD;
        public string 担当社員番号;

        private void On得意先CD_Selected(On得意先CDSelectedEventArgs e)
        {
            this.uc得意先入力.M得意先一覧 = e.m得意先一覧;
        }

        private void On社員番号_Selected(On社員番号SelectedEventArgs e)
        {
            this.uc社員入力.M社員 = e.m社員;
        }

        public Form売上一覧()
        {
            InitializeComponent();

            // 得意先検索イベント
            this.uc得意先入力.uc得意先検索 = this.uc得意先検索;
            this.uc得意先検索.On得意先CDSelected += On得意先CD_Selected;

            // 社員検索イベント
            this.uc社員入力.uc社員検索 = this.uc社員検索;
            this.uc社員検索.On社員番号Selected += On社員番号_Selected;

            // グリッドのフォーマットイベント
            this.ucPager.OnGridFormat += OnGrid_Format;

            // グリッドのダブルクリック
            this.ucPager.OnGridDoubleClick += OnGrid_DoubleClick;


        }

        private void Form売上一覧_Load(object sender, EventArgs e)
        {
            this.uc売上伝票.Dock = DockStyle.Fill;
            this.uc売上伝票.Visible = false;

        }

        // ----------------------------------------------------------------
        // 外部からのパラメータでデータ読み込み
        // ----------------------------------------------------------------
        public void LoadDataWithParama()
        {
            this.dtp期間開始.Value = 期間開始;
            this.dtp期間終了.Value = 期間終了;

            this.uc得意先入力.M得意先一覧.得意先CD = 得意先CD;
            this.uc社員入力.M社員.社員番号 = 担当社員番号;

            LoadData();
        }


        // ----------------------------------------------------------------
        // データ読み込み
        // ----------------------------------------------------------------
        private void cButton検索_Click(object sender, EventArgs e)
        {
            期間開始 = this.dtp期間開始.Value.Date;
            期間終了 = this.dtp期間終了.Value.Date;

            得意先CD = this.uc得意先入力.M得意先一覧.得意先CD;
            担当社員番号 = this.uc社員入力.M社員.社員番号;

            LoadData();
        }

        // ----------------------------------------------------------------
        // データ読み込み
        // ----------------------------------------------------------------
        private void LoadData()
        {

            if (DesignMode) return;

            vm売上 = new ViewModel売上();
            vm売上.LoadT売上(期間開始, 期間終了, 得意先CD, 担当社員番号);

            var list = vm売上.list売上
                .OrderBy(it => it.売上日)
                .ThenBy(it => it.得意先CD)
                .Select((it, i) => new ds売上一覧
                {
                    No = i + 1,
                    ID = it.ID,
                    売上日 = it.売上日,
                    得意先CD = it.得意先CD,
                    得意先名 = it.得意先名,
                    担当社員番号 = it.担当社員番号,
                    担当社員名 = it.担当社員名,
                    売上高 = it.売上高,
                })
                .ToList()
                ;


            this.ucPager.RowsInPage = 100;
            this.ucPager.KeyColumn = (int)ds売上一覧_Col.ID;

            this.ucPager.RowCount = list.Count();

            this.ucPager.SetFullDatasource<ds売上一覧>(list);
            this.ucPager.ShowPage();
        }

        // ----------------------------------------------------------------
        // グリッドの書式
        // ----------------------------------------------------------------
        // グリッドの書式設定
        private void OnGrid_Format()
        {
            DataGridView dg = this.ucPager.pagerDataGridView;

            // 書式
            dg.Columns[(int)ds売上一覧_Col.売上日].DefaultCellStyle.Format = "MM/dd";
            dg.Columns[(int)ds売上一覧_Col.売上高].DefaultCellStyle.Format = "C";

            dg.Columns[(int)ds売上一覧_Col.ID].HeaderText = "伝票№";

            ucPager_SizeChanged(this, null);
        }


        // ----------------------------------------------------------------
        // 一覧のサイズ変更
        // ----------------------------------------------------------------
        private void ucPager_SizeChanged(object sender, EventArgs e)
        {

            DataGridView dg = this.ucPager.pagerDataGridView;

            // データ0行ならなにもしない
            if (dg.RowCount == 0) return;

            dg.Columns[(int)ds売上一覧_Col.得意先名].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            int ColWidthSum = 0;
            foreach (DataGridViewColumn column in dg.Columns)
            {
                ColWidthSum += column.Width;
            }

            if (dg.Width > ColWidthSum)
            {
                dg.Columns[(int)ds売上一覧_Col.ID].Visible = true;
                dg.Columns[(int)ds売上一覧_Col.得意先CD].Visible = true;
                dg.Columns[(int)ds売上一覧_Col.担当社員番号].Visible = true;
                dg.Columns[(int)ds売上一覧_Col.得意先名].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                dg.Columns[(int)ds売上一覧_Col.ID].Visible = false;
                dg.Columns[(int)ds売上一覧_Col.得意先CD].Visible = false;
                dg.Columns[(int)ds売上一覧_Col.担当社員番号].Visible = false;
                dg.Columns[(int)ds売上一覧_Col.得意先名].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        // ----------------------------------------------------------------
        // 一覧のダブルクリック
        // ----------------------------------------------------------------
        private void OnGrid_DoubleClick(OnGridDoubleClickArgs args)
        {
            int 売上ID;

            int.TryParse(args.ID, out 売上ID);

            this.uc売上伝票.売上ID = 売上ID;
            this.uc売上伝票.LoadData();
            this.uc売上伝票.Visible = true;
            this.uc売上伝票.BringToFront();
        }

    }
}
