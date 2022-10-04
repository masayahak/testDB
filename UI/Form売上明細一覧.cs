using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using テストDB.ViewModel;
using static 共通UI.UcGridPager;
using static 共通UI.Uc商品検索;
using static 共通UI.Uc得意先検索;

namespace テストDB.UI
{
    public partial class Form売上明細一覧 : Form
    {

        // ----------------------------------------------------------------
        // 表示する一覧の定義
        // ----------------------------------------------------------------
        public class ds売上明細一覧
        {
            public int No { get; set; }
            public int ID { get; set; }
            public DateTime 売上日 { get; set; }
            public string バーコード { get; set; }
            public string 商品名 { get; set; }
            public string 得意先CD { get; set; }
            public string 得意先名 { get; set; }
            public int 単価 { get; set; }
            public int 数量 { get; set; }
            public int 売上高 { get; set; }
        }

        public enum ds売上明細一覧_Col
        {
            No = 0,
            ID = 1,
            売上日 = 2,
            バーコード = 3,
            商品名 = 4,
            得意先CD = 5,
            得意先名 = 6,
            単価 = 7,
            数量 = 8,
            売上高 = 9,
        }

        private ViewModel売上 vm売上明細;


        // ----------------------------------------------------------------
        // パラメータの受け取り
        // ----------------------------------------------------------------
        public DateTime 期間開始 = DateTime.Today;
        public DateTime 期間終了 = DateTime.Today;
        public string 商品名;
        public string バーコード;
        public string 得意先CD;

        private void Onバーコード_Selected(OnバーコードSelectedEventArgs e)
        {
            this.uc商品入力.M商品 = e.m商品;
        }

        private void On得意先CD_Selected(On得意先CDSelectedEventArgs e)
        {
            this.uc得意先入力.M得意先J担当者 = e.m得意先一覧;
        }

        public Form売上明細一覧()
        {
            InitializeComponent();

            // 商品検索イベント
            this.uc商品入力.uc商品検索 = this.uc商品検索;
            this.uc商品検索.OnバーコードSelected += Onバーコード_Selected;

            // 得意先検索イベント
            this.uc得意先入力.uc得意先検索 = this.uc得意先検索;
            this.uc得意先検索.On得意先CDSelected += On得意先CD_Selected;

            // グリッドのフォーマットイベント
            this.ucGridPager.OnGridFormat += OnGrid_Format;

            // グリッドのダブルクリック
            this.ucGridPager.OnGridDoubleClick += OnGrid_DoubleClick;
        }

        private void Form売上明細一覧_Load(object sender, EventArgs e)
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

            this.uc商品入力.Get商品by商品名(商品名);
            バーコード = this.uc商品入力.M商品.バーコード;

            DataLoad();
        }

        private void cButton検索_Click(object sender, EventArgs e)
        {
            期間開始 = this.dtp期間開始.Value.Date;
            期間終了 = this.dtp期間終了.Value.Date;

            商品名 = "";
            バーコード = this.uc商品入力.M商品.バーコード;
            得意先CD = this.uc得意先入力.M得意先J担当者.得意先CD;

            DataLoad();
        }

        // ----------------------------------------------------------------
        // データ読み込み
        // ----------------------------------------------------------------
        private async void DataLoad()
        {

            if (DesignMode) return;

            // ロード中
            ShowLoading();

            vm売上明細 = new ViewModel売上();

            // 非同期でデータ取得
            await Task.Run(() =>
            {
                vm売上明細.LoadT売上明細(期間開始, 期間終了, バーコード, 得意先CD);
            });

            var list = vm売上明細.listV売上明細
                .OrderBy(it => it.売上日)
                .ThenBy(it => it.バーコード)
                .Select((it, i) => new ds売上明細一覧
                {
                    No = i + 1,
                    ID = it.ID,
                    売上日 = it.売上日,
                    バーコード = it.バーコード,
                    商品名 = it.商品名,
                    得意先CD = it.得意先CD,
                    得意先名 = it.得意先名,
                    単価 = it.販売単価,
                    数量 = it.販売数量,
                    売上高 = it.明細売上高,
                })
               .ToList()
                ;

            this.ucGridPager.RowsInPage = 100;
            this.ucGridPager.SetFullDatasource<ds売上明細一覧>(list);
            this.ucGridPager.ShowPage();

            // ロード終了
            OnLoaded();

        }

        // ロード中
        private void ShowLoading()
        {
            this.ucロード中.Visible = true;
            this.ucロード中.BringToFront();
        }

        private void OnLoaded()
        {
            this.ucロード中.Visible = false;
        }


        // ----------------------------------------------------------------
        // グリッドの書式
        // ----------------------------------------------------------------
        // グリッドの書式設定
        private void OnGrid_Format()
        {
            DataGridView dg = this.ucGridPager.pagerDataGridView;

            // 書式
            dg.Columns[(int)ds売上明細一覧_Col.売上日].DefaultCellStyle.Format = "MM/dd";

            dg.Columns[(int)ds売上明細一覧_Col.単価].DefaultCellStyle.Format = "C";
            dg.Columns[(int)ds売上明細一覧_Col.売上高].DefaultCellStyle.Format = "C";

            dg.Columns[(int)ds売上明細一覧_Col.ID].HeaderText = "伝票№";

            ucGridPager_SizeChanged(this, null);
        }

        // ----------------------------------------------------------------
        // 一覧のサイズ変更
        // ----------------------------------------------------------------
        private void ucGridPager_SizeChanged(object sender, EventArgs e)
        {
            DataGridView dg = this.ucGridPager.pagerDataGridView;

            // データ0行ならなにもしない
            if (dg.RowCount == 0) return;

            dg.Columns[(int)ds売上明細一覧_Col.商品名].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dg.Columns[(int)ds売上明細一覧_Col.得意先名].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            int ColWidthSum = 0;
            foreach (DataGridViewColumn column in dg.Columns)
            {
                ColWidthSum += column.Width;
            }

            if (dg.Width > ColWidthSum)
            {
                dg.Columns[(int)ds売上明細一覧_Col.ID].Visible = true;
                dg.Columns[(int)ds売上明細一覧_Col.得意先CD].Visible = true;
                dg.Columns[(int)ds売上明細一覧_Col.バーコード].Visible = true;
                dg.Columns[(int)ds売上明細一覧_Col.売上高].Visible = true;

                dg.Columns[(int)ds売上明細一覧_Col.商品名].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dg.Columns[(int)ds売上明細一覧_Col.得意先名].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                dg.Columns[(int)ds売上明細一覧_Col.ID].Visible = false;
                dg.Columns[(int)ds売上明細一覧_Col.得意先CD].Visible = false;
                dg.Columns[(int)ds売上明細一覧_Col.バーコード].Visible = false;
                dg.Columns[(int)ds売上明細一覧_Col.売上高].Visible = false;

                dg.Columns[(int)ds売上明細一覧_Col.商品名].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dg.Columns[(int)ds売上明細一覧_Col.得意先名].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        // ----------------------------------------------------------------
        // 一覧のダブルクリック
        // ----------------------------------------------------------------
        private void OnGrid_DoubleClick(OnGridDoubleClickArgs args)
        {
            if (!(args.Row is ds売上明細一覧)) return;

            var ds = (ds売上明細一覧)args.Row;

            this.uc売上伝票.売上ID = ds.ID;
            this.uc売上伝票.DataLoad();
            this.uc売上伝票.Visible = true;
            this.uc売上伝票.BringToFront();
        }

    }
}
