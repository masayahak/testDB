using System;
using System.Drawing;
using System.Windows.Forms;
using テストDB.Models;
using テストDB.ViewModel;

namespace 共通UI
{
    public partial class Uc商品入力 : UserControl
    {
        private Uc商品検索 _uc商品検索;

        public Uc商品検索 uc商品検索
        {
            get { return _uc商品検索; }
            set { _uc商品検索 = value; }
        }

        private M商品 _m商品;

        public M商品 M商品
        {

            get { return _m商品; }
            set
            {
                _m商品 = value;

                if (_m商品 == null)
                {
                    _m商品 = new M商品
                    {
                        ID = -1,
                        バーコード = "",
                        商品名 = ""
                    };
                }

                this.textBox商品ID.Text = _m商品.ID.ToString();
                this.textBoxバーコード.Text = _m商品.バーコード;
                this.textBox商品名.Text = _m商品.商品名;

                if (_m商品.ID == -1)
                {
                    this.textBox商品名.ForeColor = Color.Red;
                }
                else
                {
                    this.textBox商品名.ForeColor = Color.Black;
                }
            }
        }

        private bool _ReadOnlyバーコード;

        public bool ReadOnlyバーコード
        {
            get { return _ReadOnlyバーコード; }
            set
            {
                _ReadOnlyバーコード = value;
                this.textBoxバーコード.ReadOnly = _ReadOnlyバーコード;
            }
        }

        public Uc商品入力()
        {
            InitializeComponent();
        }

        private void button検索商品_Click(object sender, EventArgs e)
        {
            uc商品検索.Visible = !uc商品検索.Visible;

            if (uc商品検索.Visible)
                uc商品検索.BringToFront();

            uc商品検索.バーコード = this.textBoxバーコード.Text;
        }

        // ------------------------------------------------------------
        // バーコードの直接入力
        // ------------------------------------------------------------
        private void textBoxバーコード_KeyPress(object sender, KeyPressEventArgs e)
        {
            //EnterやEscapeキーでビープ音が鳴らないようにする
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Escape)
            {
                e.Handled = true;
            }
        }

        private void textBoxバーコード_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Get商品();
            }
        }
        private void textBoxバーコード_Leave(object sender, EventArgs e)
        {
            Get商品();
        }

        private void Get商品()
        {
            var バーコード = this.textBoxバーコード.Text;
            if (string.IsNullOrWhiteSpace(バーコード))
            {
                this.M商品 = new M商品
                {
                    ID = -1,
                    バーコード = "",
                    商品名 = "",
                };
                return;
            }

            try
            {
                var vm商品 = new ViewModel商品();
                this.M商品 = vm商品.Get商品Byバーコード(バーコード);
            }
            catch
            {
                // 商品を発見できない
                this.M商品 = new M商品
                {
                    ID = -1,
                    バーコード = textBoxバーコード.Text,
                    商品名 = "※ 該当商品なし",
                };
            }

        }

        public void Get商品by商品名(string 商品名)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(商品名))
                {
                    this.M商品 = new M商品
                    {
                        ID = -1,
                        バーコード = "",
                        商品名 = "",
                    };
                    return;
                }

                var vm商品 = new ViewModel商品();
                this.M商品 = vm商品.Get商品By商品名(商品名);
            }
            catch
            {
                // 商品を発見できない
                this.M商品 = new M商品
                {
                    ID = -1,
                    バーコード = textBoxバーコード.Text,
                    商品名 = "※ 該当商品なし",
                };
            }
        }

    }
}
