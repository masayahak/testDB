using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace テストDB.共通UI
{
    public partial class UcPageControl : UserControl
    {

        // -------------------------------------------------------
        // 公開プロパティ
        // -------------------------------------------------------
        private int currentCount;
        public int CurrentCount 
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
        public int RowsInPage;

        private int rowCount;
        public int RowCount 
        {
            get { return rowCount; }
            set { 
                rowCount = value;
                this.lblMaxCount.Text = rowCount.ToString();
            }
        }

        // -------------------------------------------------------------
        // 対象のグリッドビュー
        // -------------------------------------------------------------
        public DgvPager dgvPager { get; set; }

        // -------------------------------------------------------------
        // デリゲートイベントの定義
        // -------------------------------------------------------------
        // 親へイベントをデリゲートするためのイベントハンドラを定義
        public delegate void OnPageChangeEventHandler(OnPageChangeEventArgs args);
        public event OnPageChangeEventHandler OnPageChange;

        // デリゲートの引数を定義
        public class OnPageChangeEventArgs : EventArgs
        {
            public int CurrentCount;
            public int RowsInPage;
        }

        // 親へイベントをデリゲートするためのイベントハンドラを定義
        public delegate void EditExcelEventHandler(EditExcelEventArgs args);
        public event EditExcelEventHandler EditExcel;

        public class EditExcelEventArgs : EventArgs
        {
            public Excel.Worksheet exCurrentSheet;
        }


        // -------------------------------------------------------------
        // 初期化とロード
        // -------------------------------------------------------------
        public UcPageControl()
        {
            InitializeComponent();
        }

        // -------------------------------------------------------------
        // イベントの発火
        // -------------------------------------------------------------
        private void btnFirst_Click(object sender, EventArgs e)
        {
            CurrentCount = 1;

            // イベントの発火
            var arg = new OnPageChangeEventArgs
            {
                CurrentCount = CurrentCount,
                RowsInPage = RowsInPage

            };
            OnPageChange(arg);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CurrentCount -= RowsInPage;

            // イベントの発火
            var arg = new OnPageChangeEventArgs
            {
                CurrentCount = CurrentCount,
                RowsInPage = RowsInPage

            };
            OnPageChange(arg);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CurrentCount += RowsInPage;

            // イベントの発火
            var arg = new OnPageChangeEventArgs
            {
                CurrentCount = CurrentCount,
                RowsInPage = RowsInPage

            };
            OnPageChange(arg);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            while (CurrentCount < rowCount)
            {
                CurrentCount += RowsInPage;
            }
            CurrentCount -= RowsInPage;

            // イベントの発火
            var arg = new OnPageChangeEventArgs
            {
                CurrentCount = CurrentCount,
                RowsInPage = RowsInPage

            };
            OnPageChange(arg);
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

        // -----------------------------------------------------
        // Excel 出力
        // -----------------------------------------------------
        private void buttonExcel_Click(object sender, EventArgs e)
        {
            // ボタンを連続でクリックできなくする
            this.buttonExcel.Enabled = false;

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

                // ヘッダー
                SetExcelHeader(exCurrentSheet);

                // リスト
                SetExcelList(exCurrentSheet);

                // 書式
                SetExcelFormat(exCurrentSheet);

                // -----------------------------------------------------
                // 追加工
                // -----------------------------------------------------
                var arg = new EditExcelEventArgs
                {
                    exCurrentSheet = exCurrentSheet
                };

                EditExcel(arg);
            }

            finally
            {
                exCurrentSheet.Cells.Columns.AutoFit();

                //excel表示
                ExcelApp.Visible = true;

                //元に戻す
                Cursor.Current = Cursors.Default;
            }


            this.buttonExcel.Enabled = true;
        }


        // -----------------------------------------------------
        // ヘッダー
        // -----------------------------------------------------
        private void SetExcelHeader(Excel.Worksheet CurrentSheet)
        {
            int cols = dgvPager.Columns.Count;

            string[] Header = new string[cols];

            int col = 0;
            foreach (DataGridViewColumn column in dgvPager.Columns)
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
            int rows = dgvPager.fullDataSource.Count;
            int cols = dgvPager.Columns.Count;

            object[,] ListToExcel = new object[rows, cols];

            int row = 0;

            foreach (object ds in dgvPager.fullDataSource)
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
            int c = 0;
            foreach (DataGridViewColumn column in dgvPager.Columns)
            {
                // todo Z列を超える一覧は無いはず
                char currentLetter = (char)(c + 65);

                if (column.DefaultCellStyle.Format == "MM/dd")
                {
                    Excel.Range formatRange = CurrentSheet.get_Range(currentLetter + ":" + currentLetter);
                    formatRange.NumberFormatLocal = "yyyy/MM/dd";
                }

                if (column.DefaultCellStyle.Format == "C")
                {
                    Excel.Range formatRange = CurrentSheet.get_Range(currentLetter + ":" + currentLetter);
                    formatRange.NumberFormatLocal = "\\ #,##0";
                }

                c++;
            }
        }


    }
}
