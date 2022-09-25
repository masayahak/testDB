using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace テストDB.共通UI
{
    public partial class UcCRUD : UserControl
    {
        // ---------------------------------------------------------
        // プロパティ
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

            lbl作業中.Text = 処理モード.モード名[状態];

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
            lbl作業中.BackColor = 処理モード.BackColors[処理モード.状態.追加中];
            lbl作業中.ForeColor = 処理モード.ForeColors[処理モード.状態.追加中];

            btn追加開始.Enabled = false;
            btn修正開始.Enabled = false;

            btn削除.Enabled = false;
            btn保存.Enabled = true;
            btnｷｬﾝｾﾙ.Enabled = true;

            ChangeMode追加();
        }

        private void モード_修正中()
        {
            lbl作業中.BackColor = 処理モード.BackColors[処理モード.状態.修正中];
            lbl作業中.ForeColor = 処理モード.ForeColors[処理モード.状態.修正中];

            btn追加開始.Enabled = false;
            btn修正開始.Enabled = false;

            btn削除.Enabled = true;
            btn保存.Enabled = true;
            btnｷｬﾝｾﾙ.Enabled = true;

            ChangeMode修正();
        }

        private void モード_照会中()
        {
            lbl作業中.BackColor = 処理モード.BackColors[処理モード.状態.照会中];
            lbl作業中.ForeColor = 処理モード.ForeColors[処理モード.状態.照会中];

            btn追加開始.Enabled = true;
            btn修正開始.Enabled = true;

            btn削除.Enabled = false;
            btn保存.Enabled = false;
            btnｷｬﾝｾﾙ.Enabled = false;

            ChangeMode照会();
        }

        // ---------------------------------------------------------
        // デリゲート
        // ---------------------------------------------------------
        // 親へモード変更イベントをデリゲート
        public delegate void On処理モードChangeEvent();

        public event On処理モードChangeEvent ChangeMode追加;
        public event On処理モードChangeEvent ChangeMode修正;
        public event On処理モードChangeEvent ChangeMode照会;

        // 親へイベントをデリゲート
        public delegate void OnCRUDEvent();

        public event OnCRUDEvent On削除Click;
        public event OnCRUDEvent On保存Click;
        public event OnCRUDEvent OnキャンセルClick;

        // ---------------------------------------------------------
        // 初期化
        // ---------------------------------------------------------
        public UcCRUD()
        {
            InitializeComponent();
        }

        // ---------------------------------------------------------
        // ユーザーイベント
        // ---------------------------------------------------------
        private void btn修正開始_Click(object sender, EventArgs e)
        {
            状態 = 処理モード.状態.修正中;
        }

        private void btn追加開始_Click(object sender, EventArgs e)
        {
            状態 = 処理モード.状態.追加中;
        }

        private void btn削除_Click(object sender, EventArgs e)
        {
            On削除Click();
        }

        private void btn保存_Click(object sender, EventArgs e)
        {
            On保存Click();
        }

        private void btnｷｬﾝｾﾙ_Click(object sender, EventArgs e)
        {
            OnキャンセルClick();
        }

        // ---------------------------------------------------------
        // モードの変更要求
        // ---------------------------------------------------------
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
