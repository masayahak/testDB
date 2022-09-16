﻿using System;
using System.Windows.Forms;

namespace テストDB.共通UI
{
    public partial class UcPageControl : UserControl
    {

        // -------------------------------------------------------
        // 公開プロパティ
        // -------------------------------------------------------
        private int currentCount;
        public int CurrentCount 
        { 
            get { return currentCount; }
            set 
            { 
                currentCount = value;

                int end;
                if (value + RowsInPage < rowCount)
                    end = value + RowsInPage - 1;
                else
                    end = rowCount;

                this.lblCurrentCount.Text = value.ToString() + "～" + end.ToString();

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
                this.lblMaxCount.Text = rowCount.ToString();
            }
        }

        // -------------------------------------------------------------
        // 対象のグリッドビュー
        // -------------------------------------------------------------
        public DgvPager dgvPager { get; set; }

        // -------------------------------------------------------------
        // デリゲートイベントの定義
        // -------------------------------------------------------------
        // 親へイベントをデリゲートするためのイベントハンドラを定義
        public delegate void OnPageChangeEventHandler(OnPageChangeEventArgs args);
        public event OnPageChangeEventHandler OnPageChange;

        // デリゲートの引数を定義
        public class OnPageChangeEventArgs : EventArgs
        {
            public int CurrentCount;
            public int RowsInPage;
        }

        // 親へイベントをデリゲートするためのイベントハンドラを定義
        public delegate void OnGridToExcelEventHandler();
        public event OnGridToExcelEventHandler OnGridToExcel;


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
            CurrentCount = 1;

            // イベントの発火
            var arg = new OnPageChangeEventArgs
            {
                CurrentCount = CurrentCount,
                RowsInPage = RowsInPage

            };
            OnPageChange(arg);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CurrentCount -= RowsInPage;

            // イベントの発火
            var arg = new OnPageChangeEventArgs
            {
                CurrentCount = CurrentCount,
                RowsInPage = RowsInPage

            };
            OnPageChange(arg);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CurrentCount += RowsInPage;

            // イベントの発火
            var arg = new OnPageChangeEventArgs
            {
                CurrentCount = CurrentCount,
                RowsInPage = RowsInPage

            };
            OnPageChange(arg);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            while (CurrentCount < rowCount)
            {
                CurrentCount += RowsInPage;
            }
            CurrentCount -= RowsInPage;

            // イベントの発火
            var arg = new OnPageChangeEventArgs
            {
                CurrentCount = CurrentCount,
                RowsInPage = RowsInPage

            };
            OnPageChange(arg);
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

            if (CurrentCount == 1)
            {
                this.btnFirst.Enabled = false;
                this.btnBack.Enabled = false;
            }

            if (CurrentCount + RowsInPage > rowCount)
            {
                this.btnNext.Enabled = false;
                this.btnLast.Enabled = false;
            }
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            // ボタンを連続でクリックできなくする
            this.buttonExcel.Enabled = false;

            OnGridToExcel();

            this.buttonExcel.Enabled = true;
        }
    }
}
