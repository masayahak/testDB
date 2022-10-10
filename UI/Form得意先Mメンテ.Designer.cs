namespace テストDB.UI
{
    partial class Form得意先Mメンテ
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
            this.components = new System.ComponentModel.Container();
            テストDB.Models.M社員 m社員1 = new テストDB.Models.M社員();
            this.ucCRUD = new 共通UI.UcCRUD();
            this.ucロード中 = new 共通UI.Ucロード中();
            this.ucGridPager = new 共通UI.UcGridPager();
            this.panel詳細 = new System.Windows.Forms.Panel();
            this.uc社員検索 = new 共通UI.Uc社員検索();
            this.labelLineRight = new System.Windows.Forms.Label();
            this.labelLineBottom = new System.Windows.Forms.Label();
            this.labelLineLeft = new System.Windows.Forms.Label();
            this.labelLineTop = new System.Windows.Forms.Label();
            this.textBox得意先ID = new System.Windows.Forms.TextBox();
            this.uc社員入力 = new 共通UI.Uc社員入力();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox得意先名 = new 共通UI.CTextBox();
            this.textBox得意先CD = new 共通UI.CTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel詳細.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ucCRUD
            // 
            this.ucCRUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucCRUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(91)))), ((int)(((byte)(108)))));
            this.ucCRUD.Location = new System.Drawing.Point(715, 0);
            this.ucCRUD.Name = "ucCRUD";
            this.ucCRUD.Size = new System.Drawing.Size(127, 729);
            this.ucCRUD.TabIndex = 39;
            // 
            // ucロード中
            // 
            this.ucロード中.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucロード中.BackColor = System.Drawing.Color.Black;
            this.ucロード中.Location = new System.Drawing.Point(252, 302);
            this.ucロード中.Name = "ucロード中";
            this.ucロード中.Size = new System.Drawing.Size(340, 125);
            this.ucロード中.TabIndex = 40;
            // 
            // ucGridPager
            // 
            this.ucGridPager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucGridPager.Location = new System.Drawing.Point(0, 0);
            this.ucGridPager.Name = "ucGridPager";
            this.ucGridPager.RowsInPage = 10000;
            this.ucGridPager.Size = new System.Drawing.Size(715, 729);
            this.ucGridPager.TabIndex = 50;
            this.ucGridPager.SizeChanged += new System.EventHandler(this.ucGridPager_SizeChanged);
            // 
            // panel詳細
            // 
            this.panel詳細.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel詳細.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.panel詳細.Controls.Add(this.uc社員検索);
            this.panel詳細.Controls.Add(this.labelLineRight);
            this.panel詳細.Controls.Add(this.labelLineBottom);
            this.panel詳細.Controls.Add(this.labelLineLeft);
            this.panel詳細.Controls.Add(this.labelLineTop);
            this.panel詳細.Controls.Add(this.textBox得意先ID);
            this.panel詳細.Controls.Add(this.uc社員入力);
            this.panel詳細.Controls.Add(this.label3);
            this.panel詳細.Controls.Add(this.textBox得意先名);
            this.panel詳細.Controls.Add(this.textBox得意先CD);
            this.panel詳細.Controls.Add(this.label2);
            this.panel詳細.Controls.Add(this.label1);
            this.panel詳細.Location = new System.Drawing.Point(36, 55);
            this.panel詳細.Name = "panel詳細";
            this.panel詳細.Size = new System.Drawing.Size(656, 605);
            this.panel詳細.TabIndex = 51;
            // 
            // uc社員検索
            // 
            this.uc社員検索.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(91)))), ((int)(((byte)(108)))));
            this.uc社員検索.Location = new System.Drawing.Point(298, 121);
            this.uc社員検索.Name = "uc社員検索";
            this.uc社員検索.Size = new System.Drawing.Size(284, 262);
            this.uc社員検索.TabIndex = 55;
            this.uc社員検索.社員番号 = null;
            // 
            // labelLineRight
            // 
            this.labelLineRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLineRight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelLineRight.Location = new System.Drawing.Point(651, 0);
            this.labelLineRight.Name = "labelLineRight";
            this.labelLineRight.Size = new System.Drawing.Size(5, 605);
            this.labelLineRight.TabIndex = 61;
            // 
            // labelLineBottom
            // 
            this.labelLineBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLineBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelLineBottom.Location = new System.Drawing.Point(0, 600);
            this.labelLineBottom.Name = "labelLineBottom";
            this.labelLineBottom.Size = new System.Drawing.Size(656, 5);
            this.labelLineBottom.TabIndex = 60;
            // 
            // labelLineLeft
            // 
            this.labelLineLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLineLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelLineLeft.Location = new System.Drawing.Point(0, 0);
            this.labelLineLeft.Name = "labelLineLeft";
            this.labelLineLeft.Size = new System.Drawing.Size(5, 605);
            this.labelLineLeft.TabIndex = 59;
            // 
            // labelLineTop
            // 
            this.labelLineTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLineTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelLineTop.Location = new System.Drawing.Point(0, 0);
            this.labelLineTop.Name = "labelLineTop";
            this.labelLineTop.Size = new System.Drawing.Size(656, 5);
            this.labelLineTop.TabIndex = 58;
            // 
            // textBox得意先ID
            // 
            this.textBox得意先ID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox得意先ID.Location = new System.Drawing.Point(162, 213);
            this.textBox得意先ID.Name = "textBox得意先ID";
            this.textBox得意先ID.ReadOnly = true;
            this.textBox得意先ID.Size = new System.Drawing.Size(168, 31);
            this.textBox得意先ID.TabIndex = 57;
            this.textBox得意先ID.Visible = false;
            // 
            // uc社員入力
            // 
            this.uc社員入力.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.uc社員入力.Location = new System.Drawing.Point(162, 119);
            m社員1.ID = -1;
            m社員1.社員名 = "";
            m社員1.社員番号 = "";
            this.uc社員入力.M社員 = m社員1;
            this.uc社員入力.Name = "uc社員入力";
            this.uc社員入力.ReadOnly社員番号 = false;
            this.uc社員入力.Size = new System.Drawing.Size(258, 78);
            this.uc社員入力.TabIndex = 56;
            this.uc社員入力.uc社員検索 = this.uc社員検索;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(15, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 46;
            this.label3.Text = "担当社員";
            // 
            // textBox得意先名
            // 
            this.textBox得意先名.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox得意先名.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBox得意先名.Location = new System.Drawing.Point(162, 69);
            this.textBox得意先名.MaxLength = 256;
            this.textBox得意先名.Name = "textBox得意先名";
            this.textBox得意先名.ReadOnly = true;
            this.textBox得意先名.Size = new System.Drawing.Size(379, 31);
            this.textBox得意先名.TabIndex = 45;
            // 
            // textBox得意先CD
            // 
            this.textBox得意先CD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox得意先CD.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBox得意先CD.Location = new System.Drawing.Point(162, 24);
            this.textBox得意先CD.MaxLength = 20;
            this.textBox得意先CD.Name = "textBox得意先CD";
            this.textBox得意先CD.ReadOnly = true;
            this.textBox得意先CD.Size = new System.Drawing.Size(168, 31);
            this.textBox得意先CD.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "得意先名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "得意先コード";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form得意先Mメンテ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(845, 729);
            this.Controls.Add(this.ucCRUD);
            this.Controls.Add(this.panel詳細);
            this.Controls.Add(this.ucロード中);
            this.Controls.Add(this.ucGridPager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form得意先Mメンテ";
            this.Text = "Form得意先Mメンテ";
            this.Load += new System.EventHandler(this.Form得意先メンテ_Load);
            this.panel詳細.ResumeLayout(false);
            this.panel詳細.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private 共通UI.UcCRUD ucCRUD;
        private 共通UI.Ucロード中 ucロード中;
        private 共通UI.UcGridPager ucGridPager;
        private System.Windows.Forms.Panel panel詳細;
        private 共通UI.Uc社員検索 uc社員検索;
        private System.Windows.Forms.TextBox textBox得意先ID;
        private 共通UI.Uc社員入力 uc社員入力;
        private System.Windows.Forms.Label label3;
        private 共通UI.CTextBox textBox得意先名;
        private 共通UI.CTextBox textBox得意先CD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLineRight;
        private System.Windows.Forms.Label labelLineBottom;
        private System.Windows.Forms.Label labelLineLeft;
        private System.Windows.Forms.Label labelLineTop;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}