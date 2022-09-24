namespace テストDB.UI
{
    partial class Form得意先メンテ
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
            テストDB.Models.M社員 m社員1 = new テストDB.Models.M社員();
            this.textBox得意先ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel詳細 = new System.Windows.Forms.Panel();
            this.uc社員検索 = new テストDB.共通UI.Uc社員検索();
            this.uc社員入力 = new テストDB.共通UI.Uc社員入力();
            this.textBox得意先名 = new テストDB.共通UI.CTextBox();
            this.textBox得意先CD = new テストDB.共通UI.CTextBox();
            this.panel操作 = new System.Windows.Forms.Panel();
            this.buttonｷｬﾝｾﾙ = new テストDB.共通UI.CButton();
            this.button保存 = new テストDB.共通UI.CButton();
            this.button削除 = new テストDB.共通UI.CButton();
            this.userControl処理モード = new テストDB.UI.Uc処理モード();
            this.ucロード中 = new テストDB.共通UI.Ucロード中();
            this.ucPager = new テストDB.共通UI.UcPager();
            this.panel詳細.SuspendLayout();
            this.panel操作.SuspendLayout();
            this.SuspendLayout();
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
            // panel詳細
            // 
            this.panel詳細.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel詳細.Controls.Add(this.uc社員検索);
            this.panel詳細.Controls.Add(this.textBox得意先ID);
            this.panel詳細.Controls.Add(this.uc社員入力);
            this.panel詳細.Controls.Add(this.label3);
            this.panel詳細.Controls.Add(this.textBox得意先名);
            this.panel詳細.Controls.Add(this.textBox得意先CD);
            this.panel詳細.Controls.Add(this.label2);
            this.panel詳細.Controls.Add(this.label1);
            this.panel詳細.Location = new System.Drawing.Point(0, 0);
            this.panel詳細.Name = "panel詳細";
            this.panel詳細.Size = new System.Drawing.Size(702, 690);
            this.panel詳細.TabIndex = 48;
            // 
            // uc社員検索
            // 
            this.uc社員検索.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uc社員検索.Location = new System.Drawing.Point(300, 123);
            this.uc社員検索.Name = "uc社員検索";
            this.uc社員検索.Size = new System.Drawing.Size(284, 262);
            this.uc社員検索.TabIndex = 55;
            this.uc社員検索.社員番号 = null;
            // 
            // uc社員入力
            // 
            this.uc社員入力.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
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
            // textBox得意先名
            // 
            this.textBox得意先名.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox得意先名.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBox得意先名.Location = new System.Drawing.Point(162, 69);
            this.textBox得意先名.MaxLength = 256;
            this.textBox得意先名.Name = "textBox得意先名";
            this.textBox得意先名.ReadOnly = true;
            this.textBox得意先名.Size = new System.Drawing.Size(251, 31);
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
            // panel操作
            // 
            this.panel操作.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel操作.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.panel操作.Controls.Add(this.buttonｷｬﾝｾﾙ);
            this.panel操作.Controls.Add(this.button保存);
            this.panel操作.Controls.Add(this.button削除);
            this.panel操作.Controls.Add(this.userControl処理モード);
            this.panel操作.Location = new System.Drawing.Point(702, 0);
            this.panel操作.Name = "panel操作";
            this.panel操作.Size = new System.Drawing.Size(127, 690);
            this.panel操作.TabIndex = 47;
            // 
            // buttonｷｬﾝｾﾙ
            // 
            this.buttonｷｬﾝｾﾙ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonｷｬﾝｾﾙ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.buttonｷｬﾝｾﾙ.BackColorSaved = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.buttonｷｬﾝｾﾙ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonｷｬﾝｾﾙ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.buttonｷｬﾝｾﾙ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonｷｬﾝｾﾙ.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonｷｬﾝｾﾙ.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonｷｬﾝｾﾙ.Location = new System.Drawing.Point(3, 634);
            this.buttonｷｬﾝｾﾙ.Name = "buttonｷｬﾝｾﾙ";
            this.buttonｷｬﾝｾﾙ.Size = new System.Drawing.Size(121, 35);
            this.buttonｷｬﾝｾﾙ.TabIndex = 20;
            this.buttonｷｬﾝｾﾙ.Text = "ｷｬﾝｾﾙ";
            this.buttonｷｬﾝｾﾙ.UseVisualStyleBackColor = false;
            this.buttonｷｬﾝｾﾙ.Click += new System.EventHandler(this.buttonｷｬﾝｾﾙ_Click);
            // 
            // button保存
            // 
            this.button保存.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button保存.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.button保存.BackColorSaved = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.button保存.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button保存.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.button保存.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button保存.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button保存.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button保存.Location = new System.Drawing.Point(3, 539);
            this.button保存.Name = "button保存";
            this.button保存.Size = new System.Drawing.Size(121, 35);
            this.button保存.TabIndex = 19;
            this.button保存.Text = "保存";
            this.button保存.UseVisualStyleBackColor = false;
            this.button保存.Click += new System.EventHandler(this.button保存_Click);
            // 
            // button削除
            // 
            this.button削除.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button削除.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(122)))), ((int)(((byte)(133)))));
            this.button削除.BackColorSaved = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(122)))), ((int)(((byte)(133)))));
            this.button削除.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button削除.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.button削除.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button削除.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button削除.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button削除.Location = new System.Drawing.Point(3, 246);
            this.button削除.Name = "button削除";
            this.button削除.Size = new System.Drawing.Size(121, 35);
            this.button削除.TabIndex = 18;
            this.button削除.Text = "削除";
            this.button削除.UseVisualStyleBackColor = false;
            this.button削除.Click += new System.EventHandler(this.button削除_Click);
            // 
            // userControl処理モード
            // 
            this.userControl処理モード.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userControl処理モード.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.userControl処理モード.Location = new System.Drawing.Point(3, 3);
            this.userControl処理モード.Name = "userControl処理モード";
            this.userControl処理モード.Size = new System.Drawing.Size(123, 137);
            this.userControl処理モード.TabIndex = 17;
            // 
            // ucロード中
            // 
            this.ucロード中.BackColor = System.Drawing.Color.Black;
            this.ucロード中.Location = new System.Drawing.Point(204, 267);
            this.ucロード中.Name = "ucロード中";
            this.ucロード中.Size = new System.Drawing.Size(340, 125);
            this.ucロード中.TabIndex = 37;
            // 
            // ucPager
            // 
            this.ucPager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucPager.KeyColumn = 1;
            this.ucPager.Location = new System.Drawing.Point(0, 0);
            this.ucPager.Name = "ucPager";
            this.ucPager.RowCount = 0;
            this.ucPager.RowsInPage = 100;
            this.ucPager.Size = new System.Drawing.Size(702, 690);
            this.ucPager.TabIndex = 49;
            this.ucPager.SizeChanged += new System.EventHandler(this.ucPager_SizeChanged);
            // 
            // Form得意先メンテ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(829, 690);
            this.Controls.Add(this.ucロード中);
            this.Controls.Add(this.panel操作);
            this.Controls.Add(this.ucPager);
            this.Controls.Add(this.panel詳細);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form得意先メンテ";
            this.Text = "Form得意先メンテ";
            this.Load += new System.EventHandler(this.Form得意先メンテ_Load);
            this.panel詳細.ResumeLayout(false);
            this.panel詳細.PerformLayout();
            this.panel操作.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private 共通UI.Uc社員検索 uc社員検索;
        private System.Windows.Forms.TextBox textBox得意先ID;
        private 共通UI.Uc社員入力 uc社員入力;
        private 共通UI.CButton button削除;
        private Uc処理モード userControl処理モード;
        private System.Windows.Forms.Label label3;
        private 共通UI.CTextBox textBox得意先名;
        private 共通UI.CTextBox textBox得意先CD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private 共通UI.CButton buttonｷｬﾝｾﾙ;
        private 共通UI.CButton button保存;
        private System.Windows.Forms.Panel panel詳細;
        private System.Windows.Forms.Panel panel操作;
        private 共通UI.Ucロード中 ucロード中;
        private 共通UI.UcPager ucPager;
    }
}