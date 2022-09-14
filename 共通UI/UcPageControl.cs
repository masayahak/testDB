using System;
using System.Windows.Forms;

namespace テストDB.共通UI
{
    public partial class UcPageControl : UserControl
    {

        // -------------------------------------------------------
        // 公開プロパティ
        // -------------------------------------------------------
        private int currentPage;
        public int CurrentPage 
        { 
            get { return currentPage; }
            set 
            { 
                currentPage = value;
                this.lblCurrentPage.Text = value.ToString();

                // ボタン制御
                SwitchButtonEnabled();
            }
        }
        public int RowsInPage;

        private int rowCount;
        public int RowCount 
        {
            get { return rowCount; }
            set { 
                rowCount = value;
                MaxPage = (int)Math.Ceiling((double)RowCount / RowsInPage);
                this.lblMaxPage.Text = MaxPage.ToString();
            }
        }
        public int MaxPage;

        // -------------------------------------------------------------
        // デリゲートイベントの定義
        // -------------------------------------------------------------
        // 親へイベントをデリゲートするためのイベントハンドラを定義
        public delegate void OnPageChangeEventHandler();
        public event OnPageChangeEventHandler OnPageChange;

        // -------------------------------------------------------------
        // 初期化とロード
        // -------------------------------------------------------------
        public UcPageControl()
        {
            InitializeComponent();
        }

        // -------------------------------------------------------------
        // イベントの発火
        // -------------------------------------------------------------
        private void btnFirst_Click(object sender, EventArgs e)
        {
            CurrentPage = 1;

            // イベントの発火
            OnPageChange();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CurrentPage--;

            // イベントの発火
            OnPageChange();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CurrentPage++;

            // イベントの発火
            OnPageChange();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            CurrentPage = MaxPage;

            // イベントの発火
            OnPageChange();
        }

        // -------------------------------------------------------------
        // ページボタンの制御
        // -------------------------------------------------------------
        private void SwitchButtonEnabled()
        {
            // ボタン制御
            this.btnFirst.Enabled = true;
            this.btnBack.Enabled = true;
            this.btnNext.Enabled = true;
            this.btnLast.Enabled = true;

            if (CurrentPage == 1)
            {
                this.btnFirst.Enabled = false;
                this.btnBack.Enabled = false;
            }

            if (CurrentPage == MaxPage)
            {
                this.btnNext.Enabled = false;
                this.btnLast.Enabled = false;
            }
        }

    }
}
