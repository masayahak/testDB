using System;
using System.Drawing;
using System.Windows.Forms;
using テストDB.Models;
using テストDB.ViewModel;

namespace テストDB.共通UI
{
    public partial class Uc得意先入力 : UserControl
    {
        private Uc得意先検索 _uc得意先検索;

        public Uc得意先検索 uc得意先検索
        {
            get { return _uc得意先検索; }
            set { _uc得意先検索 = value; }
        }

        private M得意先J担当者 _m得意先J担当者;

        public M得意先J担当者 M得意先J担当者
        {

            get { return _m得意先J担当者; }
            set
            {
                _m得意先J担当者 = value;

                if (_m得意先J担当者 == null)
                {
                    _m得意先J担当者 = new M得意先J担当者
                    {
                        ID = -1,
                        得意先CD = "",
                        得意先名 = ""
                    };
                }

                this.textBox得意先ID.Text = _m得意先J担当者.ID.ToString();
                this.textBox得意先CD.Text = _m得意先J担当者.得意先CD;
                this.textBox得意先名.Text = _m得意先J担当者.得意先名;

                if (_m得意先J担当者.ID == -1)
                {
                    this.textBox得意先名.ForeColor = Color.Red;
                }
                else
                {
                    this.textBox得意先名.ForeColor = Color.Black;
                }
            }
        }

        private bool _ReadOnly得意先CD;

        public bool ReadOnly得意先CD
        {
            get { return _ReadOnly得意先CD; }
            set
            {
                _ReadOnly得意先CD = value;
                this.textBox得意先CD.ReadOnly = _ReadOnly得意先CD;
            }
        }

        public Uc得意先入力()
        {
            InitializeComponent();
        }

        private void button検索得意先_Click(object sender, EventArgs e)
        {
            uc得意先検索.Visible = !uc得意先検索.Visible;

            if (uc得意先検索.Visible)
                uc得意先検索.BringToFront();

            uc得意先検索.得意先CD = this.textBox得意先CD.Text;
        }

        // ------------------------------------------------------------
        // 得意先CDの直接入力
        // ------------------------------------------------------------
        private void textBox得意先CD_KeyPress(object sender, KeyPressEventArgs e)
        {
            //EnterやEscapeキーでビープ音が鳴らないようにする
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Escape)
            {
                e.Handled = true;
            }
        }

        private void textBox得意先CD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Get得意先();
            }
        }
        private void textBox得意先CD_Leave(object sender, EventArgs e)
        {
            Get得意先();
        }

        private void Get得意先()
        {
            var 得意先CD = this.textBox得意先CD.Text;
            if (string.IsNullOrWhiteSpace(得意先CD))
            {
                this.M得意先J担当者 = new M得意先J担当者
                {
                    ID = -1,
                    得意先CD = "",
                    得意先名 = "",
                };
                return;
            }

            try
            {
                var vm得意先 = new ViewModel得意先();
                this.M得意先J担当者 = vm得意先.Get得意先By得意先CD(得意先CD);
            }
            catch
            {
                // 得意先を発見できない
                this.M得意先J担当者 = new M得意先J担当者
                {
                    ID = -1,
                    得意先CD = textBox得意先CD.Text,
                    得意先名 = "※ 該当得意先なし",
                };
            }

        }

    }
}
