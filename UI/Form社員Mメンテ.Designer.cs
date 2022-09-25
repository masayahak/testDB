namespace テストDB.UI
{
    partial class Form社員Mメンテ
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucロード中 = new テストDB.共通UI.Ucロード中();
            this.panel詳細 = new System.Windows.Forms.Panel();
            this.textBox社員名 = new テストDB.共通UI.CTextBox();
            this.textBox社員番号 = new テストDB.共通UI.CTextBox();
            this.textBox社員ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucPager = new テストDB.共通UI.UcBasePager();
            this.ucCRUD = new テストDB.共通UI.UcCRUD();
            this.panel詳細.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucロード中
            // 
            this.ucロード中.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucロード中.BackColor = System.Drawing.Color.Black;
            this.ucロード中.Location = new System.Drawing.Point(252, 302);
            this.ucロード中.Name = "ucロード中";
            this.ucロード中.Size = new System.Drawing.Size(340, 125);
            this.ucロード中.TabIndex = 35;
            // 
            // panel詳細
            // 
            this.panel詳細.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel詳細.Controls.Add(this.textBox社員名);
            this.panel詳細.Controls.Add(this.textBox社員番号);
            this.panel詳細.Controls.Add(this.textBox社員ID);
            this.panel詳細.Controls.Add(this.label2);
            this.panel詳細.Controls.Add(this.label1);
            this.panel詳細.Location = new System.Drawing.Point(0, 0);
            this.panel詳細.Name = "panel詳細";
            this.panel詳細.Size = new System.Drawing.Size(715, 729);
            this.panel詳細.TabIndex = 36;
            // 
            // textBox社員名
            // 
            this.textBox社員名.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox社員名.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBox社員名.Location = new System.Drawing.Point(120, 61);
            this.textBox社員名.MaxLength = 256;
            this.textBox社員名.Name = "textBox社員名";
            this.textBox社員名.ReadOnly = true;
            this.textBox社員名.Size = new System.Drawing.Size(251, 31);
            this.textBox社員名.TabIndex = 33;
            // 
            // textBox社員番号
            // 
            this.textBox社員番号.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox社員番号.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBox社員番号.Location = new System.Drawing.Point(120, 16);
            this.textBox社員番号.MaxLength = 20;
            this.textBox社員番号.Name = "textBox社員番号";
            this.textBox社員番号.ReadOnly = true;
            this.textBox社員番号.Size = new System.Drawing.Size(168, 31);
            this.textBox社員番号.TabIndex = 32;
            // 
            // textBox社員ID
            // 
            this.textBox社員ID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox社員ID.Location = new System.Drawing.Point(120, 109);
            this.textBox社員ID.Name = "textBox社員ID";
            this.textBox社員ID.ReadOnly = true;
            this.textBox社員ID.Size = new System.Drawing.Size(168, 31);
            this.textBox社員ID.TabIndex = 31;
            this.textBox社員ID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(8, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "社員名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "社員番号";
            // 
            // ucPager
            // 
            this.ucPager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucPager.Location = new System.Drawing.Point(0, 0);
            this.ucPager.Name = "ucPager";
            this.ucPager.RowCount = 0;
            this.ucPager.RowsInPage = 100;
            this.ucPager.Size = new System.Drawing.Size(715, 729);
            this.ucPager.TabIndex = 37;
            this.ucPager.SizeChanged += new System.EventHandler(this.ucPager_SizeChanged);
            // 
            // ucCRUD
            // 
            this.ucCRUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucCRUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.ucCRUD.Location = new System.Drawing.Point(715, 0);
            this.ucCRUD.Name = "ucCRUD";
            this.ucCRUD.Size = new System.Drawing.Size(127, 729);
            this.ucCRUD.TabIndex = 38;
            // 
            // Form社員Mメンテ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(845, 729);
            this.Controls.Add(this.ucCRUD);
            this.Controls.Add(this.ucロード中);
            this.Controls.Add(this.ucPager);
            this.Controls.Add(this.panel詳細);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form社員Mメンテ";
            this.Text = "Form社員Mメンテ";
            this.Load += new System.EventHandler(this.Form社員メンテ_Load);
            this.panel詳細.ResumeLayout(false);
            this.panel詳細.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private 共通UI.Ucロード中 ucロード中;
        private System.Windows.Forms.Panel panel詳細;
        private 共通UI.CTextBox textBox社員名;
        private 共通UI.CTextBox textBox社員番号;
        private System.Windows.Forms.TextBox textBox社員ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private 共通UI.UcBasePager ucPager;
        private 共通UI.UcCRUD ucCRUD;
    }
}