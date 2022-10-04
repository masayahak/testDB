namespace 共通UI
{
    partial class Uc得意先入力
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uc得意先入力));
            this.textBox得意先ID = new System.Windows.Forms.TextBox();
            this.textBox得意先名 = new 共通UI.CTextBox();
            this.textBox得意先CD = new 共通UI.CTextBox();
            this.button検索商品 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox得意先ID
            // 
            this.textBox得意先ID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox得意先ID.Location = new System.Drawing.Point(216, 4);
            this.textBox得意先ID.Name = "textBox得意先ID";
            this.textBox得意先ID.ReadOnly = true;
            this.textBox得意先ID.Size = new System.Drawing.Size(77, 31);
            this.textBox得意先ID.TabIndex = 64;
            this.textBox得意先ID.Visible = false;
            // 
            // textBox得意先名
            // 
            this.textBox得意先名.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox得意先名.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBox得意先名.Location = new System.Drawing.Point(1, 45);
            this.textBox得意先名.MaxLength = 256;
            this.textBox得意先名.Name = "textBox得意先名";
            this.textBox得意先名.ReadOnly = true;
            this.textBox得意先名.Size = new System.Drawing.Size(292, 31);
            this.textBox得意先名.TabIndex = 63;
            // 
            // textBox得意先CD
            // 
            this.textBox得意先CD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox得意先CD.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBox得意先CD.Location = new System.Drawing.Point(1, 4);
            this.textBox得意先CD.MaxLength = 20;
            this.textBox得意先CD.Name = "textBox得意先CD";
            this.textBox得意先CD.ReadOnly = true;
            this.textBox得意先CD.Size = new System.Drawing.Size(167, 31);
            this.textBox得意先CD.TabIndex = 61;
            this.textBox得意先CD.Text = "1234567890123";
            this.textBox得意先CD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox得意先CD_KeyDown);
            this.textBox得意先CD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox得意先CD_KeyPress);
            this.textBox得意先CD.Leave += new System.EventHandler(this.textBox得意先CD_Leave);
            // 
            // button検索商品
            // 
            this.button検索商品.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(91)))), ((int)(((byte)(108)))));
            this.button検索商品.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button検索商品.BackgroundImage")));
            this.button検索商品.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button検索商品.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.button検索商品.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button検索商品.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button検索商品.Location = new System.Drawing.Point(175, 2);
            this.button検索商品.Name = "button検索商品";
            this.button検索商品.Size = new System.Drawing.Size(35, 35);
            this.button検索商品.TabIndex = 62;
            this.button検索商品.UseVisualStyleBackColor = false;
            this.button検索商品.Click += new System.EventHandler(this.button検索得意先_Click);
            // 
            // Uc得意先入力
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(91)))), ((int)(((byte)(108)))));
            this.Controls.Add(this.textBox得意先ID);
            this.Controls.Add(this.textBox得意先名);
            this.Controls.Add(this.button検索商品);
            this.Controls.Add(this.textBox得意先CD);
            this.Name = "Uc得意先入力";
            this.Size = new System.Drawing.Size(294, 78);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox得意先ID;
        private CTextBox textBox得意先名;
        private System.Windows.Forms.Button button検索商品;
        private CTextBox textBox得意先CD;
    }
}
