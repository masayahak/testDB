using System;
using System.Windows.Forms;
using static テストDB.共通UI.Uc商品検索;
using static テストDB.共通UI.Uc得意先検索;

namespace テストDB.UI
{
    public partial class Uc売上明細一覧 : UserControl
    {
        private void Onバーコード_Selected(OnバーコードSelectedEventArgs e)
        {
            this.userControl商品入力.M商品 = e.m商品;
        }

        private void On得意先CD_Selected(On得意先CDSelectedEventArgs e)
        {
            this.userControl得意先入力.M得意先一覧 = e.m得意先一覧;
        }

        public Uc売上明細一覧()
        {
            InitializeComponent();

            // ユーザーコントロールで発火するイベントハンドラを追加
            this.userControl商品検索.OnバーコードSelected += Onバーコード_Selected;
            // ユーザーコントロールで発火するイベントハンドラを追加
            this.userControl得意先検索.On得意先CDSelected += On得意先CD_Selected;
        }

        private void UserControl売上日別売上一覧_Load(object sender, EventArgs e)
        {
            this.userControl商品入力.userControl商品検索 = this.userControl商品検索;
            this.userControl得意先入力.userControl得意先検索 = this.userControl得意先検索;

        }

        // ----------------------------------------------------------------
        // データ読み込み
        // ----------------------------------------------------------------

        public void LoadData()
        {

            //if (DesignMode) return;

            //this.dtp期間開始.Value = 期間開始;
            //this.dtp期間終了.Value = 期間終了;

            //vm売上 = new ViewModel売上();
            //vm売上.LoadData(dtp期間開始.Value, dtp期間終了.Value);


            //dataGridView売上日別売上一覧.DataSource = vm売上.listV売上明細;

            //// 列幅の設定:
            //dataGridView売上日別売上一覧.Columns[(int)V売上明細_Col.ID].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridView売上日別売上一覧.Columns[(int)V売上明細_Col.得意先CD].Visible = false;
            //dataGridView売上日別売上一覧.Columns[(int)V売上明細_Col.得意先名].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridView売上日別売上一覧.Columns[(int)V売上明細_Col.担当社員番号].Visible = false;
            //dataGridView売上日別売上一覧.Columns[(int)V売上明細_Col.担当社員名].Visible = false;
            //dataGridView売上日別売上一覧.Columns[(int)V売上明細_Col.売上日].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridView売上日別売上一覧.Columns[(int)V売上明細_Col.バーコード].Visible = false;
            //dataGridView売上日別売上一覧.Columns[(int)V売上明細_Col.商品名].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridView売上日別売上一覧.Columns[(int)V売上明細_Col.販売単価].Visible = false;
            //dataGridView売上日別売上一覧.Columns[(int)V売上明細_Col.販売数量].Visible = false;
            //dataGridView売上日別売上一覧.Columns[(int)V売上明細_Col.明細売上高].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //// 書式
            //dataGridView売上日別売上一覧.Columns[(int)V売上明細_Col.売上日].DefaultCellStyle.Format = "yyyy/MM/dd";
            //dataGridView売上日別売上一覧.Columns[(int)V売上明細_Col.明細売上高].DefaultCellStyle.Format = "C";


            //dataGridView売上日別売上一覧.Columns[(int)V売上明細_Col.ID].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dataGridView売上日別売上一覧.Columns[(int)V売上明細_Col.明細売上高].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //// ヘッダー
            //dataGridView売上日別売上一覧.Columns[(int)V売上明細_Col.ID].HeaderText = "伝票№";
        }

    }
}
