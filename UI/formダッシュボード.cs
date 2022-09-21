using System;
using System.Drawing;
using System.Windows.Forms;
using static テストDB.UI.Uc売上分析;

namespace テストDB
{
    public partial class formダッシュボード : Form
    {
        enum 表示コントロール
        {
            売上分析,
            売上日別,
            売上商品別,
            社員マスタ,
            得意先マスタ
        }
        // -----------------------------------------------------------
        // グラフで売上日をダブルクリック
        // -----------------------------------------------------------
        private void On売上日_Selected(On売上日SelectedEventArgs arg)
        {
            button売上日別_Click(表示コントロール.売上日別, null);

            this.uc売上一覧.期間開始 = arg.売上日;
            this.uc売上一覧.期間終了 = arg.売上日;
            this.uc売上一覧.LoadDataWithParama();
        }

        // -----------------------------------------------------------
        // グラフで商品をダブルクリック
        // -----------------------------------------------------------
        private void On商品_Selected(On商品SelectedEventArgs arg)
        {
            button商品別_Click(表示コントロール.売上商品別, null);

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

            this.uc売上分析.On売上日Selected += On売上日_Selected;
            this.uc売上分析.On商品Selected += On商品_Selected;


            if (DesignMode) return;

            button売上総合_Click(this, null);
        }

        // -----------------------------------------------------------
        // 表示画面切り替えボタン
        // -----------------------------------------------------------
        private void button売上総合_Click(object sender, System.EventArgs e)
        {
            // 表示したいユーザーコントロールを表示してから、他の表示をOFFにする
            this.button売上総合.ForeColor = Color.WhiteSmoke;
            this.button売上総合.FlatAppearance.BorderColor = Color.WhiteSmoke;

            this.uc売上分析.Visible = true;

            ClearAllShow(表示コントロール.売上分析);
        }
        private void button売上日別_Click(object sender, System.EventArgs e)
        {

            // 表示したいユーザーコントロールを表示してから、他の表示をOFFにする
            this.button売上日別.ForeColor = Color.WhiteSmoke;
            this.button売上日別.FlatAppearance.BorderColor = Color.WhiteSmoke;

            this.uc売上一覧.Visible = true;

            ClearAllShow(表示コントロール.売上日別);

        }
        private void button商品別_Click(object sender, EventArgs e)
        {
            // 表示したいユーザーコントロールを表示してから、他の表示をOFFにする
            this.button商品別.ForeColor = Color.WhiteSmoke;
            this.button商品別.FlatAppearance.BorderColor = Color.WhiteSmoke;

            this.uc売上明細一覧.Visible = true;

            ClearAllShow(表示コントロール.売上商品別);
        }

        private void button社員_Click(object sender, System.EventArgs e)
        {
            // 表示したいユーザーコントロールを表示してから、他の表示をOFFにする
            this.button社員.ForeColor = Color.WhiteSmoke;
            this.button社員.FlatAppearance.BorderColor = Color.WhiteSmoke;

            this.uc社員メンテ.Visible = true;

            ClearAllShow(表示コントロール.社員マスタ);
        }

        private void button得意先_Click(object sender, System.EventArgs e)
        {
            // 表示したいユーザーコントロールを表示してから、他の表示をOFFにする
            this.button得意先.ForeColor = Color.WhiteSmoke;
            this.button得意先.FlatAppearance.BorderColor = Color.WhiteSmoke;

            this.uc得意先メンテ.Visible = true;

            ClearAllShow(表示コントロール.得意先マスタ);
        }

        // -----------------------------------------------------------
        // 表示切替OFF
        // -----------------------------------------------------------
        private void ClearAllShow(表示コントロール sender)
        {
            if (sender != 表示コントロール.売上分析)
            {
                this.button売上総合.ForeColor = Color.FromArgb(123, 137, 163);
                this.button売上総合.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

                this.uc売上分析.Visible = false;
            }

            if (sender != 表示コントロール.売上日別)
            {
                this.button売上日別.ForeColor = Color.FromArgb(123, 137, 163);
                this.button売上日別.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

                this.uc売上一覧.Visible = false;
            }

            if (sender != 表示コントロール.売上商品別)
            {
                this.button商品別.ForeColor = Color.FromArgb(123, 137, 163);
                this.button商品別.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

                this.uc売上明細一覧.Visible = false;
            }

            if (sender != 表示コントロール.社員マスタ)
            {
                this.button社員.ForeColor = Color.FromArgb(123, 137, 163);
                this.button社員.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

                this.uc社員メンテ.Visible = false;
            }

            if (sender != 表示コントロール.得意先マスタ)
            {
                this.button得意先.ForeColor = Color.FromArgb(123, 137, 163);
                this.button得意先.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);

                this.uc得意先メンテ.Visible = false;
            }
        }

    }
}
