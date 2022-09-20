using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace テストDB.共通UI
{
    public partial class CDateTimePicker : DateTimePicker
    {

        Color EnabledBackColor = Color.White;
        Color DisabledBackColor = 処理モード.BackColors[処理モード.状態.照会中];

        // --------------------------------------------------------
        // コンストラクタ
        // --------------------------------------------------------
        public CDateTimePicker() : base()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        // --------------------------------------------------------
        // OnPaint
        // --------------------------------------------------------
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Rectangle dropDownRectangle = new Rectangle(ClientRectangle.Width - 17, 0, 17, 16);

            //When the control is enabled the brush is set to Backcolor, 
            //otherwise to color stored in _backDisabledColor
            Brush bkgBrush;
            ComboBoxState visualState;

            if (this.Enabled)
            {
                bkgBrush = new SolidBrush(EnabledBackColor);
                visualState = ComboBoxState.Normal;
            }
            else
            {
                bkgBrush = new SolidBrush(DisabledBackColor);
                visualState = ComboBoxState.Disabled;
            }

            //Filling the background
            g.FillRectangle(bkgBrush, 0, 0, ClientRectangle.Width, ClientRectangle.Height);

            //Drawing the datetime text
            g.DrawString(this.Text, this.Font, Brushes.Black, 0, 2);

            //Drawing the dropdownbutton using ComboBoxRenderer
            ComboBoxRenderer.DrawDropDownButton(g, dropDownRectangle, visualState);

            g.Dispose();
            bkgBrush.Dispose();
        }
    }
}
