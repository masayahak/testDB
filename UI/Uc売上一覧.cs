using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using テストDB.ViewModel;
using static テストDB.共通UI.UcPageControl;
using static テストDB.共通UI.Uc得意先検索;
using static テストDB.共通UI.Uc社員検索;
using Excel = Microsoft.Office.Interop.Excel;

namespace テストDB.UI
{
    public partial class Uc売上一覧 : UserControl
    {
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
            this.userControl得意先入力.M得意先一覧 = e.m得意先一覧;
        }

        private void On社員番号_Selected(On社員番号SelectedEventArgs e)
        {
            this.userControl社員入力.M社員 = e.m社員;
        }

        private void OnPageChange(OnPageChangeEventArgs e)
        {
            this.dgvPager売上一覧.ShowPage<ds売上一覧>(e.CurrentCount, e.RowsInPage);
        }


        public Uc売上一覧()
        {
            InitializeComponent();

            // ユーザーコントロールで発火するイベントハンドラを追加
            this.userControl得意先入力.userControl得意先検索 = this.userControl得意先検索;
            this.userControl得意先検索.On得意先CDSelected += On得意先CD_Selected;

            // ユーザーコントロールで発火するイベントハンドラを追加
            this.userControl社員入力.userControl社員検索 = this.userControl社員検索;
            this.userControl社員検索.On社員番号Selected += On社員番号_Selected;


            // ユーザーコントロールで発火するイベントハンドラを追加
            this.ucPageControl.dgvPager = dgvPager売上一覧;
            this.ucPageControl.RowsInPage = 100;
            this.ucPageControl.OnPageChange += OnPageChange;

            this.ucPageControl.OnGridToExcel += OnGridToExcel;
        }


        private void UserControl売上日別売上一覧_Load(object sender, EventArgs e)
        {
            this.userControl売上伝票.Dock = DockStyle.Fill;
            this.userControl売上伝票.Visible = false;

        }

        // ----------------------------------------------------------------
        // 外部からのパラメータでデータ読み込み
        // ----------------------------------------------------------------
        public void LoadDataWithParama()
        {
            this.dtp期間開始.Value = 期間開始;
            this.dtp期間終了.Value = 期間終了;

            // todo キーから名前をロードしてない。
            // はたして、外部から本当に指定が必要なのか
            this.userControl得意先入力.M得意先一覧.得意先CD = 得意先CD;
            this.userControl社員入力.M社員.社員番号 = 担当社員番号;

            LoadData();
        }


        // ----------------------------------------------------------------
        // データ読み込み
        // ----------------------------------------------------------------
        private void cButton検索_Click(object sender, EventArgs e)
        {
            期間開始 = this.dtp期間開始.Value.Date;
            期間終了 = this.dtp期間終了.Value.Date;

            // todo キーから名前をロードしてない。
            // はたして、外部から本当に指定が必要なのか
            得意先CD = this.userControl得意先入力.M得意先一覧.得意先CD;
            担当社員番号 = this.userControl社員入力.M社員.社員番号;

            LoadData();
        }

        public class ds売上一覧
        {
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
            ID = 0,
            売上日 = 1,
            得意先CD = 2,
            得意先名 = 3,
            担当社員番号 = 4,
            担当社員名 = 5,
            売上高 = 6,
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
                .Select(it => new ds売上一覧
                {
                    ID = it.ID,
                    売上日 = it.売上日,
                    得意先CD = it.得意先CD,
                    得意先名 = it.得意先名,
                    担当社員番号 = it.担当社員番号,
                    担当社員名 = it.担当社員名,
                    売上高 = it.売上高,
                })
                .OrderBy(it => it.売上日)
                .ThenBy(it => it.得意先CD)
                .ToList()
                ;

            this.ucPageControl.RowCount = list.Count();
            this.ucPageControl.CurrentCount = 1;

            this.dgvPager売上一覧.SetFullDatasource(list);
            this.dgvPager売上一覧.ShowPage<ds売上一覧>(this.ucPageControl.CurrentCount, this.ucPageControl.RowsInPage);

            // 列幅の設定:
            dgvPager売上一覧.Columns[(int)ds売上一覧_Col.ID].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPager売上一覧.Columns[(int)ds売上一覧_Col.売上日].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPager売上一覧.Columns[(int)ds売上一覧_Col.得意先CD].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPager売上一覧.Columns[(int)ds売上一覧_Col.得意先名].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPager売上一覧.Columns[(int)ds売上一覧_Col.担当社員番号].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPager売上一覧.Columns[(int)ds売上一覧_Col.担当社員名].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPager売上一覧.Columns[(int)ds売上一覧_Col.売上高].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // 書式
            dgvPager売上一覧.Columns[(int)ds売上一覧_Col.売上日].DefaultCellStyle.Format = "MM/dd";
            dgvPager売上一覧.Columns[(int)ds売上一覧_Col.売上高].DefaultCellStyle.Format = "C";


            dgvPager売上一覧.Columns[(int)ds売上一覧_Col.ID].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPager売上一覧.Columns[(int)ds売上一覧_Col.売上高].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // ヘッダー
            dgvPager売上一覧.Columns[(int)ds売上一覧_Col.ID].HeaderText = "伝票№";

            // サイズ調整
            dgvPager売上一覧_SizeChanged(this, null);
        }

        // ----------------------------------------------------------------
        // 一覧のサイズ変更
        // ----------------------------------------------------------------
        private void dgvPager売上一覧_SizeChanged(object sender, EventArgs e)
        {
            dgvPager売上一覧.Columns[(int)ds売上一覧_Col.得意先名].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            int ColWidthSum =
            dgvPager売上一覧.Columns[(int)ds売上一覧_Col.ID].Width +
            dgvPager売上一覧.Columns[(int)ds売上一覧_Col.売上日].Width +
            dgvPager売上一覧.Columns[(int)ds売上一覧_Col.得意先CD].Width +
            dgvPager売上一覧.Columns[(int)ds売上一覧_Col.得意先名].Width +
            dgvPager売上一覧.Columns[(int)ds売上一覧_Col.担当社員番号].Width +
            dgvPager売上一覧.Columns[(int)ds売上一覧_Col.担当社員名].Width +
            dgvPager売上一覧.Columns[(int)ds売上一覧_Col.売上高].Width;

            if (dgvPager売上一覧.Width > ColWidthSum)
            {
                dgvPager売上一覧.Columns[(int)ds売上一覧_Col.ID].Visible = true;
                dgvPager売上一覧.Columns[(int)ds売上一覧_Col.得意先CD].Visible = true;
                dgvPager売上一覧.Columns[(int)ds売上一覧_Col.担当社員番号].Visible = true;
                dgvPager売上一覧.Columns[(int)ds売上一覧_Col.得意先名].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                dgvPager売上一覧.Columns[(int)ds売上一覧_Col.ID].Visible = false;
                dgvPager売上一覧.Columns[(int)ds売上一覧_Col.得意先CD].Visible = false;
                dgvPager売上一覧.Columns[(int)ds売上一覧_Col.担当社員番号].Visible = false;
                dgvPager売上一覧.Columns[(int)ds売上一覧_Col.得意先名].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        // ----------------------------------------------------------------
        // 一覧のダブルクリック
        // ----------------------------------------------------------------
        private void dgvPager売上一覧_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int 売上ID;

            try
            {
                var str = dgvPager売上一覧.Rows[e.RowIndex].Cells[0].Value.ToString();
                int.TryParse(str, out 売上ID);
            }
            catch
            {
                return;
            }

            this.userControl売上伝票.売上ID = 売上ID;
            this.userControl売上伝票.LoadData();
            this.userControl売上伝票.Visible = true;
            this.userControl売上伝票.BringToFront();
        }

        private void OnGridToExcel()
        {
            //Excelオブジェクトの初期化
            Excel.Application ExcelApp = null;
            Excel.Workbook exCurrentBook = null;
            Excel.Worksheet exCurrentSheet = null;


            try
            {
                //待機状態
                Cursor.Current = Cursors.WaitCursor;

                //Excelシートのインスタンスを作る
                ExcelApp = new Excel.Application();

                exCurrentBook = ExcelApp.Workbooks.Add();
                exCurrentSheet = exCurrentBook.Worksheets[1];

                exCurrentSheet.Select(Type.Missing);


                // -----------------------------------------------------
                // ヘッダー
                // -----------------------------------------------------
                int rows = dgvPager売上一覧.fullDataSource.Count;
                int cols = dgvPager売上一覧.Columns.Count;

                string[] Header = new string[cols];

                int col = 0;
                foreach (DataGridViewColumn column in dgvPager売上一覧.Columns)
                {
                    Header[col] = column.HeaderText;
                    col++;
                }

                Excel.Range rangeHeader = (Excel.Range)exCurrentSheet.Cells[1, 1];
                rangeHeader = rangeHeader.get_Resize(1, cols);

                rangeHeader.Value = Header;
                rangeHeader.Interior.Color = Color.DarkBlue;
                rangeHeader.Font.Color = Color.White;
                rangeHeader.Font.Bold = true;

                // -----------------------------------------------------
                // リスト
                // -----------------------------------------------------
                object[,] ListToExcel = new object[rows, cols];

                int row = 0;

                foreach (ds売上一覧 item in dgvPager売上一覧.fullDataSource)
                {
                    // 行
                    ListToExcel[row, 0] = item.ID;
                    ListToExcel[row, 1] = item.売上日;
                    ListToExcel[row, 2] = item.得意先CD;
                    ListToExcel[row, 3] = item.得意先名;
                    ListToExcel[row, 4] = item.担当社員番号;
                    ListToExcel[row, 5] = item.担当社員名;
                    ListToExcel[row, 6] = item.売上高;

                    row++;
                }

                Excel.Range range = (Excel.Range)exCurrentSheet.Cells[2, 1];
                range = range.get_Resize(rows, cols);
                range.Value = ListToExcel;

                // -----------------------------------------------------
                // 書式
                // -----------------------------------------------------
                Excel.Range formatRange = (Excel.Range)exCurrentSheet.get_Range("B:B");
                formatRange.NumberFormatLocal = "yyyy/MM/dd";

                formatRange = (Excel.Range)exCurrentSheet.get_Range("G:G");
                formatRange.NumberFormatLocal = "\\ #,##0";

            }

            finally
            {
                exCurrentSheet.Cells.Columns.AutoFit();

                //excel表示
                ExcelApp.Visible = true;

                //元に戻す
                Cursor.Current = Cursors.Default;
            }


        }
    }
}
