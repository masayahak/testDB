using System;
using System.Windows.Forms;
using テストDB.Models;
using テストDB.共通UI;
using static テストDB.共通UI.Uc社員検索;
using テストDB.ViewModel;
using System.Threading.Tasks;

namespace テストDB.UI
{
    public partial class Form得意先メンテ : Form
    {
        // ------------------------------------------------------------
        // ViewModel
        // ------------------------------------------------------------
        private ViewModel得意先 vm得意先;

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

                dataGridView得意先一覧.Rows[_currentRow].Selected = true;

                // 選択行が表示されているかを判定すると、ギリギリ一部が表示されているだけで
                // 表示されている判定される。これでは困る。
                // 選択行の1行下が表示されているか判定する。
                var currentRowPlus1 = _currentRow + 1;

                if (currentRowPlus1 >= dataGridView得意先一覧.RowCount)
                {
                    currentRowPlus1 -= 1;
                }

                if (!dataGridView得意先一覧.Rows[currentRowPlus1].Displayed)
                {
                    // 対象行が画面内に表示されて居ないときだけ、表示範囲を切り替える
                    dataGridView得意先一覧.FirstDisplayedScrollingRowIndex = _currentRow;
                }


                var 得意先 = vm得意先.list得意先一覧[_currentRow];

                // 行を表示する
                ShowRow(得意先);

            }
        }

        private void ShowRow(M得意先一覧 得意先)
        {
            textBox得意先ID.Text = 得意先.ID.ToString();
            textBox得意先CD.Text = 得意先.得意先CD;
            textBox得意先名.Text = 得意先.得意先名;

            textBox担当社員ID.Text = 得意先.担当社員ID.ToString();
            uc社員入力.M社員 = new M社員
            {
                ID = 得意先.担当社員ID,
                社員番号 = 得意先.担当社員番号,
                社員名 = 得意先.担当社員名,
            };
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
            this.textBox得意先ID.Text = "-1";
            this.textBox得意先CD.Text = "";
            this.textBox得意先名.Text = "";
            this.textBox担当社員ID.Text = "";
            uc社員入力.M社員 = new M社員
            {
                ID = -1,
                社員番号 = "",
                社員名 = "",
            };

            this.textBox得意先CD.ReadOnly = false;
            this.textBox得意先名.ReadOnly = false;
            this.uc社員入力.ReadOnly社員番号 = false;

            button削除.Enabled = false;
            button保存.Enabled = true;
            buttonｷｬﾝｾﾙ.Enabled = true;

            this.panel検索.Visible = false;
            this.dataGridView得意先一覧.Visible = false;
            this.panel詳細.Visible = true;
            this.panel詳細.Dock = DockStyle.Fill;

        }

        private void ChangeMode_修正()
        {
            this.textBox得意先CD.ReadOnly = false;
            this.textBox得意先名.ReadOnly = false;
            this.uc社員入力.ReadOnly社員番号 = false;

            button削除.Enabled = true;
            button保存.Enabled = true;
            buttonｷｬﾝｾﾙ.Enabled = true;

            this.panel検索.Visible = false;
            this.dataGridView得意先一覧.Visible = false;
            this.panel詳細.Visible = true;
            this.panel詳細.Dock = DockStyle.Fill;

        }

        private void ChangeMode_照会()
        {
            this.textBox得意先CD.ReadOnly = true;
            this.textBox得意先名.ReadOnly = true;
            this.uc社員入力.ReadOnly社員番号 = true;

            button削除.Enabled = false;
            button保存.Enabled = false;
            buttonｷｬﾝｾﾙ.Enabled = false;

            this.panel検索.Visible = true;
            this.dataGridView得意先一覧.Visible = true;
            this.dataGridView得意先一覧.Dock = DockStyle.Fill;
            this.panel詳細.Visible = false;

        }

        private void On社員番号_Selected(On社員番号SelectedEventArgs arg)
        {
            uc社員入力.M社員 = arg.m社員;
        }


        // ------------------------------------------------------------
        //  初期化
        // ------------------------------------------------------------
        public Form得意先メンテ()
        {
            InitializeComponent();

            userControl処理モード.ChangeMode追加 += ChangeMode_追加;
            userControl処理モード.ChangeMode修正 += ChangeMode_修正;
            userControl処理モード.ChangeMode照会 += ChangeMode_照会;

            userControl処理モード.ChangeMode_照会();


            uc社員検索.Visible = false;
            uc社員検索.On社員番号Selected += On社員番号_Selected;
        }


        // ------------------------------------------------------------
        // コントロール表示時に全データを読み込み
        //      ただし、デザインモードではデータを読み込まない
        // ------------------------------------------------------------
        private async void Form得意先メンテ_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            // ロード中
            ShowWaitForm();

            // 非同期でデータ取得
            await Task.Run(() =>
            {
                DataLoad();
            });

            // 先頭行を初期表示
            dataGridView得意先一覧.DataSource = vm得意先.list得意先一覧;

            // 列幅の設定:
            dataGridView得意先一覧.Columns[0].Visible = false;
            dataGridView得意先一覧.Columns[3].Visible = false;
            dataGridView得意先一覧.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView得意先一覧.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView得意先一覧.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.currentRow = 0;

            // ロード終了
            OnLoaded();
        }

        private void DataLoad()
        {
            vm得意先 = new ViewModel得意先();
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
            var selectedRow = dataGridView得意先一覧.SelectedRows[0].Index;

            var row = vm得意先.FindRow得意先一覧(キーワード, selectedRow + 1);
            if (row == 0)
            {
                row = vm得意先.FindRow得意先一覧(キーワード, 0);

            }
            // 最初に見つかった検索結果行を表示
            this.currentRow = row;
        }

        // ------------------------------------------------------------
        // Grid内の選択データを表示
        // ------------------------------------------------------------
        private void dataGridView得意先一覧_SelectionChanged(object sender, EventArgs e)
        {
            dataGrid_Selected();
        }

        private void dataGridView得意先一覧_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGrid_Selected();
        }

        private void dataGrid_Selected()
        {
            // 照会中以外はなにもしない
            if (userControl処理モード.状態 != 処理モード.状態.照会中)
                return;

            // 選択行を表示
            if (dataGridView得意先一覧.SelectedRows.Count > 0)
                this.currentRow = dataGridView得意先一覧.SelectedRows[0].Index;
        }

        // ------------------------------------------------------------
        // Grid内の選択データをダブルクリックして直接修正モード
        // ------------------------------------------------------------
        private void dataGridView得意先一覧_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                    ID = 得意先Add();
                }
                else
                {
                    ID = 得意先Update();
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
            this.currentRow = vm得意先.FindRowByID(ID);

        }

        // ------------------------------------------------------------
        // 入力情報のチェック
        // ------------------------------------------------------------
        private bool IsInputCheckError()
        {

            var 得意先CD = textBox得意先CD.Text;
            if (string.IsNullOrWhiteSpace(得意先CD))
            {
                MessageBox.Show("得意先CDは必須です。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return true;
            }

            var 得意先名 = textBox得意先名.Text;
            if (string.IsNullOrWhiteSpace(得意先名))
            {
                MessageBox.Show("得意先名は必須です。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return true;
            }

            if (uc社員入力.M社員.ID <= 0)
            {
                MessageBox.Show("担当者は必須です。",
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
        private int 得意先Add()
        {

            var 追加得意先 = new M得意先
            {
                得意先CD = textBox得意先CD.Text,
                得意先名 = textBox得意先名.Text,
                担当社員ID = uc社員入力.M社員.ID,
            };

            var ID = vm得意先.Add(追加得意先);
            return ID;
        }

        private int 得意先Update()
        {
            var 更新得意先 = new M得意先
            {
                ID = int.Parse(textBox得意先ID.Text),
                得意先CD = textBox得意先CD.Text,
                得意先名 = textBox得意先名.Text,
                担当社員ID = uc社員入力.M社員.ID,
            };

            vm得意先.Update(更新得意先);
            return 更新得意先.ID;
        }

        // ------------------------------------------------------------
        // 削除ボタン
        // ------------------------------------------------------------
        private void button削除_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("削除しますか？",
                "確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                //「はい」が選択された時
                try
                {
                    得意先Delete();
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
        }

        private void 得意先Delete()
        {

            var ID = int.Parse(textBox得意先ID.Text);
            vm得意先.Delete(ID);

            // 削除が終わったら照会モードへ
            userControl処理モード.ChangeMode_照会();
            // データ再取得
            DataLoad();

            // 今は削除後は先頭行が選択状態になる。
            // ちょっと微妙かとも思うが、マスターメンテナンスで削除されたデータの
            // １つ前を表示すると、なぜそれが選択されているのか直感的にわからない。
        }
    }
}
