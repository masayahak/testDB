namespace テストDB.UI
{
    partial class Form得意先メンテ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form得意先メンテ));
            テストDB.Models.M社員 m社員2 = new テストDB.Models.M社員();
            this.dataGridView得意先一覧 = new System.Windows.Forms.DataGridView();
            this.textBox検索 = new System.Windows.Forms.TextBox();
            this.panel検索 = new System.Windows.Forms.Panel();
            this.button検索 = new System.Windows.Forms.Button();
            this.textBox得意先ID = new System.Windows.Forms.TextBox();
            this.textBox担当社員ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel詳細 = new System.Windows.Forms.Panel();
            this.uc社員検索 = new テストDB.共通UI.Uc社員検索();
            this.uc社員入力 = new テストDB.共通UI.Uc社員入力();
            this.textBox得意先名 = new テストDB.共通UI.CTextBox();
            this.textBox得意先CD = new テストDB.共通UI.CTextBox();
            this.panel操作 = new System.Windows.Forms.Panel();
            this.buttonｷｬﾝｾﾙ = new テストDB.共通UI.CButton();
            this.button保存 = new テストDB.共通UI.CButton();
            this.button削除 = new テストDB.共通UI.CButton();
            this.userControl処理モード = new テストDB.UI.Uc処理モード();
            this.ucロード中 = new テストDB.共通UI.Ucロード中();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView得意先一覧)).BeginInit();
            this.panel検索.SuspendLayout();
            this.panel詳細.SuspendLayout();
            this.panel操作.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView得意先一覧
            // 
            this.dataGridView得意先一覧.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView得意先一覧.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView得意先一覧.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView得意先一覧.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.dataGridView得意先一覧.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView得意先一覧.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView得意先一覧.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView得意先一覧.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView得意先一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView得意先一覧.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView得意先一覧.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView得意先一覧.EnableHeadersVisualStyles = false;
            this.dataGridView得意先一覧.Location = new System.Drawing.Point(0, 41);
            this.dataGridView得意先一覧.MultiSelect = false;
            this.dataGridView得意先一覧.Name = "dataGridView得意先一覧";
            this.dataGridView得意先一覧.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView得意先一覧.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView得意先一覧.RowHeadersVisible = false;
            this.dataGridView得意先一覧.RowTemplate.Height = 36;
            this.dataGridView得意先一覧.RowTemplate.ReadOnly = true;
            this.dataGridView得意先一覧.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView得意先一覧.Size = new System.Drawing.Size(702, 647);
            this.dataGridView得意先一覧.TabIndex = 50;
            this.dataGridView得意先一覧.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView得意先一覧_CellClick);
            this.dataGridView得意先一覧.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView得意先一覧_CellDoubleClick);
            this.dataGridView得意先一覧.SelectionChanged += new System.EventHandler(this.dataGridView得意先一覧_SelectionChanged);
            // 
            // textBox検索
            // 
            this.textBox検索.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox検索.Location = new System.Drawing.Point(3, 3);
            this.textBox検索.Name = "textBox検索";
            this.textBox検索.Size = new System.Drawing.Size(176, 31);
            this.textBox検索.TabIndex = 36;
            this.textBox検索.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox検索_KeyDown);
            this.textBox検索.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox検索_KeyPress);
            // 
            // panel検索
            // 
            this.panel検索.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel検索.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel検索.Controls.Add(this.textBox検索);
            this.panel検索.Controls.Add(this.button検索);
            this.panel検索.Location = new System.Drawing.Point(0, 0);
            this.panel検索.Name = "panel検索";
            this.panel検索.Size = new System.Drawing.Size(702, 41);
            this.panel検索.TabIndex = 49;
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
            this.button検索.TabIndex = 35;
            this.button検索.UseVisualStyleBackColor = false;
            this.button検索.Click += new System.EventHandler(this.button検索_Click);
            // 
            // textBox得意先ID
            // 
            this.textBox得意先ID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox得意先ID.Location = new System.Drawing.Point(162, 213);
            this.textBox得意先ID.Name = "textBox得意先ID";
            this.textBox得意先ID.ReadOnly = true;
            this.textBox得意先ID.Size = new System.Drawing.Size(168, 31);
            this.textBox得意先ID.TabIndex = 57;
            this.textBox得意先ID.Visible = false;
            // 
            // textBox担当社員ID
            // 
            this.textBox担当社員ID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox担当社員ID.Location = new System.Drawing.Point(374, 120);
            this.textBox担当社員ID.Name = "textBox担当社員ID";
            this.textBox担当社員ID.ReadOnly = true;
            this.textBox担当社員ID.Size = new System.Drawing.Size(168, 31);
            this.textBox担当社員ID.TabIndex = 54;
            this.textBox担当社員ID.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(15, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 46;
            this.label3.Text = "担当社員";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "得意先名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "得意先コード";
            // 
            // panel詳細
            // 
            this.panel詳細.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel詳細.Controls.Add(this.uc社員検索);
            this.panel詳細.Controls.Add(this.textBox得意先ID);
            this.panel詳細.Controls.Add(this.uc社員入力);
            this.panel詳細.Controls.Add(this.textBox担当社員ID);
            this.panel詳細.Controls.Add(this.label3);
            this.panel詳細.Controls.Add(this.textBox得意先名);
            this.panel詳細.Controls.Add(this.textBox得意先CD);
            this.panel詳細.Controls.Add(this.label2);
            this.panel詳細.Controls.Add(this.label1);
            this.panel詳細.Location = new System.Drawing.Point(0, 41);
            this.panel詳細.Name = "panel詳細";
            this.panel詳細.Size = new System.Drawing.Size(702, 647);
            this.panel詳細.TabIndex = 48;
            // 
            // uc社員検索
            // 
            this.uc社員検索.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uc社員検索.Location = new System.Drawing.Point(300, 123);
            this.uc社員検索.Name = "uc社員検索";
            this.uc社員検索.Size = new System.Drawing.Size(284, 262);
            this.uc社員検索.TabIndex = 55;
            this.uc社員検索.社員番号 = null;
            // 
            // uc社員入力
            // 
            this.uc社員入力.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.uc社員入力.Location = new System.Drawing.Point(162, 119);
            m社員2.ID = -1;
            m社員2.社員名 = "";
            m社員2.社員番号 = "";
            this.uc社員入力.M社員 = m社員2;
            this.uc社員入力.Name = "uc社員入力";
            this.uc社員入力.ReadOnly社員番号 = false;
            this.uc社員入力.Size = new System.Drawing.Size(258, 78);
            this.uc社員入力.TabIndex = 56;
            this.uc社員入力.uc社員検索 = this.uc社員検索;
            // 
            // textBox得意先名
            // 
            this.textBox得意先名.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox得意先名.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBox得意先名.Location = new System.Drawing.Point(162, 69);
            this.textBox得意先名.MaxLength = 256;
            this.textBox得意先名.Name = "textBox得意先名";
            this.textBox得意先名.ReadOnly = true;
            this.textBox得意先名.Size = new System.Drawing.Size(251, 31);
            this.textBox得意先名.TabIndex = 45;
            // 
            // textBox得意先CD
            // 
            this.textBox得意先CD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox得意先CD.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBox得意先CD.Location = new System.Drawing.Point(162, 24);
            this.textBox得意先CD.MaxLength = 20;
            this.textBox得意先CD.Name = "textBox得意先CD";
            this.textBox得意先CD.ReadOnly = true;
            this.textBox得意先CD.Size = new System.Drawing.Size(168, 31);
            this.textBox得意先CD.TabIndex = 44;
            // 
            // panel操作
            // 
            this.panel操作.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel操作.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.panel操作.Controls.Add(this.buttonｷｬﾝｾﾙ);
            this.panel操作.Controls.Add(this.button保存);
            this.panel操作.Controls.Add(this.button削除);
            this.panel操作.Controls.Add(this.userControl処理モード);
            this.panel操作.Location = new System.Drawing.Point(702, 0);
            this.panel操作.Name = "panel操作";
            this.panel操作.Size = new System.Drawing.Size(127, 690);
            this.panel操作.TabIndex = 47;
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
            this.button削除.Location = new System.Drawing.Point(3, 246);
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
            // ucロード中
            // 
            this.ucロード中.BackColor = System.Drawing.Color.Black;
            this.ucロード中.Location = new System.Drawing.Point(204, 267);
            this.ucロード中.Name = "ucロード中";
            this.ucロード中.Size = new System.Drawing.Size(340, 125);
            this.ucロード中.TabIndex = 37;
            // 
            // Form得意先メンテ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(829, 690);
            this.Controls.Add(this.ucロード中);
            this.Controls.Add(this.panel検索);
            this.Controls.Add(this.panel詳細);
            this.Controls.Add(this.panel操作);
            this.Controls.Add(this.dataGridView得意先一覧);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form得意先メンテ";
            this.Text = "Form得意先メンテ";
            this.Load += new System.EventHandler(this.Form得意先メンテ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView得意先一覧)).EndInit();
            this.panel検索.ResumeLayout(false);
            this.panel検索.PerformLayout();
            this.panel詳細.ResumeLayout(false);
            this.panel詳細.PerformLayout();
            this.panel操作.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView得意先一覧;
        private System.Windows.Forms.TextBox textBox検索;
        private System.Windows.Forms.Panel panel検索;
        private System.Windows.Forms.Button button検索;
        private 共通UI.Uc社員検索 uc社員検索;
        private System.Windows.Forms.TextBox textBox得意先ID;
        private 共通UI.Uc社員入力 uc社員入力;
        private System.Windows.Forms.TextBox textBox担当社員ID;
        private 共通UI.CButton button削除;
        private Uc処理モード userControl処理モード;
        private System.Windows.Forms.Label label3;
        private 共通UI.CTextBox textBox得意先名;
        private 共通UI.CTextBox textBox得意先CD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private 共通UI.CButton buttonｷｬﾝｾﾙ;
        private 共通UI.CButton button保存;
        private System.Windows.Forms.Panel panel詳細;
        private System.Windows.Forms.Panel panel操作;
        private 共通UI.Ucロード中 ucロード中;
    }
}