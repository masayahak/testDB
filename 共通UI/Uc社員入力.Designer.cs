namespace テストDB.共通UI
{
    partial class Uc社員入力
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uc社員入力));
            this.button検索社員 = new System.Windows.Forms.Button();
            this.textBox社員名 = new テストDB.共通UI.CTextBox();
            this.textBox社員番号 = new テストDB.共通UI.CTextBox();
            this.textBox社員ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button検索社員
            // 
            this.button検索社員.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.button検索社員.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button検索社員.BackgroundImage")));
            this.button検索社員.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button検索社員.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.button検索社員.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button検索社員.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button検索社員.Location = new System.Drawing.Point(136, 1);
            this.button検索社員.Name = "button検索社員";
            this.button検索社員.Size = new System.Drawing.Size(35, 35);
            this.button検索社員.TabIndex = 54;
            this.button検索社員.UseVisualStyleBackColor = false;
            this.button検索社員.Click += new System.EventHandler(this.button検索社員_Click);
            // 
            // textBox社員名
            // 
            this.textBox社員名.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox社員名.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBox社員名.Location = new System.Drawing.Point(3, 44);
            this.textBox社員名.MaxLength = 256;
            this.textBox社員名.Name = "textBox社員名";
            this.textBox社員名.ReadOnly = true;
            this.textBox社員名.Size = new System.Drawing.Size(251, 31);
            this.textBox社員名.TabIndex = 55;
            // 
            // textBox社員番号
            // 
            this.textBox社員番号.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox社員番号.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBox社員番号.Location = new System.Drawing.Point(3, 3);
            this.textBox社員番号.MaxLength = 20;
            this.textBox社員番号.Name = "textBox社員番号";
            this.textBox社員番号.ReadOnly = true;
            this.textBox社員番号.Size = new System.Drawing.Size(127, 31);
            this.textBox社員番号.TabIndex = 53;
            this.textBox社員番号.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox社員番号_KeyDown);
            this.textBox社員番号.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox社員番号_KeyPress);
            this.textBox社員番号.Leave += new System.EventHandler(this.textBox社員番号_Leave);
            // 
            // textBox社員ID
            // 
            this.textBox社員ID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox社員ID.Location = new System.Drawing.Point(177, 3);
            this.textBox社員ID.Name = "textBox社員ID";
            this.textBox社員ID.ReadOnly = true;
            this.textBox社員ID.Size = new System.Drawing.Size(77, 31);
            this.textBox社員ID.TabIndex = 56;
            this.textBox社員ID.Visible = false;
            // 
            // UserControl社員入力
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.Controls.Add(this.textBox社員ID);
            this.Controls.Add(this.textBox社員名);
            this.Controls.Add(this.button検索社員);
            this.Controls.Add(this.textBox社員番号);
            this.Name = "UserControl社員入力";
            this.Size = new System.Drawing.Size(258, 78);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private テストDB.共通UI.CTextBox textBox社員名;
        private System.Windows.Forms.Button button検索社員;
        private テストDB.共通UI.CTextBox textBox社員番号;
        private System.Windows.Forms.TextBox textBox社員ID;
    }
}
