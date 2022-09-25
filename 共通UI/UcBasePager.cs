using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace テストDB.共通UI
{
    public partial class UcBasePager : UserControl
    {
        // -------------------------------------------------------
        // 公開プロパティ
        // -------------------------------------------------------

        // 外部からDataGridViewを直接参照用
        public DataGridView pagerDataGridView {
            get {
                return dataGridView;
            }
        }

        // こちらに全ページ分のDataSourceをセット
        private List<Object> fullDataSource;

        public void SetFullDatasource<T>(List<T> list)
        {
            fullDataSource = list.Cast<Object>().ToList();
        }

        // -------------------------------------------------------
        // 公開プロパティ
        // -------------------------------------------------------
        private int currentCount;
        private int CurrentCount
        {
            get { return currentCount; }
            set
            {
                currentCount = value;

                int end;
                if (value + RowsInPage < rowCount)
                    end = value + RowsInPage - 1;
                else
                    end = rowCount;

                this.lblCurrentCount.Text = value.ToString() + "～" + end.ToString();

                // ボタン制御
                SwitchButtonEnabled();
            }
        }

        private int rowsInPage = 100;

        public int RowsInPage
        {
            get { return rowsInPage; }
            set 
            { 
                rowsInPage = value;
            }
        }

        private int rowCount;
        public int RowCount
        {
            get { return rowCount; }
            set
            {
                rowCount = value;
                this.lblMaxCount.Text = rowCount.ToString();

                // 件数が変わった＝初期化された。
                CurrentCount = 1;
            }
        }

        // -------------------------------------------------------------
        // ページボタンの制御
        // -------------------------------------------------------------
        private void SwitchButtonEnabled()
        {
            // ボタン制御
            this.btnFirst.Enabled = true;
            this.btnBack.Enabled = true;
            this.btnNext.Enabled = true;
            this.btnLast.Enabled = true;

            if (CurrentCount == 1)
            {
                this.btnFirst.Enabled = false;
                this.btnBack.Enabled = false;
            }

            if (CurrentCount + RowsInPage > rowCount)
            {
                this.btnNext.Enabled = false;
                this.btnLast.Enabled = false;
            }
        }

        // -------------------------------------------------------------
        // グリッドの書式定義 デリゲート
        // -------------------------------------------------------------
        public delegate void OnGridFormatEhandler();
        public event OnGridFormatEhandler OnGridFormat;

        // -------------------------------------------------------------
        // グリッドのダブルクリック デリゲート
        // -------------------------------------------------------------
        public delegate void OnGridDoubleClickEhandler(OnGridDoubleClickArgs args);
        public event OnGridDoubleClickEhandler OnGridDoubleClick;

        public class OnGridDoubleClickArgs : EventArgs
        {
            public object Row;
        }

        // -------------------------------------------------------
        // コンストラクタ
        // -------------------------------------------------------
        public UcBasePager()
        {
            InitializeComponent();
        }

        // -------------------------------------------------------
        // ページを表示
        // -------------------------------------------------------
        public void ShowPage()
        {
            if (fullDataSource == null) return;

            var list = fullDataSource
                .Skip(CurrentCount - 1)
                .Take(RowsInPage)
                .ToList()
                ;

            bindingSource.DataSource = list;
            dataGridView.DataSource = bindingSource;

            if (list.Count == 0) return;

            SetDgvFormat();

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            CurrentCount = 1;
            ShowPage();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CurrentCount -= RowsInPage;
            ShowPage();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CurrentCount += RowsInPage;
            ShowPage();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            while (CurrentCount < rowCount)
            {
                CurrentCount += RowsInPage;
            }
            CurrentCount -= RowsInPage;

            ShowPage();
        }

        // ----------------------------------------------------------------
        // グリッドの書式
        // ----------------------------------------------------------------
        private void SetDgvFormat()
        {
            // 列幅の設定:
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                if (column.ValueType == typeof(int))
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (column.ValueType == typeof(DateTime))
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }

            OnGridFormat();
        }

        // ----------------------------------------------------------------
        // 一覧のダブルクリック
        // ----------------------------------------------------------------
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dataGridView.Rows[e.RowIndex].DataBoundItem;
                var arg = new OnGridDoubleClickArgs()
                {
                    Row = row
                };

                OnGridDoubleClick(arg);
            }
            catch
            {
                return;
            }
        }

        // -----------------------------------------------------
        // Excel 出力
        // -----------------------------------------------------
        private void buttonExcel_Click(object sender, EventArgs e)
        {
            // ボタンを連続でクリックできなくする
            this.buttonExcel.Enabled = false;

            //Excelオブジェクトの初期化
            Excel.Application ExcelApp = null;
            Excel.Workbooks exCurrentBooks = null;
            Excel.Workbook exCurrentBook = null;
            Excel.Worksheet exCurrentSheet = null;

            try
            {
                //待機状態
                Cursor.Current = Cursors.WaitCursor;

                //Excelシートのインスタンスを作る
                ExcelApp = new Excel.Application();

                exCurrentBooks = ExcelApp.Workbooks;
                exCurrentBook = ExcelApp.Workbooks.Add();
                exCurrentSheet = exCurrentBook.Worksheets[1];
                exCurrentSheet.Select(Type.Missing);

                // ヘッダー
                SetExcelHeader(exCurrentSheet);

                // リスト
                SetExcelList(exCurrentSheet);

                // 書式
                SetExcelFormat(exCurrentSheet);

            }

            finally
            {

                exCurrentSheet.Cells.Columns.AutoFit();

                //excel表示
                ExcelApp.Visible = true;

                //元に戻す
                Cursor.Current = Cursors.Default;
                this.buttonExcel.Enabled = true;

                // Excelオブジェクトの開放
                Marshal.ReleaseComObject(exCurrentSheet);
                exCurrentSheet = null;
                Marshal.ReleaseComObject(exCurrentBook);
                exCurrentBook = null;
                Marshal.ReleaseComObject(exCurrentBooks);
                exCurrentBooks = null;

                // アプリケーションの終了前にガベージ コレクトを強制します。
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();

                // Application オブジェクトを破棄します。
                Marshal.ReleaseComObject(ExcelApp); 
                ExcelApp = null;

                // Application オブジェクトのガベージ コレクトを強制します。
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }

        }


        // -----------------------------------------------------
        // ヘッダー
        // -----------------------------------------------------
        private void SetExcelHeader(Excel.Worksheet CurrentSheet)
        {
            int cols = dataGridView.Columns.Count;

            string[] Header = new string[cols];

            int col = 0;
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                Header[col] = column.HeaderText;
                col++;
            }

            Excel.Range rangeHeader = (Excel.Range)CurrentSheet.Cells[1, 1];
            rangeHeader = rangeHeader.get_Resize(1, cols);

            rangeHeader.Value = Header;
            rangeHeader.Interior.Color = Color.DarkBlue;
            rangeHeader.Font.Color = Color.White;
            rangeHeader.Font.Bold = true;
        }

        // -----------------------------------------------------
        // リスト
        // -----------------------------------------------------
        private void SetExcelList(Excel.Worksheet CurrentSheet)
        {
            int rows = fullDataSource.Count;
            int cols = dataGridView.Columns.Count;

            object[,] ListToExcel = new object[rows, cols];

            int row = 0;

            foreach (object ds in fullDataSource)
            {
                int i = 0;

                Type myType = ds.GetType();
                IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());

                foreach (PropertyInfo prop in props)
                {
                    object propValue = prop.GetValue(ds, null);
                    ListToExcel[row, i] = propValue;
                    i++;
                }
                row++;
            }

            Excel.Range range = CurrentSheet.Cells[2, 1];
            range = range.get_Resize(rows, cols);
            range.Value = ListToExcel;
        }

        // -----------------------------------------------------
        // 書式
        // -----------------------------------------------------
        private void SetExcelFormat(Excel.Worksheet CurrentSheet)
        {

            Excel.Range range = CurrentSheet.UsedRange;
            range.NumberFormatLocal = "0";

            // Z列を超える一覧は想定しない
            if (dataGridView.Columns.Count > 26)
            {
                throw new Exception("列数が多すぎる。EXCELへの転送は26列までしか想定していない。");
            }

            int c = 0;

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                char currentLetter = (char)(c + 65);

                if (column.DefaultCellStyle.Format == "MM/dd")
                {
                    Excel.Range range1 = CurrentSheet.get_Range(currentLetter + ":" + currentLetter);
                    range1.NumberFormatLocal = "yyyy/MM/dd";
                }

                if (column.DefaultCellStyle.Format == "C")
                {
                    Excel.Range range2 = CurrentSheet.get_Range(currentLetter + ":" + currentLetter);
                    range2.NumberFormatLocal = "\\ #,##0";
                }
                c++;
            }

        }

        // ------------------------------------------------------------
        // Grid内のデータ検索
        // ------------------------------------------------------------
        private void textBox検索_KeyPress(object sender, KeyPressEventArgs e)
        {
            //EnterやEscapeキーでビープ音が鳴らないようにする
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Escape)
            {
                e.Handled = true;
            }
        }

        private void textBox検索_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Set検索対象行();
            }

        }

        private void button検索_Click(object sender, EventArgs e)
        {

            Set検索対象行();
        }

        // キーワードを検索
        private void Set検索対象行()
        {
            // 入力値
            var キーワード = this.textBox検索.Text;
            if (string.IsNullOrWhiteSpace(キーワード)) return;

            // 複数ページにまたがる一覧の可能性はあるが、表示しているページ内だけで検索する
            // Datasourceから検索することも考えたが、テーブルの構造もわからないので、
            // 直接DataGridView内を検索する事にした。

            int currentRow = dataGridView.SelectedRows[0].Index+1;

            var キーワードRow = GetRowByキーワード(キーワード, currentRow);

            if(キーワードRow >= 0)
            {
                SelectAndShowRow(キーワードRow);
            }
            else
            {
                // 先頭から検索し直し
                キーワードRow = GetRowByキーワード(キーワード, 0);
                if (キーワードRow >= 0)
                {
                    SelectAndShowRow(キーワードRow);
                }
            }

        }

        private int GetRowByキーワード(string キーワード, int startRow)
        {
            for (int i = startRow; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    var cellVal = dataGridView.Rows[i].Cells[j].Value.ToString();
                    if (cellVal.Contains(キーワード))
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        private void SelectAndShowRow(int row)
        {
            dataGridView.Rows[row].Selected = true;
            if (!dataGridView.SelectedRows[0].Displayed)
            {
                // 対象行が画面内に表示されて居ないときだけ、表示範囲を切り替える
                dataGridView.FirstDisplayedScrollingRowIndex = row;
            }
        }
    }
}
