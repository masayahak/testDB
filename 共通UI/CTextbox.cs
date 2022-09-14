using System;
using System.Drawing;
using System.Windows.Forms;

namespace テストDB.共通UI
{
    public partial class CTextBox : TextBox
    {
        public CTextBox()
        {
            InitializeComponent();
            this.ReadOnlyChanged += new EventHandler(OnReadOnlyChanged);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void OnReadOnlyChanged(object sender, EventArgs e)
        {
            if (this.ReadOnly)
            {
                this.BackColor = 処理モード.BackColors[処理モード.状態.照会中];
            }
            else
            {
                this.BackColor = Color.White;
            }

        }




    }
}
