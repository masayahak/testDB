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

        private void On売上日_Selected(On売上日SelectedEventArgs arg)
        {
            // todo このロードの仕方もださい
            button売上日別_Click(this, null);

            this.userControl売上日別売上一覧.期間開始 = arg.売上日;
            this.userControl売上日別売上一覧.期間終了 = arg.売上日;
            this.userControl売上日別売上一覧.LoadDataWithParama();
        }

        public formダッシュボード()
        {
            InitializeComponent();

            this.userControl売上総合.On売上日Selected += On売上日_Selected;


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

            this.button社員.ForeColor = Color.FromArgb(123, 137, 163);
            this.button社員.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

            this.button得意先.ForeColor = Color.FromArgb(123, 137, 163);
            this.button得意先.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

            // 表示したいユーザーコントロールを表示してから、他の表示をOFFにする
            this.userControl売上総合.Visible = true;
            this.userControl売上日別売上一覧.Visible = false;
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

            this.button社員.ForeColor = Color.FromArgb(123, 137, 163);
            this.button社員.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

            // 表示したいユーザーコントロールを表示してから、他の表示をOFFにする
            this.userControl売上日別売上一覧.Visible = true;
            this.userControl得意先メンテ.Visible = false;
            this.userControl売上総合.Visible = false;
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

            this.button得意先.ForeColor = Color.FromArgb(123, 137, 163);
            this.button得意先.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

            // 表示したいユーザーコントロールを表示してから、他の表示をOFFにする
            this.userControl社員メンテ.Visible = true;
            this.userControl売上総合.Visible = false;
            this.userControl売上日別売上一覧.Visible = false;
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

            this.button社員.ForeColor = Color.FromArgb(123, 137, 163);
            this.button社員.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

            // 表示したいユーザーコントロールを表示してから、他の表示をOFFにする
            this.userControl得意先メンテ.Visible = true;
            this.userControl売上総合.Visible = false;
            this.userControl売上日別売上一覧.Visible = false;
            this.userControl社員メンテ.Visible = false;

        }

    }
}
