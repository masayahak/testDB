using System;
using System.Drawing;
using System.Windows.Forms;
using static テストDB.UI.Form売上分析;

namespace テストDB.UI
{
    public partial class Formメイン : Form
    {
        Form売上分析 form売上分析 = new Form売上分析();
        Form売上一覧 form売上一覧 = new Form売上一覧();
        Form売上明細一覧 form売上明細一覧 = new Form売上明細一覧();
        Form社員Mメンテ form社員Mメンテ = new Form社員Mメンテ();
        Form得意先Mメンテ form得意先Mメンテ = new Form得意先Mメンテ();
        Form商品Mメンテ form商品Mメンテ = new Form商品Mメンテ();

        // -----------------------------------------------------------
        // グラフで売上日をダブルクリック
        // -----------------------------------------------------------
        private void On売上日_Selected(On売上日SelectedEventArgs arg)
        {
            button売上日別_Click(this, null);

            form売上一覧.期間開始 = arg.売上日;
            form売上一覧.期間終了 = arg.売上日;
            form売上一覧.LoadDataWithParama();
        }

        // -----------------------------------------------------------
        // グラフで商品をダブルクリック
        // -----------------------------------------------------------
        private void On商品_Selected(On商品SelectedEventArgs arg)
        {
            button商品別_Click(this, null);

            form売上明細一覧.期間開始 = arg.期間開始;
            form売上明細一覧.期間終了 = arg.期間終了;
            form売上明細一覧.商品名 = arg.商品名;
            form売上明細一覧.LoadDataWithParama();
        }

        // -----------------------------------------------------------
        // グラフで得意先をダブルクリック
        // -----------------------------------------------------------
        private void On得意先_Selected(On得意先SelectedEventArgs arg)
        {
            button売上日別_Click(this, null);

            form売上一覧.期間開始 = arg.期間開始;
            form売上一覧.期間終了 = arg.期間終了;
            form売上一覧.得意先名 = arg.得意先名;
            form売上一覧.LoadDataWithParama();
        }

        // -----------------------------------------------------------
        // コンストラクタ
        // -----------------------------------------------------------
        public Formメイン()
        {
            InitializeComponent();

            form売上分析.On売上日Selected += On売上日_Selected;
            form売上分析.On商品Selected += On商品_Selected;
            form売上分析.On得意先Selected += On得意先_Selected;

            if (DesignMode) return;

            button売上総合_Click(this, null);
        }

        // -----------------------------------------------------------
        // 表示ボタン
        // -----------------------------------------------------------
        private void button売上総合_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(form売上分析);

            ClearAllButton();
            this.button売上総合.ForeColor = Color.WhiteSmoke;
        }

        private void button売上日別_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(form売上一覧);

            ClearAllButton();
            this.button売上日別.ForeColor = Color.WhiteSmoke;
        }

        private void button商品別_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(form売上明細一覧);

            ClearAllButton();
            this.button商品別.ForeColor = Color.WhiteSmoke;
        }

        private void button社員_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(form社員Mメンテ);

            ClearAllButton();
            this.button社員.ForeColor = Color.WhiteSmoke;
        }

        private void button得意先_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(form得意先Mメンテ);

            ClearAllButton();
            this.button得意先.ForeColor = Color.WhiteSmoke;
        }

        private void button商品_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(form商品Mメンテ);

            ClearAllButton();
            this.button商品.ForeColor = Color.WhiteSmoke;
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
        private void ClearAllButton()
        {
            this.button売上総合.ForeColor = Color.FromArgb(123, 137, 163);
            this.button売上日別.ForeColor = Color.FromArgb(123, 137, 163);
            this.button商品別.ForeColor = Color.FromArgb(123, 137, 163);
            this.button社員.ForeColor = Color.FromArgb(123, 137, 163);
            this.button得意先.ForeColor = Color.FromArgb(123, 137, 163);
        }

    }
}
