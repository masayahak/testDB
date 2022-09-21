using System;
using System.Windows.Forms;
using テストDB.Models;
using テストDB.ViewModel;

namespace テストDB.共通UI
{
    public partial class Uc得意先検索 : UserControl
    {
        private string _得意先CD;

        public string 得意先CD
        {
            get { return _得意先CD; }
            set
            {
                _得意先CD = value;

                if (string.IsNullOrWhiteSpace(_得意先CD)) return;
                Set検索対象行(_得意先CD);

            }
        }

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
                if (!dataGridView得意先一覧.SelectedRows[0].Displayed)
                {
                    // 対象行が画面内に表示されて居ないときだけ、表示範囲を切り替える
                    dataGridView得意先一覧.FirstDisplayedScrollingRowIndex = _currentRow;
                }
            }
        }

        // ------------------------------------------------------------
        //  初期化
        // ------------------------------------------------------------
        DAndDSizeChanger sizeChanger;
        public Uc得意先検索()
        {
            InitializeComponent();
        }

        public class On得意先CDSelectedEventArgs : EventArgs
        {
            public M得意先一覧 m得意先一覧;
        }

        // 親へ選択した得意先CDをデリゲート
        public delegate void On得意先CDSelectedEventHandler(On得意先CDSelectedEventArgs e);

        public event On得意先CDSelectedEventHandler On得意先CDSelected;

        // ------------------------------------------------------------
        // コントロール表示時に全データを読み込み
        //      ただし、デザインモードではデータを読み込まない
        // ------------------------------------------------------------

        private void UserControl得意先入力_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            sizeChanger = new DAndDSizeChanger(this.panel検索, this, DAndDArea.WithoutTop, 8);

            DataLoad();
        }

        private void DataLoad()
        {

            vm得意先 = new ViewModel得意先();
            dataGridView得意先一覧.DataSource = vm得意先.list得意先一覧;

            // 列幅の設定:
            dataGridView得意先一覧.Columns[0].Visible = false;
            dataGridView得意先一覧.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView得意先一覧.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView得意先一覧.Columns[3].Visible = false;
            dataGridView得意先一覧.Columns[4].Visible = false;
            dataGridView得意先一覧.Columns[5].Visible = false;
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
            var selectedRow = dataGridView得意先一覧.SelectedRows[0].Index;

            // 得意先名と得意先CDから検索
            var row = vm得意先.FindRow得意先一覧(キーワード, selectedRow + 1);
            if (row == 0)
            {
                // 先頭より検索得意先名と得意先CDから検索
                row = vm得意先.FindRow得意先一覧(キーワード, 0);

            }
            // 最初に見つかった検索結果行を表示
            this.currentRow = row;
        }

        // ------------------------------------------------------------
        // Grid内のデータをダブルクリック
        // ------------------------------------------------------------

        private void dataGridView得意先一覧_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView得意先一覧.SelectedRows[0].Index;
            var 得意先一覧 = vm得意先.list得意先一覧[row];

            var arg = new On得意先CDSelectedEventArgs()
            {
                m得意先一覧 = 得意先一覧,
            };

            On得意先CDSelected(arg);

            this.Visible = false;
        }
    }
}
