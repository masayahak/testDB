using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using テストDB.ViewModel;
using static テストDB.UI.Uc売上分析;

namespace テストDB
{
    public partial class formダッシュボード : Form
    {

        // -----------------------------------------------------------
        // グラフで売上日をダブルクリック
        // -----------------------------------------------------------
        private void On売上日_Selected(On売上日SelectedEventArgs arg)
        {
            // todo このロードの仕方もださい
            button売上日別_Click(this, null);

            this.uc売上一覧.期間開始 = arg.売上日;
            this.uc売上一覧.期間終了 = arg.売上日;
            this.uc売上一覧.LoadDataWithParama();
        }

        // -----------------------------------------------------------
        // グラフで商品をダブルクリック
        // -----------------------------------------------------------
        private void On商品_Selected(On商品SelectedEventArgs arg)
        {
            // todo このロードの仕方もださい
            button商品別_Click(this, null);

            this.uc売上明細一覧.期間開始 = arg.期間開始;
            this.uc売上明細一覧.期間終了 = arg.期間終了;
            this.uc売上明細一覧.商品名 = arg.商品名;
            this.uc売上明細一覧.LoadDataWithParama();
        }

        // -----------------------------------------------------------
        // コンストラクタ
        // -----------------------------------------------------------
        public formダッシュボード()
        {
            InitializeComponent();

            this.userControl売上総合.On売上日Selected += On売上日_Selected;
            this.userControl売上総合.On商品Selected += On商品_Selected;


            if (DesignMode) return;

            button売上総合_Click(this, null);
        }

        private void button売上総合_Click(object sender, System.EventArgs e)
        {
            // todo コントロールの制御が汚い

            this.button売上総合.ForeColor = Color.WhiteSmoke;
            this.button売上総合.FlatAppearance.BorderColor = Color.WhiteSmoke;

            this.button売上日別.ForeColor = Color.FromArgb(123, 137, 163);
            this.button売上日別.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

            this.button商品別.ForeColor = Color.FromArgb(123, 137, 163);
            this.button商品別.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

            this.button社員.ForeColor = Color.FromArgb(123, 137, 163);
            this.button社員.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

            this.button得意先.ForeColor = Color.FromArgb(123, 137, 163);
            this.button得意先.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

            // 表示したいユーザーコントロールを表示してから、他の表示をOFFにする
            this.userControl売上総合.Visible = true;
            this.uc売上一覧.Visible = false;
            this.uc売上明細一覧.Visible = false;
            this.userControl社員メンテ.Visible = false;
            this.userControl得意先メンテ.Visible = false;

        }
        private void button売上日別_Click(object sender, System.EventArgs e)
        {

            this.button売上日別.ForeColor = Color.WhiteSmoke;
            this.button売上日別.FlatAppearance.BorderColor = Color.WhiteSmoke;

            this.button得意先.ForeColor = Color.FromArgb(123, 137, 163);
            this.button得意先.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

            this.button売上総合.ForeColor = Color.FromArgb(123, 137, 163);
            this.button売上総合.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

            this.button商品別.ForeColor = Color.FromArgb(123, 137, 163);
            this.button商品別.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

            this.button社員.ForeColor = Color.FromArgb(123, 137, 163);
            this.button社員.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

            // 表示したいユーザーコントロールを表示してから、他の表示をOFFにする
            this.uc売上一覧.Visible = true;
            this.userControl得意先メンテ.Visible = false;
            this.userControl売上総合.Visible = false;
            this.uc売上明細一覧.Visible = false;
            this.userControl社員メンテ.Visible = false;

        }
        private void button社員_Click(object sender, System.EventArgs e)
        {
            this.button社員.ForeColor = Color.WhiteSmoke;
            this.button社員.FlatAppearance.BorderColor = Color.WhiteSmoke;

            this.button売上総合.ForeColor = Color.FromArgb(123, 137, 163);
            this.button売上総合.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

            this.button売上日別.ForeColor = Color.FromArgb(123, 137, 163);
            this.button売上日別.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

            this.button商品別.ForeColor = Color.FromArgb(123, 137, 163);
            this.button商品別.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

            this.button得意先.ForeColor = Color.FromArgb(123, 137, 163);
            this.button得意先.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

            // 表示したいユーザーコントロールを表示してから、他の表示をOFFにする
            this.userControl社員メンテ.Visible = true;
            this.userControl売上総合.Visible = false;
            this.uc売上一覧.Visible = false;
            this.uc売上明細一覧.Visible = false;
            this.userControl得意先メンテ.Visible = false;
        }

        private void button得意先_Click(object sender, System.EventArgs e)
        {
            this.button得意先.ForeColor = Color.WhiteSmoke;
            this.button得意先.FlatAppearance.BorderColor = Color.WhiteSmoke;

            this.button売上総合.ForeColor = Color.FromArgb(123, 137, 163);
            this.button売上総合.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

            this.button売上日別.ForeColor = Color.FromArgb(123, 137, 163);
            this.button売上日別.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

            this.button商品別.ForeColor = Color.FromArgb(123, 137, 163);
            this.button商品別.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

            this.button社員.ForeColor = Color.FromArgb(123, 137, 163);
            this.button社員.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

            // 表示したいユーザーコントロールを表示してから、他の表示をOFFにする
            this.userControl得意先メンテ.Visible = true;
            this.userControl売上総合.Visible = false;
            this.uc売上一覧.Visible = false;
            this.uc売上明細一覧.Visible = false;
            this.userControl社員メンテ.Visible = false;

        }

        private void button商品別_Click(object sender, EventArgs e)
        {
            this.button商品別.ForeColor = Color.WhiteSmoke;
            this.button商品別.FlatAppearance.BorderColor = Color.WhiteSmoke;

            this.button売上総合.ForeColor = Color.FromArgb(123, 137, 163);
            this.button売上総合.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

            this.button売上日別.ForeColor = Color.FromArgb(123, 137, 163);
            this.button売上日別.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

            this.button社員.ForeColor = Color.FromArgb(123, 137, 163);
            this.button社員.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

            this.button得意先.ForeColor = Color.FromArgb(123, 137, 163);
            this.button得意先.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);


            // 表示したいユーザーコントロールを表示してから、他の表示をOFFにする
            this.uc売上明細一覧.Visible = true;
            this.userControl得意先メンテ.Visible = false;
            this.userControl売上総合.Visible = false;
            this.uc売上一覧.Visible = false;
            this.userControl社員メンテ.Visible = false;
        }
    }
}
