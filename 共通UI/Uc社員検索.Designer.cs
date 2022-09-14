namespace テストDB.共通UI
{
    partial class Uc社員検索
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uc社員検索));
            this.dataGridView社員一覧 = new System.Windows.Forms.DataGridView();
            this.panel検索 = new System.Windows.Forms.Panel();
            this.button閉じる = new System.Windows.Forms.Button();
            this.textBox検索 = new System.Windows.Forms.TextBox();
            this.button検索 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView社員一覧)).BeginInit();
            this.panel検索.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView社員一覧
            // 
            this.dataGridView社員一覧.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView社員一覧.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView社員一覧.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.dataGridView社員一覧.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView社員一覧.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView社員一覧.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView社員一覧.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView社員一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView社員一覧.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView社員一覧.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView社員一覧.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView社員一覧.EnableHeadersVisualStyles = false;
            this.dataGridView社員一覧.Location = new System.Drawing.Point(0, 0);
            this.dataGridView社員一覧.MultiSelect = false;
            this.dataGridView社員一覧.Name = "dataGridView社員一覧";
            this.dataGridView社員一覧.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView社員一覧.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView社員一覧.RowHeadersVisible = false;
            this.dataGridView社員一覧.RowTemplate.Height = 36;
            this.dataGridView社員一覧.RowTemplate.ReadOnly = true;
            this.dataGridView社員一覧.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView社員一覧.Size = new System.Drawing.Size(284, 218);
            this.dataGridView社員一覧.TabIndex = 33;
            this.dataGridView社員一覧.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView社員一覧_CellDoubleClick);
            // 
            // panel検索
            // 
            this.panel検索.Controls.Add(this.button閉じる);
            this.panel検索.Controls.Add(this.textBox検索);
            this.panel検索.Controls.Add(this.button検索);
            this.panel検索.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel検索.Location = new System.Drawing.Point(0, 218);
            this.panel検索.Name = "panel検索";
            this.panel検索.Size = new System.Drawing.Size(284, 44);
            this.panel検索.TabIndex = 39;
            // 
            // button閉じる
            // 
            this.button閉じる.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button閉じる.BackColor = System.Drawing.SystemColors.Control;
            this.button閉じる.BackgroundImage = global::テストDB.Properties.Resources.ノーマルの太さのバツアイコン;
            this.button閉じる.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button閉じる.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.button閉じる.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button閉じる.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button閉じる.Location = new System.Drawing.Point(246, 5);
            this.button閉じる.Name = "button閉じる";
            this.button閉じる.Size = new System.Drawing.Size(35, 35);
            this.button閉じる.TabIndex = 41;
            this.button閉じる.UseVisualStyleBackColor = false;
            this.button閉じる.Click += new System.EventHandler(this.button閉じる_Click);
            // 
            // textBox検索
            // 
            this.textBox検索.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox検索.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox検索.Location = new System.Drawing.Point(3, 7);
            this.textBox検索.Name = "textBox検索";
            this.textBox検索.Size = new System.Drawing.Size(176, 31);
            this.textBox検索.TabIndex = 40;
            this.textBox検索.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox検索_KeyDown);
            this.textBox検索.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox検索_KeyPress);
            // 
            // button検索
            // 
            this.button検索.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button検索.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.button検索.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button検索.BackgroundImage")));
            this.button検索.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button検索.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.button検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button検索.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button検索.Location = new System.Drawing.Point(185, 5);
            this.button検索.Name = "button検索";
            this.button検索.Size = new System.Drawing.Size(35, 35);
            this.button検索.TabIndex = 39;
            this.button検索.UseVisualStyleBackColor = false;
            this.button検索.Click += new System.EventHandler(this.button検索_Click);
            // 
            // UserControl社員検索
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.dataGridView社員一覧);
            this.Controls.Add(this.panel検索);
            this.Name = "UserControl社員検索";
            this.Size = new System.Drawing.Size(284, 262);
            this.Load += new System.EventHandler(this.UserControl社員入力_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView社員一覧)).EndInit();
            this.panel検索.ResumeLayout(false);
            this.panel検索.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView社員一覧;
        private System.Windows.Forms.Panel panel検索;
        private System.Windows.Forms.TextBox textBox検索;
        private System.Windows.Forms.Button button検索;
        private System.Windows.Forms.Button button閉じる;
    }
}
