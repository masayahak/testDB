using System;
using System.Windows.Forms;

namespace テストDB.UI
{
    public partial class Uc処理モード : UserControl
    {

        // ---------------------------------------------------------
        // プロパティ
        //  公開しているのは状態のGETだけ
        // ---------------------------------------------------------
        private 処理モード.状態 _状態;
        public 処理モード.状態 状態
        {
            get { return _状態; }
            private set
            {
                if (_状態 != value)
                {
                    Set状態(value);
                }
                _状態 = value;
            }
        }

        // ---------------------------------------------------------
        // モードの変更処理
        // ---------------------------------------------------------
        private void Set状態(処理モード.状態 状態)
        {

            label作業中.Text = 処理モード.モード名[状態];

            switch (状態)
            {
                case 処理モード.状態.追加中:

                    モード_追加中();
                    break;

                case 処理モード.状態.修正中:

                    モード_修正中();
                    break;

                case 処理モード.状態.照会中:

                    モード_照会中();
                    break;
            }

        }

        private void モード_追加中()
        {
            label作業中.BackColor = 処理モード.BackColors[処理モード.状態.追加中];
            label作業中.ForeColor = 処理モード.ForeColors[処理モード.状態.追加中];

            button追加作業中.Enabled = false;
            button修正作業中.Enabled = false;

            this.ChangeMode追加();
        }

        private void モード_修正中()
        {
            label作業中.BackColor = 処理モード.BackColors[処理モード.状態.修正中];
            label作業中.ForeColor = 処理モード.ForeColors[処理モード.状態.修正中];

            button追加作業中.Enabled = false;
            button修正作業中.Enabled = false;

            this.ChangeMode修正();

        }

        private void モード_照会中()
        {
            label作業中.BackColor = 処理モード.BackColors[処理モード.状態.照会中];
            label作業中.ForeColor = 処理モード.ForeColors[処理モード.状態.照会中];

            button追加作業中.Enabled = true;
            button修正作業中.Enabled = true;

            this.ChangeMode照会();
        }
        // ---------------------------------------------------------
        // 初期化
        // ---------------------------------------------------------
        public Uc処理モード()
        {
            InitializeComponent();
            状態 = 処理モード.状態.初期化;
        }


        // 親へモード変更イベントをデリゲート
        public delegate void On処理モードChangeEventHandler();
        
        public event On処理モードChangeEventHandler ChangeMode追加;
        public event On処理モードChangeEventHandler ChangeMode修正;
        public event On処理モードChangeEventHandler ChangeMode照会;

        // ---------------------------------------------------------
        // モードの変更要求
        // ---------------------------------------------------------
        private void button追加作業中_Click(object sender, EventArgs e)
        {
            状態 = 処理モード.状態.追加中;
        }

        private void button修正作業中_Click(object sender, EventArgs e)
        {
            ChangeMode_修正();
        }


        // 修正モードへの変更
        public void ChangeMode_修正()
        {
            状態 = 処理モード.状態.修正中;
        }

        // 照会モードへの変更
        public void ChangeMode_照会()
        {
            状態 = 処理モード.状態.照会中;
        }


    }
}
