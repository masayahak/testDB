using System;
using System.Windows.Forms;
using テストDB.Models;
using テストDB.ViewModel;

namespace テストDB.共通UI
{
    public partial class Uc商品検索 : UserControl
    {
        private string _バーコード;

        public string バーコード
        {
            get { return _バーコード; }
            set
            {
                _バーコード = value;

                if (string.IsNullOrWhiteSpace(_バーコード)) return;
                Set検索対象行(_バーコード);

            }
        }

        // ------------------------------------------------------------
        // ViewModel
        // ------------------------------------------------------------
        private ViewModel商品 vm商品;

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

                dataGridView商品一覧.Rows[_currentRow].Selected = true;
                if (!dataGridView商品一覧.SelectedRows[0].Displayed)
                {
                    // 対象行が画面内に表示されて居ないときだけ、表示範囲を切り替える
                    dataGridView商品一覧.FirstDisplayedScrollingRowIndex = _currentRow;
                }
            }
        }

        // ------------------------------------------------------------
        //  初期化
        // ------------------------------------------------------------
        DAndDSizeChanger sizeChanger;
        public Uc商品検索()
        {
            InitializeComponent();
        }

        public class OnバーコードSelectedEventArgs : EventArgs
        {
            public M商品 m商品;
        }

        // 親へ選択したバーコードをデリゲート
        public delegate void OnバーコードSelectedEventHandler(OnバーコードSelectedEventArgs e);

        public event OnバーコードSelectedEventHandler OnバーコードSelected;

        // ------------------------------------------------------------
        // コントロール表示時に全データを読み込み
        //      ただし、デザインモードではデータを読み込まない
        // ------------------------------------------------------------

        private void UserControl商品入力_Load(object sender, EventArgs e)
        {
            sizeChanger = new DAndDSizeChanger(this.panel検索, this, DAndDArea.WithoutTop, 8);

            if (!DesignMode)
            {
                DataLoad();
            }
        }

        private void DataLoad()
        {

            vm商品 = new ViewModel商品();


            dataGridView商品一覧.DataSource = vm商品.list商品;

            // 列幅の設定:
            dataGridView商品一覧.Columns[0].Visible = false;
            dataGridView商品一覧.Columns[1].Width = 100;
            dataGridView商品一覧.Columns[2].Width = 100;
            dataGridView商品一覧.Columns[3].Visible = false;
            dataGridView商品一覧.Columns[4].Visible = false;
        }

        // ------------------------------------------------------------
        // 閉じる（非表示）
        // ------------------------------------------------------------
        private void button閉じる_Click(object sender, EventArgs e)
        {
            this.Visible = false;
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
                // 入力値
                var キーワード = this.textBox検索.Text;
                if (string.IsNullOrWhiteSpace(キーワード)) return;
                Set検索対象行(キーワード);
            }

        }

        private void button検索_Click(object sender, EventArgs e)
        {

            // 入力値
            var キーワード = this.textBox検索.Text;
            if (string.IsNullOrWhiteSpace(キーワード)) return;
            Set検索対象行(キーワード);
        }

        // キーワードを検索
        private void Set検索対象行(string キーワード)
        {
            // 現在行より下を検索
            var selectedRow = dataGridView商品一覧.SelectedRows[0].Index;

            // 商品名とバーコードから検索
            var row = vm商品.FindRow商品(キーワード, selectedRow + 1);
            if (row == 0)
            {
                // 先頭より検索商品名とバーコードから検索
                row = vm商品.FindRow商品(キーワード, 0);

            }
            // 最初に見つかった検索結果行を表示
            this.currentRow = row;
        }

        // ------------------------------------------------------------
        // Grid内のデータをダブルクリック
        // ------------------------------------------------------------

        private void dataGridView商品一覧_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView商品一覧.SelectedRows[0].Index;
            var 商品 = vm商品.list商品[row];

            var arg = new OnバーコードSelectedEventArgs()
            {
                m商品 = 商品,
            };

            OnバーコードSelected(arg);

            this.Visible = false;
        }

    }


}
