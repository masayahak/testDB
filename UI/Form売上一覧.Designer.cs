namespace テストDB.UI
{
    partial class Form売上一覧
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
            テストDB.Models.M得意先J担当者 m得意先J担当者1 = new テストDB.Models.M得意先J担当者();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucロード中 = new 共通UI.Ucロード中();
            this.cButton検索 = new 共通UI.CButton();
            this.uc得意先検索 = new 共通UI.Uc得意先検索();
            this.uc社員検索 = new 共通UI.Uc社員検索();
            this.uc社員入力 = new 共通UI.Uc社員入力();
            this.uc得意先入力 = new 共通UI.Uc得意先入力();
            this.dtp期間終了 = new 共通UI.CDateTimePicker();
            this.dtp期間開始 = new 共通UI.CDateTimePicker();
            this.ucGridPager = new 共通UI.UcGridPager();
            this.uc売上伝票 = new テストDB.UI.Uc売上伝票();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(13, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 77;
            this.label2.Text = "担当社員";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(13, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 74;
            this.label3.Text = "得意先";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 72;
            this.label1.Text = "売上日";
            // 
            // ucロード中
            // 
            this.ucロード中.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucロード中.BackColor = System.Drawing.Color.Black;
            this.ucロード中.Location = new System.Drawing.Point(245, 300);
            this.ucロード中.Name = "ucロード中";
            this.ucロード中.Size = new System.Drawing.Size(340, 125);
            this.ucロード中.TabIndex = 81;
            this.ucロード中.Visible = false;
            // 
            // cButton検索
            // 
            this.cButton検索.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cButton検索.BackColorSaved = System.Drawing.Color.Empty;
            this.cButton検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton検索.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.cButton検索.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cButton検索.Location = new System.Drawing.Point(729, 174);
            this.cButton検索.Name = "cButton検索";
            this.cButton検索.Size = new System.Drawing.Size(101, 44);
            this.cButton検索.TabIndex = 79;
            this.cButton検索.Text = "検索";
            this.cButton検索.UseVisualStyleBackColor = false;
            this.cButton検索.Click += new System.EventHandler(this.cButton検索_Click);
            // 
            // uc得意先検索
            // 
            this.uc得意先検索.Location = new System.Drawing.Point(403, 49);
            this.uc得意先検索.Name = "uc得意先検索";
            this.uc得意先検索.Size = new System.Drawing.Size(374, 331);
            this.uc得意先検索.TabIndex = 75;
            this.uc得意先検索.Visible = false;
            this.uc得意先検索.得意先CD = null;
            // 
            // uc社員検索
            // 
            this.uc社員検索.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uc社員検索.Location = new System.Drawing.Point(360, 140);
            this.uc社員検索.Name = "uc社員検索";
            this.uc社員検索.Size = new System.Drawing.Size(284, 262);
            this.uc社員検索.TabIndex = 78;
            this.uc社員検索.Visible = false;
            this.uc社員検索.社員番号 = null;
            // 
            // uc社員入力
            // 
            this.uc社員入力.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(91)))), ((int)(((byte)(108)))));
            this.uc社員入力.Location = new System.Drawing.Point(186, 140);
            m社員1.ID = -1;
            m社員1.社員名 = "";
            m社員1.社員番号 = "";
            this.uc社員入力.M社員 = m社員1;
            this.uc社員入力.Name = "uc社員入力";
            this.uc社員入力.ReadOnly社員番号 = false;
            this.uc社員入力.Size = new System.Drawing.Size(258, 78);
            this.uc社員入力.TabIndex = 76;
            this.uc社員入力.uc社員検索 = null;
            // 
            // uc得意先入力
            // 
            this.uc得意先入力.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(91)))), ((int)(((byte)(108)))));
            this.uc得意先入力.Location = new System.Drawing.Point(188, 49);
            m得意先J担当者1.ID = -1;
            m得意先J担当者1.得意先CD = "";
            m得意先J担当者1.得意先名 = "";
            m得意先J担当者1.担当社員ID = 0;
            m得意先J担当者1.担当社員名 = null;
            m得意先J担当者1.担当社員番号 = null;
            this.uc得意先入力.M得意先J担当者 = m得意先J担当者1;
            this.uc得意先入力.Name = "uc得意先入力";
            this.uc得意先入力.ReadOnly得意先CD = false;
            this.uc得意先入力.Size = new System.Drawing.Size(294, 78);
            this.uc得意先入力.TabIndex = 73;
            this.uc得意先入力.uc得意先検索 = null;
            // 
            // dtp期間終了
            // 
            this.dtp期間終了.CustomFormat = "yyyy/MM/dd";
            this.dtp期間終了.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp期間終了.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp期間終了.Location = new System.Drawing.Point(347, 13);
            this.dtp期間終了.Name = "dtp期間終了";
            this.dtp期間終了.Size = new System.Drawing.Size(142, 31);
            this.dtp期間終了.TabIndex = 71;
            // 
            // dtp期間開始
            // 
            this.dtp期間開始.CustomFormat = "yyyy/MM/dd";
            this.dtp期間開始.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp期間開始.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp期間開始.Location = new System.Drawing.Point(189, 13);
            this.dtp期間開始.Name = "dtp期間開始";
            this.dtp期間開始.Size = new System.Drawing.Size(142, 31);
            this.dtp期間開始.TabIndex = 70;
            // 
            // ucGridPager
            // 
            this.ucGridPager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucGridPager.Location = new System.Drawing.Point(0, 232);
            this.ucGridPager.Name = "ucGridPager";
            this.ucGridPager.RowsInPage = 10000;
            this.ucGridPager.Size = new System.Drawing.Size(845, 497);
            this.ucGridPager.TabIndex = 69;
            this.ucGridPager.SizeChanged += new System.EventHandler(this.ucGridPager_SizeChanged);
            // 
            // uc売上伝票
            // 
            this.uc売上伝票.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(91)))), ((int)(((byte)(108)))));
            this.uc売上伝票.Location = new System.Drawing.Point(-33, 312);
            this.uc売上伝票.Name = "uc売上伝票";
            this.uc売上伝票.Size = new System.Drawing.Size(845, 645);
            this.uc売上伝票.TabIndex = 80;
            this.uc売上伝票.Visible = false;
            this.uc売上伝票.売上ID = 1;
            // 
            // Form売上一覧
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(91)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(845, 729);
            this.Controls.Add(this.ucロード中);
            this.Controls.Add(this.cButton検索);
            this.Controls.Add(this.uc得意先検索);
            this.Controls.Add(this.uc社員検索);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uc社員入力);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uc得意先入力);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp期間終了);
            this.Controls.Add(this.dtp期間開始);
            this.Controls.Add(this.ucGridPager);
            this.Controls.Add(this.uc売上伝票);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form売上一覧";
            this.Text = "Form売上一覧";
            this.Load += new System.EventHandler(this.Form売上一覧_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private 共通UI.UcGridPager ucGridPager;
        private 共通UI.CButton cButton検索;
        private 共通UI.Uc得意先検索 uc得意先検索;
        private 共通UI.Uc社員検索 uc社員検索;
        private System.Windows.Forms.Label label2;
        private 共通UI.Uc社員入力 uc社員入力;
        private System.Windows.Forms.Label label3;
        private 共通UI.Uc得意先入力 uc得意先入力;
        private System.Windows.Forms.Label label1;
        private 共通UI.CDateTimePicker dtp期間終了;
        private 共通UI.CDateTimePicker dtp期間開始;
        private Uc売上伝票 uc売上伝票;
        private 共通UI.Ucロード中 ucロード中;
    }
}