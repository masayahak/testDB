namespace テストDB
{
    partial class formダッシュボード
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.button商品別 = new System.Windows.Forms.Button();
            this.button売上日別 = new System.Windows.Forms.Button();
            this.button売上総合 = new System.Windows.Forms.Button();
            this.button得意先 = new System.Windows.Forms.Button();
            this.button社員 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControl売上総合 = new テストDB.UI.Uc売上分析();
            this.userControl社員メンテ = new テストDB.UI.Uc社員メンテ();
            this.userControl得意先メンテ = new テストDB.UI.Uc得意先メンテ();
            this.uc売上一覧 = new テストDB.UI.Uc売上一覧();
            this.uc売上明細一覧 = new テストDB.UI.Uc売上明細一覧();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.panel2.Controls.Add(this.button商品別);
            this.panel2.Controls.Add(this.button売上日別);
            this.panel2.Controls.Add(this.button売上総合);
            this.panel2.Controls.Add(this.button得意先);
            this.panel2.Controls.Add(this.button社員);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 729);
            this.panel2.TabIndex = 6;
            // 
            // button商品別
            // 
            this.button商品別.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.button商品別.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button商品別.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(137)))), ((int)(((byte)(163)))));
            this.button商品別.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button商品別.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button商品別.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(137)))), ((int)(((byte)(163)))));
            this.button商品別.Image = global::テストDB.Properties.Resources.商品;
            this.button商品別.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button商品別.Location = new System.Drawing.Point(12, 268);
            this.button商品別.Name = "button商品別";
            this.button商品別.Size = new System.Drawing.Size(135, 48);
            this.button商品別.TabIndex = 7;
            this.button商品別.Text = " 商品別";
            this.button商品別.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button商品別.UseVisualStyleBackColor = false;
            this.button商品別.Click += new System.EventHandler(this.button商品別_Click);
            // 
            // button売上日別
            // 
            this.button売上日別.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.button売上日別.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button売上日別.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(137)))), ((int)(((byte)(163)))));
            this.button売上日別.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button売上日別.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button売上日別.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(137)))), ((int)(((byte)(163)))));
            this.button売上日別.Image = global::テストDB.Properties.Resources.日別;
            this.button売上日別.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button売上日別.Location = new System.Drawing.Point(12, 214);
            this.button売上日別.Name = "button売上日別";
            this.button売上日別.Size = new System.Drawing.Size(135, 48);
            this.button売上日別.TabIndex = 5;
            this.button売上日別.Text = "　日 別";
            this.button売上日別.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button売上日別.UseVisualStyleBackColor = false;
            this.button売上日別.Click += new System.EventHandler(this.button売上日別_Click);
            // 
            // button売上総合
            // 
            this.button売上総合.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.button売上総合.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button売上総合.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button売上総合.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button売上総合.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button売上総合.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button売上総合.Image = global::テストDB.Properties.Resources.分析;
            this.button売上総合.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button売上総合.Location = new System.Drawing.Point(12, 160);
            this.button売上総合.Name = "button売上総合";
            this.button売上総合.Size = new System.Drawing.Size(135, 48);
            this.button売上総合.TabIndex = 4;
            this.button売上総合.Text = "　分 析";
            this.button売上総合.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button売上総合.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button売上総合.UseVisualStyleBackColor = false;
            this.button売上総合.Click += new System.EventHandler(this.button売上総合_Click);
            // 
            // button得意先
            // 
            this.button得意先.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button得意先.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.button得意先.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button得意先.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(137)))), ((int)(((byte)(163)))));
            this.button得意先.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button得意先.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button得意先.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(137)))), ((int)(((byte)(163)))));
            this.button得意先.Image = global::テストDB.Properties.Resources.得意先;
            this.button得意先.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button得意先.Location = new System.Drawing.Point(12, 508);
            this.button得意先.Name = "button得意先";
            this.button得意先.Size = new System.Drawing.Size(135, 48);
            this.button得意先.TabIndex = 3;
            this.button得意先.Text = " 得意先";
            this.button得意先.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button得意先.UseVisualStyleBackColor = false;
            this.button得意先.Click += new System.EventHandler(this.button得意先_Click);
            // 
            // button社員
            // 
            this.button社員.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button社員.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.button社員.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button社員.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(137)))), ((int)(((byte)(163)))));
            this.button社員.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button社員.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button社員.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(137)))), ((int)(((byte)(163)))));
            this.button社員.Image = global::テストDB.Properties.Resources.社員;
            this.button社員.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button社員.Location = new System.Drawing.Point(12, 454);
            this.button社員.Name = "button社員";
            this.button社員.Size = new System.Drawing.Size(135, 48);
            this.button社員.TabIndex = 2;
            this.button社員.Text = "　社 員";
            this.button社員.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button社員.UseVisualStyleBackColor = false;
            this.button社員.Click += new System.EventHandler(this.button社員_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.userControl売上総合);
            this.panel1.Controls.Add(this.userControl社員メンテ);
            this.panel1.Controls.Add(this.userControl得意先メンテ);
            this.panel1.Controls.Add(this.uc売上一覧);
            this.panel1.Controls.Add(this.uc売上明細一覧);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(163, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 729);
            this.panel1.TabIndex = 7;
            // 
            // userControl売上総合
            // 
            this.userControl売上総合.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.userControl売上総合.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl売上総合.Location = new System.Drawing.Point(0, 0);
            this.userControl売上総合.Name = "userControl売上総合";
            this.userControl売上総合.Size = new System.Drawing.Size(845, 729);
            this.userControl売上総合.TabIndex = 2;
            // 
            // userControl社員メンテ
            // 
            this.userControl社員メンテ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.userControl社員メンテ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl社員メンテ.Location = new System.Drawing.Point(0, 0);
            this.userControl社員メンテ.Name = "userControl社員メンテ";
            this.userControl社員メンテ.Size = new System.Drawing.Size(845, 729);
            this.userControl社員メンテ.TabIndex = 0;
            // 
            // userControl得意先メンテ
            // 
            this.userControl得意先メンテ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.userControl得意先メンテ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl得意先メンテ.Location = new System.Drawing.Point(0, 0);
            this.userControl得意先メンテ.Name = "userControl得意先メンテ";
            this.userControl得意先メンテ.Size = new System.Drawing.Size(845, 729);
            this.userControl得意先メンテ.TabIndex = 1;
            this.userControl得意先メンテ.Visible = false;
            // 
            // uc売上一覧
            // 
            this.uc売上一覧.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.uc売上一覧.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc売上一覧.Location = new System.Drawing.Point(0, 0);
            this.uc売上一覧.Name = "uc売上一覧";
            this.uc売上一覧.Size = new System.Drawing.Size(845, 729);
            this.uc売上一覧.TabIndex = 4;
            this.uc売上一覧.Visible = false;
            // 
            // uc売上明細一覧
            // 
            this.uc売上明細一覧.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.uc売上明細一覧.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc売上明細一覧.Location = new System.Drawing.Point(0, 0);
            this.uc売上明細一覧.Name = "uc売上明細一覧";
            this.uc売上明細一覧.Size = new System.Drawing.Size(845, 729);
            this.uc売上明細一覧.TabIndex = 5;
            // 
            // formダッシュボード
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "formダッシュボード";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ダッシュボード";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button社員;
        private System.Windows.Forms.Panel panel1;
        private UI.Uc社員メンテ userControl社員メンテ;
        private UI.Uc得意先メンテ userControl得意先メンテ;
        private System.Windows.Forms.Button button得意先;
        private System.Windows.Forms.Button button売上総合;
        private UI.Uc売上分析 userControl売上総合;
        private System.Windows.Forms.Button button売上日別;
        private UI.Uc売上一覧 uc売上一覧;
        private System.Windows.Forms.Button button商品別;
        private UI.Uc売上明細一覧 uc売上明細一覧;
    }
}

