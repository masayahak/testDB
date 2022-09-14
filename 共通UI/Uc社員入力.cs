using System;
using System.Drawing;
using System.Windows.Forms;
using テストDB.Models;
using テストDB.ViewModel;

namespace テストDB.共通UI
{
    public partial class Uc社員入力 : UserControl
    {

        private Uc社員検索 _userControl社員検索;

        public Uc社員検索 userControl社員検索
        {
            get { return _userControl社員検索; }
            set { _userControl社員検索 = value; }
        }

        private M社員 _m社員;

        public M社員 M社員 {
        
            get { return _m社員; }
            set {
                _m社員 = value;

                if (_m社員 == null)
                {
                    _m社員 = new M社員
                    {
                        ID = -1,
                        社員番号 = "",
                        社員名 = ""
                    };
                }

                this.textBox社員ID.Text = _m社員.ID.ToString();
                this.textBox社員番号.Text = _m社員.社員番号;
                this.textBox社員名.Text = _m社員.社員名;

                if (_m社員.ID == -1)
                {
                    this.textBox社員名.ForeColor = Color.Red;
                }
                else
                {
                    this.textBox社員名.ForeColor = Color.Black;
                }
            }
        }

        private bool _ReadOnly社員番号;

        public bool ReadOnly社員番号
        {
            get { return _ReadOnly社員番号; }
            set { 
                _ReadOnly社員番号 = value;
                this.textBox社員番号.ReadOnly = _ReadOnly社員番号;
            }
        }


        public Uc社員入力()
        {
            InitializeComponent();
        }

        private void button検索社員_Click(object sender, EventArgs e)
        {
            userControl社員検索.Visible = !userControl社員検索.Visible;

            if (userControl社員検索.Visible)
                userControl社員検索.BringToFront();

            userControl社員検索.社員番号 = this.textBox社員番号.Text;
        }


        // ------------------------------------------------------------
        // 社員番号の直接入力
        // ------------------------------------------------------------
        private void textBox社員番号_KeyPress(object sender, KeyPressEventArgs e)
        {
            //EnterやEscapeキーでビープ音が鳴らないようにする
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Escape)
            {
                e.Handled = true;
            }
        }

        private void textBox社員番号_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Get社員();
            }
        }
        private void textBox社員番号_Leave(object sender, EventArgs e)
        {
            Get社員();
        }

        private void Get社員()
        {
            var 社員番号 = this.textBox社員番号.Text;
            if (string.IsNullOrWhiteSpace(社員番号))
            {
                this.M社員 = new M社員
                {
                    ID = -1,
                    社員番号 = "",
                    社員名 = "",
                };
                return; 
            }


            try
            {
                var vm社員 = new ViewModel社員();
                this.M社員 = vm社員.Get社員By社員番号(社員番号);
            }
            catch
            {
                // 社員を発見できない
                this.M社員 = new M社員
                {
                    ID = -1,
                    社員番号 = textBox社員番号.Text,
                    社員名 = "※ 該当社員なし",
                };
            }

        }
    }
}
