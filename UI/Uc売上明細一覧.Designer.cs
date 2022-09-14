namespace テストDB.UI
{
    partial class Uc売上明細一覧
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
            テストDB.Models.M商品 m商品2 = new テストDB.Models.M商品();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            テストDB.Models.M得意先一覧 m得意先一覧1 = new テストDB.Models.M得意先一覧();
            this.userControl商品検索 = new テストDB.共通UI.Uc商品検索();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userControl商品入力 = new テストDB.共通UI.Uc商品入力();
            this.button期間検索 = new System.Windows.Forms.Button();
            this.dtp期間終了 = new System.Windows.Forms.DateTimePicker();
            this.dtp期間開始 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView売上日別売上一覧 = new System.Windows.Forms.DataGridView();
            this.userControl得意先検索 = new テストDB.共通UI.Uc得意先検索();
            this.label3 = new System.Windows.Forms.Label();
            this.userControl得意先入力 = new テストDB.共通UI.Uc得意先入力();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView売上日別売上一覧)).BeginInit();
            this.SuspendLayout();
            // 
            // userControl商品検索
            // 
            this.userControl商品検索.Location = new System.Drawing.Point(223, 79);
            this.userControl商品検索.Name = "userControl商品検索";
            this.userControl商品検索.Size = new System.Drawing.Size(514, 324);
            this.userControl商品検索.TabIndex = 67;
            this.userControl商品検索.Visible = false;
            this.userControl商品検索.バーコード = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 24);
            this.label2.TabIndex = 66;
            this.label2.Text = "商品(バーコード)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 65;
            this.label1.Text = "売上日";
            // 
            // userControl商品入力
            // 
            this.userControl商品入力.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.userControl商品入力.Location = new System.Drawing.Point(189, 45);
            m商品2.ID = -1;
            m商品2.バーコード = "";
            m商品2.仕入単価 = 0;
            m商品2.商品名 = "";
            m商品2.販売単価 = 0;
            this.userControl商品入力.M商品 = m商品2;
            this.userControl商品入力.Name = "userControl商品入力";
            this.userControl商品入力.ReadOnlyバーコード = false;
            this.userControl商品入力.Size = new System.Drawing.Size(258, 78);
            this.userControl商品入力.TabIndex = 64;
            this.userControl商品入力.userControl商品検索 = null;
            // 
            // button期間検索
            // 
            this.button期間検索.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.button期間検索.BackgroundImage = global::テストDB.Properties.Resources.虫眼鏡のアイコン;
            this.button期間検索.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button期間検索.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.button期間検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button期間検索.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button期間検索.Location = new System.Drawing.Point(504, 7);
            this.button期間検索.Margin = new System.Windows.Forms.Padding(5);
            this.button期間検索.Name = "button期間検索";
            this.button期間検索.Size = new System.Drawing.Size(35, 35);
            this.button期間検索.TabIndex = 63;
            this.button期間検索.UseVisualStyleBackColor = false;
            // 
            // dtp期間終了
            // 
            this.dtp期間終了.CustomFormat = "yyyy/MM/dd";
            this.dtp期間終了.Enabled = false;
            this.dtp期間終了.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp期間終了.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp期間終了.Location = new System.Drawing.Point(347, 7);
            this.dtp期間終了.Name = "dtp期間終了";
            this.dtp期間終了.Size = new System.Drawing.Size(142, 31);
            this.dtp期間終了.TabIndex = 62;
            // 
            // dtp期間開始
            // 
            this.dtp期間開始.CustomFormat = "yyyy/MM/dd";
            this.dtp期間開始.Enabled = false;
            this.dtp期間開始.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp期間開始.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp期間開始.Location = new System.Drawing.Point(189, 7);
            this.dtp期間開始.Name = "dtp期間開始";
            this.dtp期間開始.Size = new System.Drawing.Size(142, 31);
            this.dtp期間開始.TabIndex = 61;
            // 
            // dataGridView売上日別売上一覧
            // 
            this.dataGridView売上日別売上一覧.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView売上日別売上一覧.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView売上日別売上一覧.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView売上日別売上一覧.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.dataGridView売上日別売上一覧.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView売上日別売上一覧.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView売上日別売上一覧.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView売上日別売上一覧.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView売上日別売上一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView売上日別売上一覧.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView売上日別売上一覧.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView売上日別売上一覧.EnableHeadersVisualStyles = false;
            this.dataGridView売上日別売上一覧.Location = new System.Drawing.Point(0, 216);
            this.dataGridView売上日別売上一覧.MultiSelect = false;
            this.dataGridView売上日別売上一覧.Name = "dataGridView売上日別売上一覧";
            this.dataGridView売上日別売上一覧.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView売上日別売上一覧.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView売上日別売上一覧.RowHeadersVisible = false;
            this.dataGridView売上日別売上一覧.RowTemplate.Height = 36;
            this.dataGridView売上日別売上一覧.RowTemplate.ReadOnly = true;
            this.dataGridView売上日別売上一覧.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView売上日別売上一覧.Size = new System.Drawing.Size(845, 505);
            this.dataGridView売上日別売上一覧.TabIndex = 60;
            // 
            // userControl得意先検索
            // 
            this.userControl得意先検索.Location = new System.Drawing.Point(220, 166);
            this.userControl得意先検索.Name = "userControl得意先検索";
            this.userControl得意先検索.Size = new System.Drawing.Size(514, 331);
            this.userControl得意先検索.TabIndex = 70;
            this.userControl得意先検索.Visible = false;
            this.userControl得意先検索.得意先CD = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(11, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 69;
            this.label3.Text = "得意先";
            // 
            // userControl得意先入力
            // 
            this.userControl得意先入力.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.userControl得意先入力.Location = new System.Drawing.Point(186, 128);
            m得意先一覧1.ID = -1;
            m得意先一覧1.得意先CD = "";
            m得意先一覧1.得意先名 = "";
            m得意先一覧1.担当社員ID = 0;
            m得意先一覧1.担当社員名 = null;
            m得意先一覧1.担当社員番号 = null;
            this.userControl得意先入力.M得意先一覧 = m得意先一覧1;
            this.userControl得意先入力.Name = "userControl得意先入力";
            this.userControl得意先入力.ReadOnly得意先CD = false;
            this.userControl得意先入力.Size = new System.Drawing.Size(294, 78);
            this.userControl得意先入力.TabIndex = 68;
            this.userControl得意先入力.userControl得意先検索 = null;
            // 
            // UserControl売上明細一覧
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.Controls.Add(this.userControl得意先検索);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userControl得意先入力);
            this.Controls.Add(this.userControl商品検索);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userControl商品入力);
            this.Controls.Add(this.button期間検索);
            this.Controls.Add(this.dtp期間終了);
            this.Controls.Add(this.dtp期間開始);
            this.Controls.Add(this.dataGridView売上日別売上一覧);
            this.Name = "UserControl売上明細一覧";
            this.Size = new System.Drawing.Size(845, 729);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView売上日別売上一覧)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private 共通UI.Uc商品検索 userControl商品検索;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private 共通UI.Uc商品入力 userControl商品入力;
        private System.Windows.Forms.Button button期間検索;
        private System.Windows.Forms.DateTimePicker dtp期間終了;
        private System.Windows.Forms.DateTimePicker dtp期間開始;
        private System.Windows.Forms.DataGridView dataGridView売上日別売上一覧;
        private 共通UI.Uc得意先検索 userControl得意先検索;
        private System.Windows.Forms.Label label3;
        private 共通UI.Uc得意先入力 userControl得意先入力;
    }
}
