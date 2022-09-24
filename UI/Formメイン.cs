using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static テストDB.UI.Form売上分析;

namespace テストDB.UI
{
    public partial class Formメイン : Form
    {
        Form売上分析 form売上分析 = new Form売上分析();
        Form売上一覧 form売上一覧 = new Form売上一覧();
        Form売上明細一覧 form売上明細一覧 = new Form売上明細一覧();
        Form社員メンテ form社員メンテ = new Form社員メンテ();
        Form得意先メンテ form得意先メンテ = new Form得意先メンテ();

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

            form売上一覧.期間開始 = arg.売上日;
            form売上一覧.期間終了 = arg.売上日;
            form売上一覧.LoadDataWithParama();
        }

        // -----------------------------------------------------------
        // グラフで商品をダブルクリック
        // -----------------------------------------------------------
        private void On商品_Selected(On商品SelectedEventArgs arg)
        {
            button商品別_Click(表示コントロール.売上商品別, null);

            form売上明細一覧.期間開始 = arg.期間開始;
            form売上明細一覧.期間終了 = arg.期間終了;
            form売上明細一覧.商品名 = arg.商品名;
            form売上明細一覧.LoadDataWithParama();
        }

        // -----------------------------------------------------------
        // コンストラクタ
        // -----------------------------------------------------------
        public Formメイン()
        {
            InitializeComponent();

            form売上分析.On売上日Selected += On売上日_Selected;
            form売上分析.On商品Selected += On商品_Selected;

            if (DesignMode) return;

            button売上総合_Click(this, null);
        }

        // -----------------------------------------------------------
        // 表示ボタン
        // -----------------------------------------------------------
        private void button売上総合_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(form売上分析);

            this.button売上総合.ForeColor = Color.WhiteSmoke;
            this.button売上総合.FlatAppearance.BorderColor = Color.WhiteSmoke;
            ClearAllShow(表示コントロール.売上分析);
        }

        private void button売上日別_Click(object sender, EventArgs e)
        {
            form売上一覧 = new Form売上一覧();
            ShowFormInPanel(form売上一覧);

            this.button売上日別.ForeColor = Color.WhiteSmoke;
            this.button売上日別.FlatAppearance.BorderColor = Color.WhiteSmoke;

            ClearAllShow(表示コントロール.売上日別);
        }

        private void button商品別_Click(object sender, EventArgs e)
        {
            form売上明細一覧 = new Form売上明細一覧();
            ShowFormInPanel(form売上明細一覧);

            this.button商品別.ForeColor = Color.WhiteSmoke;
            this.button商品別.FlatAppearance.BorderColor = Color.WhiteSmoke;

            ClearAllShow(表示コントロール.売上商品別);
        }

        private void button社員_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(form社員メンテ);

            this.button社員.ForeColor = Color.WhiteSmoke;
            this.button社員.FlatAppearance.BorderColor = Color.WhiteSmoke;

            ClearAllShow(表示コントロール.社員マスタ);
        }

        private void button得意先_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(form得意先メンテ);

            this.button得意先.ForeColor = Color.WhiteSmoke;
            this.button得意先.FlatAppearance.BorderColor = Color.WhiteSmoke;

            ClearAllShow(表示コントロール.得意先マスタ);
        }

        // パネルへロード
        private void ShowFormInPanel(Form showForm)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);

            showForm.TopLevel = false;
            showForm.FormBorderStyle = FormBorderStyle.None;
            showForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(showForm);
            this.panelMain.Tag = showForm;
            showForm.Show();
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
            }

            if (sender != 表示コントロール.売上日別)
            {
                this.button売上日別.ForeColor = Color.FromArgb(123, 137, 163);
                this.button売上日別.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);
            }

            if (sender != 表示コントロール.売上商品別)
            {
                this.button商品別.ForeColor = Color.FromArgb(123, 137, 163);
                this.button商品別.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);
            }

            if (sender != 表示コントロール.社員マスタ)
            {
                this.button社員.ForeColor = Color.FromArgb(123, 137, 163);
                this.button社員.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);
            }

            if (sender != 表示コントロール.得意先マスタ)
            {
                this.button得意先.ForeColor = Color.FromArgb(123, 137, 163);
                this.button得意先.FlatAppearance.BorderColor = Color.FromArgb(123, 137, 163);
            }
        }

    }
}
