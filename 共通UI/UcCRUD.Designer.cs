namespace テストDB.共通UI
{
    partial class UcCRUD
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
            this.btnｷｬﾝｾﾙ = new テストDB.共通UI.CButton();
            this.btn保存 = new テストDB.共通UI.CButton();
            this.btn削除 = new テストDB.共通UI.CButton();
            this.btn修正開始 = new テストDB.共通UI.CButton();
            this.lbl作業中 = new System.Windows.Forms.Label();
            this.btn追加開始 = new テストDB.共通UI.CButton();
            this.SuspendLayout();
            // 
            // btnｷｬﾝｾﾙ
            // 
            this.btnｷｬﾝｾﾙ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnｷｬﾝｾﾙ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnｷｬﾝｾﾙ.BackColorSaved = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnｷｬﾝｾﾙ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnｷｬﾝｾﾙ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.btnｷｬﾝｾﾙ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnｷｬﾝｾﾙ.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnｷｬﾝｾﾙ.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnｷｬﾝｾﾙ.Location = new System.Drawing.Point(3, 678);
            this.btnｷｬﾝｾﾙ.Name = "btnｷｬﾝｾﾙ";
            this.btnｷｬﾝｾﾙ.Size = new System.Drawing.Size(121, 35);
            this.btnｷｬﾝｾﾙ.TabIndex = 23;
            this.btnｷｬﾝｾﾙ.Text = "ｷｬﾝｾﾙ";
            this.btnｷｬﾝｾﾙ.UseVisualStyleBackColor = false;
            this.btnｷｬﾝｾﾙ.Click += new System.EventHandler(this.btnｷｬﾝｾﾙ_Click);
            // 
            // btn保存
            // 
            this.btn保存.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn保存.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btn保存.BackColorSaved = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btn保存.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn保存.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.btn保存.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn保存.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn保存.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn保存.Location = new System.Drawing.Point(3, 583);
            this.btn保存.Name = "btn保存";
            this.btn保存.Size = new System.Drawing.Size(121, 35);
            this.btn保存.TabIndex = 22;
            this.btn保存.Text = "保存";
            this.btn保存.UseVisualStyleBackColor = false;
            this.btn保存.Click += new System.EventHandler(this.btn保存_Click);
            // 
            // btn削除
            // 
            this.btn削除.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn削除.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(122)))), ((int)(((byte)(133)))));
            this.btn削除.BackColorSaved = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(122)))), ((int)(((byte)(133)))));
            this.btn削除.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn削除.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.btn削除.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn削除.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn削除.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn削除.Location = new System.Drawing.Point(3, 206);
            this.btn削除.Name = "btn削除";
            this.btn削除.Size = new System.Drawing.Size(121, 35);
            this.btn削除.TabIndex = 21;
            this.btn削除.Text = "削除";
            this.btn削除.UseVisualStyleBackColor = false;
            this.btn削除.Click += new System.EventHandler(this.btn削除_Click);
            // 
            // btn修正開始
            // 
            this.btn修正開始.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.btn修正開始.BackColorSaved = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.btn修正開始.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn修正開始.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.btn修正開始.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn修正開始.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn修正開始.ForeColor = System.Drawing.Color.Black;
            this.btn修正開始.Location = new System.Drawing.Point(3, 65);
            this.btn修正開始.Name = "btn修正開始";
            this.btn修正開始.Size = new System.Drawing.Size(121, 35);
            this.btn修正開始.TabIndex = 26;
            this.btn修正開始.Text = "修正開始";
            this.btn修正開始.UseVisualStyleBackColor = false;
            this.btn修正開始.Click += new System.EventHandler(this.btn修正開始_Click);
            // 
            // lbl作業中
            // 
            this.lbl作業中.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl作業中.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl作業中.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl作業中.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lbl作業中.ForeColor = System.Drawing.Color.Black;
            this.lbl作業中.Location = new System.Drawing.Point(3, 5);
            this.lbl作業中.Margin = new System.Windows.Forms.Padding(5);
            this.lbl作業中.Name = "lbl作業中";
            this.lbl作業中.Size = new System.Drawing.Size(121, 40);
            this.lbl作業中.TabIndex = 25;
            this.lbl作業中.Text = "照会中";
            this.lbl作業中.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn追加開始
            // 
            this.btn追加開始.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.btn追加開始.BackColorSaved = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(179)))));
            this.btn追加開始.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn追加開始.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.btn追加開始.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn追加開始.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btn追加開始.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn追加開始.Location = new System.Drawing.Point(3, 106);
            this.btn追加開始.Name = "btn追加開始";
            this.btn追加開始.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn追加開始.Size = new System.Drawing.Size(121, 35);
            this.btn追加開始.TabIndex = 24;
            this.btn追加開始.Text = "追加開始";
            this.btn追加開始.UseVisualStyleBackColor = false;
            this.btn追加開始.Click += new System.EventHandler(this.btn追加開始_Click);
            // 
            // UcCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.Controls.Add(this.btn修正開始);
            this.Controls.Add(this.lbl作業中);
            this.Controls.Add(this.btn追加開始);
            this.Controls.Add(this.btnｷｬﾝｾﾙ);
            this.Controls.Add(this.btn保存);
            this.Controls.Add(this.btn削除);
            this.Name = "UcCRUD";
            this.Size = new System.Drawing.Size(127, 729);
            this.ResumeLayout(false);

        }

        #endregion

        private CButton btnｷｬﾝｾﾙ;
        private CButton btn保存;
        private CButton btn削除;
        private CButton btn修正開始;
        private System.Windows.Forms.Label lbl作業中;
        private CButton btn追加開始;
    }
}
