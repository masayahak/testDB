using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using テストDB.ViewModel;
using static テストDB.UI.Form売上一覧;
using static 共通UI.UcGridPager;

namespace テストDB.UI
{
    public partial class Uc売上伝票 : UserControl
    {
        // ----------------------------------------------------------------
        // 表示する一覧の定義
        // ----------------------------------------------------------------
        private class 売上明細list
        {
            public string バーコード { get; set; }
            public string 商品名 { get; set; }
            public int 販売単価 { get; set; }
            public int 販売数量 { get; set; }
            public int 明細売上高 { get; set; }
            public int 明細消費税額 { get; set; }
        }

        enum 売上明細list_Col
        {
            バーコード = 0,
            商品名 = 1,
            販売単価 = 2,
            販売数量 = 3,
            明細売上高 = 4,
            明細消費税額 = 5,
        }

        private ViewModel売上 vm売上;

        private int _売上ID = 1;
        public int 売上ID
        {
            get { return _売上ID; }
            set
            {
                _売上ID = value;
            }
        }

        public Uc売上伝票()
        {
            InitializeComponent();

            // グリッドのフォーマットイベント
            this.ucGridPager.OnGridFormat += OnGrid_Format;

            // グリッドのダブルクリック
            this.ucGridPager.OnGridDoubleClick += OnGrid_DoubleClick;

        }

        public void DataLoad()
        {
            if (DesignMode) return;

            vm売上 = new ViewModel売上();

            // ID直指定なので、非同期にするまでも無い
            vm売上.LoadData(売上ID);

            var 売上 = vm売上.list売上[0];

            this.textBox伝票NO.Text = 売上.ID.ToString();
            this.textBox得意先CD.Text = 売上.得意先CD.ToString();
            this.textBox得意先名.Text = 売上.得意先名.ToString();
            this.textBox担当社員番号.Text = 売上.担当社員番号.ToString();
            this.textBox担当社員名.Text = 売上.担当社員名.ToString();
            this.textBox売上日.Text = 売上.売上日.ToString("yyyy/MM/dd");
            this.textBox売上高.Text = 売上.売上高.ToString("C");
            this.textBox消費税額.Text = 売上.消費税額.ToString("C");
            this.textBox仕入高.Text = 売上.仕入高.ToString("C");

            var 売上明細lists = vm売上.list売上明細
                            .Select(it => new 売上明細list
                            {
                                バーコード = it.バーコード,
                                商品名 = it.商品名,
                                販売単価 = it.販売単価,
                                販売数量 = it.販売数量,
                                明細売上高 = it.明細売上高,
                                明細消費税額 = it.明細消費税額,
                            })
                            .ToList()
                            ;

            this.ucGridPager.RowsInPage = 100;
            this.ucGridPager.SetFullDatasource<売上明細list>(売上明細lists);
            this.ucGridPager.ShowPage();

        }

        // ----------------------------------------------------------------
        // グリッドの書式
        // ----------------------------------------------------------------
        // グリッドの書式設定
        private void OnGrid_Format()
        {
            DataGridView dg = this.ucGridPager.pagerDataGridView;

            // 書式
            dg.Columns[(int)売上明細list_Col.販売単価].DefaultCellStyle.Format = "@#,##0";
            dg.Columns[(int)売上明細list_Col.販売数量].DefaultCellStyle.Format = "#,##0";
            dg.Columns[(int)売上明細list_Col.明細売上高].DefaultCellStyle.Format = "C";
            dg.Columns[(int)売上明細list_Col.明細消費税額].DefaultCellStyle.Format = "C";

            // ヘッダー
            dg.Columns[(int)売上明細list_Col.販売単価].HeaderText = "単価";
            dg.Columns[(int)売上明細list_Col.販売数量].HeaderText = "数量";
            dg.Columns[(int)売上明細list_Col.明細売上高].HeaderText = "売上高";
            dg.Columns[(int)売上明細list_Col.明細消費税額].HeaderText = "消費税";

            ucGridPager_SizeChanged(this, null);
        }

        private void OnGrid_DoubleClick(OnGridDoubleClickArgs args)
        {
            // なにも処理は無い
        }

        // ----------------------------------------------------------------
        // 一覧のサイズ変更
        // ----------------------------------------------------------------
        private void ucGridPager_SizeChanged(object sender, EventArgs e)
        {

            DataGridView dg = this.ucGridPager.pagerDataGridView;

            // データ0行ならなにもしない
            if (dg.RowCount == 0) return;

            dg.Columns[(int)売上明細list_Col.商品名].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            int ColWidthSum = 0;
            foreach (DataGridViewColumn column in dg.Columns)
            {
                ColWidthSum += column.Width;
            }

            if (dg.Width > ColWidthSum)
            {
                dg.Columns[(int)売上明細list_Col.バーコード].Visible = true;
                dg.Columns[(int)売上明細list_Col.明細消費税額].Visible = true;

                dg.Columns[(int)売上明細list_Col.商品名].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                dg.Columns[(int)売上明細list_Col.バーコード].Visible = false;
                dg.Columns[(int)売上明細list_Col.明細消費税額].Visible = false;

                dg.Columns[(int)売上明細list_Col.商品名].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void buttonｷｬﾝｾﾙ_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
