namespace テストDB.共通UI
{
    partial class Uc商品入力
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uc商品入力));
            this.textBox商品ID = new System.Windows.Forms.TextBox();
            this.textBox商品名 = new テストDB.共通UI.CTextBox();
            this.button検索商品 = new System.Windows.Forms.Button();
            this.textBoxバーコード = new テストDB.共通UI.CTextBox();
            this.SuspendLayout();
            // 
            // textBox商品ID
            // 
            this.textBox商品ID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox商品ID.Location = new System.Drawing.Point(215, 2);
            this.textBox商品ID.Name = "textBox商品ID";
            this.textBox商品ID.ReadOnly = true;
            this.textBox商品ID.Size = new System.Drawing.Size(77, 31);
            this.textBox商品ID.TabIndex = 60;
            this.textBox商品ID.Visible = false;
            // 
            // textBox商品名
            // 
            this.textBox商品名.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox商品名.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBox商品名.Location = new System.Drawing.Point(0, 43);
            this.textBox商品名.MaxLength = 256;
            this.textBox商品名.Name = "textBox商品名";
            this.textBox商品名.ReadOnly = true;
            this.textBox商品名.Size = new System.Drawing.Size(292, 31);
            this.textBox商品名.TabIndex = 59;
            // 
            // button検索商品
            // 
            this.button検索商品.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.button検索商品.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button検索商品.BackgroundImage")));
            this.button検索商品.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button検索商品.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.button検索商品.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button検索商品.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button検索商品.Location = new System.Drawing.Point(174, 0);
            this.button検索商品.Name = "button検索商品";
            this.button検索商品.Size = new System.Drawing.Size(35, 35);
            this.button検索商品.TabIndex = 58;
            this.button検索商品.UseVisualStyleBackColor = false;
            this.button検索商品.Click += new System.EventHandler(this.button検索商品_Click);
            // 
            // textBoxバーコード
            // 
            this.textBoxバーコード.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBoxバーコード.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBoxバーコード.Location = new System.Drawing.Point(0, 2);
            this.textBoxバーコード.MaxLength = 20;
            this.textBoxバーコード.Name = "textBoxバーコード";
            this.textBoxバーコード.ReadOnly = true;
            this.textBoxバーコード.Size = new System.Drawing.Size(167, 31);
            this.textBoxバーコード.TabIndex = 57;
            this.textBoxバーコード.Text = "1234567890123";
            this.textBoxバーコード.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxバーコード_KeyDown);
            this.textBoxバーコード.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxバーコード_KeyPress);
            this.textBoxバーコード.Leave += new System.EventHandler(this.textBoxバーコード_Leave);
            // 
            // Uc商品入力
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.Controls.Add(this.textBox商品ID);
            this.Controls.Add(this.textBox商品名);
            this.Controls.Add(this.button検索商品);
            this.Controls.Add(this.textBoxバーコード);
            this.Name = "Uc商品入力";
            this.Size = new System.Drawing.Size(294, 78);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox商品ID;
        private CTextBox textBox商品名;
        private System.Windows.Forms.Button button検索商品;
        private CTextBox textBoxバーコード;
    }
}
