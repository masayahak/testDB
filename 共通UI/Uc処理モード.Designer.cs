namespace テストDB.UI
{
    partial class Uc処理モード
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
            this.label作業中 = new System.Windows.Forms.Label();
            this.button修正作業中 = new テストDB.共通UI.CButton();
            this.button追加作業中 = new テストDB.共通UI.CButton();
            this.SuspendLayout();
            // 
            // label作業中
            // 
            this.label作業中.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label作業中.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label作業中.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label作業中.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label作業中.ForeColor = System.Drawing.Color.Black;
            this.label作業中.Location = new System.Drawing.Point(0, 0);
            this.label作業中.Margin = new System.Windows.Forms.Padding(5);
            this.label作業中.Name = "label作業中";
            this.label作業中.Size = new System.Drawing.Size(121, 40);
            this.label作業中.TabIndex = 16;
            this.label作業中.Text = "照会中";
            this.label作業中.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button修正作業中
            // 
            this.button修正作業中.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.button修正作業中.BackColorSaved = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.button修正作業中.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button修正作業中.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.button修正作業中.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button修正作業中.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button修正作業中.ForeColor = System.Drawing.Color.Black;
            this.button修正作業中.Location = new System.Drawing.Point(0, 60);
            this.button修正作業中.Name = "button修正作業中";
            this.button修正作業中.Size = new System.Drawing.Size(121, 35);
            this.button修正作業中.TabIndex = 17;
            this.button修正作業中.Text = "修正開始";
            this.button修正作業中.UseVisualStyleBackColor = false;
            this.button修正作業中.Click += new System.EventHandler(this.button修正作業中_Click);
            // 
            // button追加作業中
            // 
            this.button追加作業中.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.button追加作業中.BackColorSaved = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.button追加作業中.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button追加作業中.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.button追加作業中.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button追加作業中.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.button追加作業中.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button追加作業中.Location = new System.Drawing.Point(0, 101);
            this.button追加作業中.Name = "button追加作業中";
            this.button追加作業中.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button追加作業中.Size = new System.Drawing.Size(121, 35);
            this.button追加作業中.TabIndex = 15;
            this.button追加作業中.Text = "追加開始";
            this.button追加作業中.UseVisualStyleBackColor = false;
            this.button追加作業中.Click += new System.EventHandler(this.button追加作業中_Click);
            // 
            // UserControl処理モード
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.Controls.Add(this.button修正作業中);
            this.Controls.Add(this.label作業中);
            this.Controls.Add(this.button追加作業中);
            this.Name = "UserControl処理モード";
            this.Size = new System.Drawing.Size(121, 137);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label作業中;
        private 共通UI.CButton button修正作業中;
        private 共通UI.CButton button追加作業中;
    }
}
