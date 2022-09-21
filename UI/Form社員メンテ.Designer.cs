namespace テストDB.UI
{
    partial class Form社員メンテ
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form社員メンテ));
            this.panel詳細 = new System.Windows.Forms.Panel();
            this.textBox社員名 = new テストDB.共通UI.CTextBox();
            this.textBox社員番号 = new テストDB.共通UI.CTextBox();
            this.textBox社員ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel操作 = new System.Windows.Forms.Panel();
            this.buttonｷｬﾝｾﾙ = new テストDB.共通UI.CButton();
            this.button保存 = new テストDB.共通UI.CButton();
            this.button削除 = new テストDB.共通UI.CButton();
            this.userControl処理モード = new テストDB.UI.Uc処理モード();
            this.panel検索 = new System.Windows.Forms.Panel();
            this.dataGridView社員一覧 = new System.Windows.Forms.DataGridView();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.textBox検索 = new System.Windows.Forms.TextBox();
            this.button検索 = new System.Windows.Forms.Button();
            this.pictureBoxロード中 = new System.Windows.Forms.PictureBox();
            this.panel詳細.SuspendLayout();
            this.panel操作.SuspendLayout();
            this.panel検索.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView社員一覧)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxロード中)).BeginInit();
            this.SuspendLayout();
            // 
            // panel詳細
            // 
            this.panel詳細.Controls.Add(this.textBox社員名);
            this.panel詳細.Controls.Add(this.textBox社員番号);
            this.panel詳細.Controls.Add(this.textBox社員ID);
            this.panel詳細.Controls.Add(this.label2);
            this.panel詳細.Controls.Add(this.label1);
            this.panel詳細.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel詳細.Location = new System.Drawing.Point(327, 0);
            this.panel詳細.Name = "panel詳細";
            this.panel詳細.Size = new System.Drawing.Size(375, 690);
            this.panel詳細.TabIndex = 33;
            // 
            // textBox社員名
            // 
            this.textBox社員名.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox社員名.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBox社員名.Location = new System.Drawing.Point(120, 99);
            this.textBox社員名.MaxLength = 256;
            this.textBox社員名.Name = "textBox社員名";
            this.textBox社員名.ReadOnly = true;
            this.textBox社員名.Size = new System.Drawing.Size(251, 31);
            this.textBox社員名.TabIndex = 33;
            // 
            // textBox社員番号
            // 
            this.textBox社員番号.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox社員番号.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBox社員番号.Location = new System.Drawing.Point(120, 54);
            this.textBox社員番号.MaxLength = 20;
            this.textBox社員番号.Name = "textBox社員番号";
            this.textBox社員番号.ReadOnly = true;
            this.textBox社員番号.Size = new System.Drawing.Size(168, 31);
            this.textBox社員番号.TabIndex = 32;
            // 
            // textBox社員ID
            // 
            this.textBox社員ID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox社員ID.Location = new System.Drawing.Point(120, 147);
            this.textBox社員ID.Name = "textBox社員ID";
            this.textBox社員ID.ReadOnly = true;
            this.textBox社員ID.Size = new System.Drawing.Size(168, 31);
            this.textBox社員ID.TabIndex = 31;
            this.textBox社員ID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(8, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "社員名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(8, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "社員番号";
            // 
            // panel操作
            // 
            this.panel操作.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.panel操作.Controls.Add(this.buttonｷｬﾝｾﾙ);
            this.panel操作.Controls.Add(this.button保存);
            this.panel操作.Controls.Add(this.button削除);
            this.panel操作.Controls.Add(this.userControl処理モード);
            this.panel操作.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel操作.Location = new System.Drawing.Point(702, 0);
            this.panel操作.Name = "panel操作";
            this.panel操作.Size = new System.Drawing.Size(127, 690);
            this.panel操作.TabIndex = 32;
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
            this.button削除.Location = new System.Drawing.Point(3, 201);
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
            // panel検索
            // 
            this.panel検索.Controls.Add(this.dataGridView社員一覧);
            this.panel検索.Controls.Add(this.buttonExcel);
            this.panel検索.Controls.Add(this.textBox検索);
            this.panel検索.Controls.Add(this.button検索);
            this.panel検索.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel検索.Location = new System.Drawing.Point(0, 0);
            this.panel検索.Name = "panel検索";
            this.panel検索.Size = new System.Drawing.Size(327, 690);
            this.panel検索.TabIndex = 34;
            // 
            // dataGridView社員一覧
            // 
            this.dataGridView社員一覧.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView社員一覧.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView社員一覧.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView社員一覧.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.dataGridView社員一覧.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView社員一覧.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView社員一覧.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView社員一覧.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView社員一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView社員一覧.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView社員一覧.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView社員一覧.EnableHeadersVisualStyles = false;
            this.dataGridView社員一覧.Location = new System.Drawing.Point(3, 46);
            this.dataGridView社員一覧.MultiSelect = false;
            this.dataGridView社員一覧.Name = "dataGridView社員一覧";
            this.dataGridView社員一覧.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView社員一覧.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView社員一覧.RowHeadersVisible = false;
            this.dataGridView社員一覧.RowTemplate.Height = 36;
            this.dataGridView社員一覧.RowTemplate.ReadOnly = true;
            this.dataGridView社員一覧.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView社員一覧.Size = new System.Drawing.Size(326, 644);
            this.dataGridView社員一覧.TabIndex = 36;
            this.dataGridView社員一覧.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView社員一覧_CellClick);
            this.dataGridView社員一覧.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView社員一覧_CellDoubleClick);
            this.dataGridView社員一覧.SelectionChanged += new System.EventHandler(this.dataGridView社員一覧_SelectionChanged);
            // 
            // buttonExcel
            // 
            this.buttonExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonExcel.BackgroundImage = global::テストDB.Properties.Resources.EXCEL;
            this.buttonExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.buttonExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonExcel.Location = new System.Drawing.Point(291, 2);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(35, 35);
            this.buttonExcel.TabIndex = 35;
            this.buttonExcel.UseVisualStyleBackColor = false;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // textBox検索
            // 
            this.textBox検索.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox検索.Location = new System.Drawing.Point(3, 3);
            this.textBox検索.Name = "textBox検索";
            this.textBox検索.Size = new System.Drawing.Size(176, 31);
            this.textBox検索.TabIndex = 34;
            this.textBox検索.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox検索_KeyDown);
            this.textBox検索.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox検索_KeyPress);
            // 
            // button検索
            // 
            this.button検索.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.button検索.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button検索.BackgroundImage")));
            this.button検索.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button検索.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(205)))), ((int)(((byte)(211)))));
            this.button検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button検索.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button検索.Location = new System.Drawing.Point(185, 1);
            this.button検索.Name = "button検索";
            this.button検索.Size = new System.Drawing.Size(35, 35);
            this.button検索.TabIndex = 33;
            this.button検索.UseVisualStyleBackColor = false;
            this.button検索.Click += new System.EventHandler(this.button検索_Click);
            // 
            // pictureBoxロード中
            // 
            this.pictureBoxロード中.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxロード中.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxロード中.Image = global::テストDB.Properties.Resources.Loading_icon;
            this.pictureBoxロード中.Location = new System.Drawing.Point(166, 193);
            this.pictureBoxロード中.Name = "pictureBoxロード中";
            this.pictureBoxロード中.Size = new System.Drawing.Size(441, 291);
            this.pictureBoxロード中.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxロード中.TabIndex = 36;
            this.pictureBoxロード中.TabStop = false;
            // 
            // Form社員メンテ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(829, 690);
            this.Controls.Add(this.pictureBoxロード中);
            this.Controls.Add(this.panel詳細);
            this.Controls.Add(this.panel操作);
            this.Controls.Add(this.panel検索);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form社員メンテ";
            this.Text = "Form社員メンテ";
            this.Load += new System.EventHandler(this.Form社員メンテ_Load);
            this.panel詳細.ResumeLayout(false);
            this.panel詳細.PerformLayout();
            this.panel操作.ResumeLayout(false);
            this.panel検索.ResumeLayout(false);
            this.panel検索.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView社員一覧)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxロード中)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel詳細;
        private 共通UI.CTextBox textBox社員名;
        private 共通UI.CTextBox textBox社員番号;
        private System.Windows.Forms.TextBox textBox社員ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel操作;
        private 共通UI.CButton buttonｷｬﾝｾﾙ;
        private 共通UI.CButton button保存;
        private 共通UI.CButton button削除;
        private Uc処理モード userControl処理モード;
        private System.Windows.Forms.Panel panel検索;
        private System.Windows.Forms.DataGridView dataGridView社員一覧;
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.TextBox textBox検索;
        private System.Windows.Forms.Button button検索;
        private System.Windows.Forms.PictureBox pictureBoxロード中;
    }
}