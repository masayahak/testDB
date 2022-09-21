using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using テストDB.Models;
using テストDB.ViewModel;
using Excel = Microsoft.Office.Interop.Excel;

namespace テストDB.UI
{
    public partial class Form社員メンテ : Form
    {
        // ------------------------------------------------------------
        // ViewModel
        // ------------------------------------------------------------
        private ViewModel社員 vm社員;

        // ------------------------------------------------------------
        // 作業中の行
        // ------------------------------------------------------------
        private int _currentRow = -1;
        private int currentRow
        {
            get { return _currentRow; }
            set
            {
                _currentRow = value;

                dataGridView社員一覧.Rows[_currentRow].Selected = true;
                if (!dataGridView社員一覧.SelectedRows[0].Displayed)
                {
                    // 対象行が画面内に表示されて居ないときだけ、表示範囲を切り替える
                    dataGridView社員一覧.FirstDisplayedScrollingRowIndex = _currentRow;
                }

                var 社員 = vm社員.list社員[_currentRow];
                ShowRow(社員);
            }
        }

        private void ShowRow(M社員 社員)
        {
            textBox社員ID.Text = 社員.ID.ToString();
            textBox社員番号.Text = 社員.社員番号;
            textBox社員名.Text = 社員.社員名;
        }

        // ------------------------------------------------------------
        //  処理モードの変更
        // ------------------------------------------------------------
        private void buttonｷｬﾝｾﾙ_Click(object sender, EventArgs e)
        {
            userControl処理モード.ChangeMode_照会();

            // 作業中の内容を破棄し、選択されているデータで再描画
            this.currentRow = this.currentRow;
        }

        // ------------------------------------------------------------
        //  処理モード変更時
        // ------------------------------------------------------------
        private void ChangeMode_追加()
        {
            this.textBox社員ID.Text = "-1";
            this.textBox社員番号.Text = "";
            this.textBox社員名.Text = "";

            this.textBox社員番号.ReadOnly = false;
            this.textBox社員名.ReadOnly = false;

            button削除.Enabled = false;
            button保存.Enabled = true;
            buttonｷｬﾝｾﾙ.Enabled = true;

        }

        private void ChangeMode_修正()
        {
            this.textBox社員番号.ReadOnly = false;
            this.textBox社員名.ReadOnly = false;

            button削除.Enabled = true;
            button保存.Enabled = true;
            buttonｷｬﾝｾﾙ.Enabled = true;

        }

        private void ChangeMode_照会()
        {
            this.textBox社員番号.ReadOnly = true;
            this.textBox社員名.ReadOnly = true;

            button削除.Enabled = false;
            button保存.Enabled = false;
            buttonｷｬﾝｾﾙ.Enabled = false;


        }

        // ------------------------------------------------------------
        //  初期化
        // ------------------------------------------------------------
        public Form社員メンテ()
        {
            InitializeComponent();

            userControl処理モード.ChangeMode追加 += ChangeMode_追加;
            userControl処理モード.ChangeMode修正 += ChangeMode_修正;
            userControl処理モード.ChangeMode照会 += ChangeMode_照会;

            userControl処理モード.ChangeMode_照会();

        }


        // ------------------------------------------------------------
        // コントロール表示時に全データを読み込み
        //      ただし、デザインモードではデータを読み込まない
        // ------------------------------------------------------------
        private async void Form社員メンテ_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            // ロード中
            ShowWaitForm();

            // 非同期でデータ取得
            await Task.Run(() =>
            {
                DataLoad();
            });

            // データ表示
            dataGridView社員一覧.DataSource = vm社員.list社員;

            // 列幅の設定:
            dataGridView社員一覧.Columns[0].Visible = false;
            dataGridView社員一覧.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView社員一覧.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.currentRow = 0;

            // ロード終了
            OnLoaded();
        }

        private void DataLoad()
        {
            vm社員 = new ViewModel社員();
        }

        // ロード中
        private void ShowWaitForm()
        {
            this.panel検索.Visible = false;
            this.panel詳細.Visible = false;
            this.panel操作.Visible = false;

            this.pictureBoxロード中.Visible = true;
        }

        private void OnLoaded()
        {
            this.pictureBoxロード中.Dock = DockStyle.None;
            this.pictureBoxロード中.Visible = false;

            this.panel検索.Visible = true;
            this.panel詳細.Visible = true;
            this.panel操作.Visible = true;
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

            // 現在行より下を検索
            var selectedRow = dataGridView社員一覧.SelectedRows[0].Index;

            // 社員名と社員番号から検索
            var row = vm社員.FindRow社員(キーワード, selectedRow + 1);
            if (row == 0)
            {
                // 先頭より検索社員名と社員番号から検索
                row = vm社員.FindRow社員(キーワード, 0);

            }
            // 最初に見つかった検索結果行を表示
            this.currentRow = row;
        }

        // ------------------------------------------------------------
        // Grid内の選択データを表示
        // ------------------------------------------------------------
        private void dataGridView社員一覧_SelectionChanged(object sender, EventArgs e)
        {
            dataGrid_Selected();
        }

        private void dataGridView社員一覧_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGrid_Selected();
        }

        private void dataGrid_Selected()
        {
            // 照会中以外はなにもしない
            if (userControl処理モード.状態 != 処理モード.状態.照会中)
                return;

            // 選択行を表示
            if (dataGridView社員一覧.SelectedRows.Count > 0)
                this.currentRow = dataGridView社員一覧.SelectedRows[0].Index;
        }

        // ------------------------------------------------------------
        // Grid内の選択データをダブルクリックして直接修正モード
        // ------------------------------------------------------------
        private void dataGridView社員一覧_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGrid_Selected();
            userControl処理モード.ChangeMode_修正();
        }

        // ------------------------------------------------------------
        // 保存ボタン
        // ------------------------------------------------------------
        private void button保存_Click(object sender, EventArgs e)
        {

            if (IsInputCheckError()) return;

            int ID;
            try
            {
                if (userControl処理モード.状態 == 処理モード.状態.追加中)
                {
                    ID = 社員Add();
                }
                else
                {
                    ID = 社員Update();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("データベースに登録できませんでした。\r\n" + ex.Message,
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }


            // 追加 or 修正が終わったら照会モードへ
            userControl処理モード.ChangeMode_照会();

            // データ再取得
            DataLoad();
            this.currentRow = vm社員.FindRowByID(ID);

        }

        // ------------------------------------------------------------
        // 入力情報のチェック
        // ------------------------------------------------------------
        private bool IsInputCheckError()
        {

            var 社員番号 = textBox社員番号.Text;
            if (string.IsNullOrWhiteSpace(社員番号))
            {
                MessageBox.Show("社員番号は必須です。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return true;
            }

            var 社員名 = textBox社員名.Text;
            if (string.IsNullOrWhiteSpace(社員名))
            {
                MessageBox.Show("社員名は必須です。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return true;
            }

            return false;
        }


        // ------------------------------------------------------------
        // DB更新
        // ------------------------------------------------------------
        private int 社員Add()
        {

            var 追加社員 = new M社員
            {
                社員番号 = textBox社員番号.Text,
                社員名 = textBox社員名.Text,

            };
            var ID = vm社員.Add(追加社員);
            return ID;
        }

        private int 社員Update()
        {
            var 更新社員 = new M社員
            {
                ID = int.Parse(textBox社員ID.Text),
                社員番号 = textBox社員番号.Text,
                社員名 = textBox社員名.Text,

            };
            vm社員.Update(更新社員);
            return 更新社員.ID;
        }

        // ------------------------------------------------------------
        // 削除ボタン
        // ------------------------------------------------------------
        private void button削除_Click(object sender, EventArgs e)
        {

            var ID = int.Parse(textBox社員ID.Text);

            // 削除したい社員が担当している得意先が１件でもあったらダメ
            var vm得意先 = new ViewModel得意先();
            if (vm得意先.GetCount担当得意先(ID) > 0)
            {
                MessageBox.Show("担当している得意先があるので削除できません。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            var result = MessageBox.Show("削除しますか？",
                "確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            //「はい」以外はなにもしない。
            if (result != DialogResult.Yes) return;


            try
            {
                社員Delete(ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("データベースから削除できませんでした。\r\n" + ex.Message,
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

        }

        private void 社員Delete(int ID)
        {

            vm社員.Delete(ID);

            // 削除が終わったら照会モードへ
            userControl処理モード.ChangeMode_照会();
            // データ再取得
            DataLoad();

            // 今は削除後は先頭行が選択状態になる。
            // ちょっと微妙かとも思うが、マスターメンテナンスで削除されたデータの
            // １つ前を表示すると、なぜそれが選択されているのか直感的にわからない。
        }

        // ------------------------------------------------------------
        // EXCELボタン
        // ------------------------------------------------------------
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
                //Excelシートのインスタンスを作る
                ExcelApp = new Excel.Application();

                exCurrentBooks = ExcelApp.Workbooks;
                exCurrentBook = ExcelApp.Workbooks.Add();
                exCurrentSheet = exCurrentBook.Sheets[1];

                exCurrentSheet.Select(Type.Missing);

                // ヘッダー
                exCurrentSheet.Cells[1, 1].Value2 = "ID";
                exCurrentSheet.Cells[1, 2].Value2 = "社員番号";
                exCurrentSheet.Cells[1, 3].Value2 = "社員名";
                Excel.Range range = exCurrentSheet.Range[exCurrentSheet.Cells[1, 1], exCurrentSheet.Cells[1, 3]];
                range.Interior.Color = Color.DarkBlue;
                range.Font.Color = Color.White;
                range.Font.Bold = true;

                var row = 1;

                // エクセルファイルにデータをセットする
                foreach (var 社員 in vm社員.list社員)
                {
                    row++;

                    // 行
                    exCurrentSheet.Cells[row, 1].Value2 = 社員.ID;
                    exCurrentSheet.Cells[row, 2].Value2 = 社員.社員番号;
                    exCurrentSheet.Cells[row, 3].Value2 = 社員.社員名;
                }

            }
            finally
            {
                exCurrentSheet.Cells.Columns.AutoFit();

                //excel表示
                ExcelApp.Visible = true;

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

                // ボタンを連続でクリックできなくする
                this.buttonExcel.Enabled = true;
            }
        }
    }
}
