using System;
using System.Windows.Forms;
using テストDB.Models;
using テストDB.ViewModel;

namespace テストDB.共通UI
{
    public partial class Uc社員検索 : UserControl
    {

        private string _社員番号;

        public string 社員番号
        {
            get { return _社員番号; }
            set
            {
                _社員番号 = value;

                if (string.IsNullOrWhiteSpace(_社員番号)) return;
                Set検索対象行(_社員番号);

            }
        }

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
            }
        }

        // ------------------------------------------------------------
        //  初期化
        // ------------------------------------------------------------
        DAndDSizeChanger sizeChanger;
        public Uc社員検索()
        {
            InitializeComponent();
        }

        public class On社員番号SelectedEventArgs : EventArgs
        {
            public M社員 m社員;
        }

        // 親へ選択した社員番号をデリゲート
        public delegate void On社員番号SelectedEventHandler(On社員番号SelectedEventArgs e);

        public event On社員番号SelectedEventHandler On社員番号Selected;

        // ------------------------------------------------------------
        // コントロール表示時に全データを読み込み
        //      ただし、デザインモードではデータを読み込まない
        // ------------------------------------------------------------

        private void UserControl社員入力_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            sizeChanger = new DAndDSizeChanger(this.panel検索, this, DAndDArea.WithoutTop, 8);

            DataLoad();
        }

        private void DataLoad()
        {

            vm社員 = new ViewModel社員();
            dataGridView社員一覧.DataSource = vm社員.list社員;

            // 列幅の設定:
            dataGridView社員一覧.Columns[0].Visible = false;
            dataGridView社員一覧.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView社員一覧.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
        // Grid内のデータをダブルクリック
        // ------------------------------------------------------------

        private void dataGridView社員一覧_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView社員一覧.SelectedRows[0].Index;
            var 社員 = vm社員.list社員[row];

            var arg = new On社員番号SelectedEventArgs()
            {
                m社員 = 社員,
            };

            On社員番号Selected(arg);

            this.Visible = false;
        }

    }
}
