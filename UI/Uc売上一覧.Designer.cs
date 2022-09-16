using System.Windows.Forms;

namespace テストDB.UI
{
    partial class Uc売上一覧
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
            テストDB.Models.M社員 m社員1 = new テストDB.Models.M社員();
            テストDB.Models.M得意先一覧 m得意先一覧1 = new テストDB.Models.M得意先一覧();
            this.dtp期間終了 = new System.Windows.Forms.DateTimePicker();
            this.dtp期間開始 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cButton検索 = new テストDB.共通UI.CButton();
            this.userControl売上伝票 = new テストDB.UI.Uc売上伝票();
            this.dgvPager売上一覧 = new テストDB.共通UI.DgvPager();
            this.userControl得意先検索 = new テストDB.共通UI.Uc得意先検索();
            this.userControl社員検索 = new テストDB.共通UI.Uc社員検索();
            this.userControl社員入力 = new テストDB.共通UI.Uc社員入力();
            this.userControl得意先入力 = new テストDB.共通UI.Uc得意先入力();
            this.ucPageControl = new テストDB.共通UI.UcPageControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPager売上一覧)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp期間終了
            // 
            this.dtp期間終了.CustomFormat = "yyyy/MM/dd";
            this.dtp期間終了.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp期間終了.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp期間終了.Location = new System.Drawing.Point(347, 15);
            this.dtp期間終了.Name = "dtp期間終了";
            this.dtp期間終了.Size = new System.Drawing.Size(142, 31);
            this.dtp期間終了.TabIndex = 49;
            // 
            // dtp期間開始
            // 
            this.dtp期間開始.CustomFormat = "yyyy/MM/dd";
            this.dtp期間開始.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp期間開始.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp期間開始.Location = new System.Drawing.Point(189, 15);
            this.dtp期間開始.Name = "dtp期間開始";
            this.dtp期間開始.Size = new System.Drawing.Size(142, 31);
            this.dtp期間開始.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 57;
            this.label1.Text = "売上日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(14, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 61;
            this.label3.Text = "得意先";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(14, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 64;
            this.label2.Text = "担当社員";
            // 
            // cButton検索
            // 
            this.cButton検索.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cButton検索.BackColorSaved = System.Drawing.Color.Empty;
            this.cButton検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton検索.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.cButton検索.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cButton検索.Location = new System.Drawing.Point(732, 182);
            this.cButton検索.Name = "cButton検索";
            this.cButton検索.Size = new System.Drawing.Size(101, 44);
            this.cButton検索.TabIndex = 67;
            this.cButton検索.Text = "検索";
            this.cButton検索.UseVisualStyleBackColor = false;
            this.cButton検索.Click += new System.EventHandler(this.cButton検索_Click);
            // 
            // userControl売上伝票
            // 
            this.userControl売上伝票.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.userControl売上伝票.Location = new System.Drawing.Point(-51, 259);
            this.userControl売上伝票.Name = "userControl売上伝票";
            this.userControl売上伝票.Size = new System.Drawing.Size(845, 645);
            this.userControl売上伝票.TabIndex = 55;
            this.userControl売上伝票.Visible = false;
            this.userControl売上伝票.売上ID = 1;
            // 
            // dgvPager売上一覧
            // 
            this.dgvPager売上一覧.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPager売上一覧.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPager売上一覧.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPager売上一覧.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.dgvPager売上一覧.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPager売上一覧.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPager売上一覧.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPager売上一覧.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPager売上一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPager売上一覧.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPager売上一覧.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPager売上一覧.EnableHeadersVisualStyles = false;
            this.dgvPager売上一覧.Location = new System.Drawing.Point(0, 232);
            this.dgvPager売上一覧.MultiSelect = false;
            this.dgvPager売上一覧.Name = "dgvPager売上一覧";
            this.dgvPager売上一覧.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPager売上一覧.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPager売上一覧.RowHeadersVisible = false;
            this.dgvPager売上一覧.RowTemplate.Height = 36;
            this.dgvPager売上一覧.RowTemplate.ReadOnly = true;
            this.dgvPager売上一覧.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPager売上一覧.Size = new System.Drawing.Size(845, 461);
            this.dgvPager売上一覧.TabIndex = 36;
            this.dgvPager売上一覧.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPager売上一覧_CellDoubleClick);
            this.dgvPager売上一覧.SizeChanged += new System.EventHandler(this.dgvPager売上一覧_SizeChanged);
            // 
            // userControl得意先検索
            // 
            this.userControl得意先検索.Location = new System.Drawing.Point(223, 93);
            this.userControl得意先検索.Name = "userControl得意先検索";
            this.userControl得意先検索.Size = new System.Drawing.Size(514, 331);
            this.userControl得意先検索.TabIndex = 62;
            this.userControl得意先検索.Visible = false;
            this.userControl得意先検索.得意先CD = null;
            // 
            // userControl社員検索
            // 
            this.userControl社員検索.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.userControl社員検索.Location = new System.Drawing.Point(363, 148);
            this.userControl社員検索.Name = "userControl社員検索";
            this.userControl社員検索.Size = new System.Drawing.Size(284, 262);
            this.userControl社員検索.TabIndex = 65;
            this.userControl社員検索.Visible = false;
            this.userControl社員検索.社員番号 = null;
            // 
            // userControl社員入力
            // 
            this.userControl社員入力.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.userControl社員入力.Location = new System.Drawing.Point(189, 148);
            m社員1.ID = -1;
            m社員1.社員名 = "";
            m社員1.社員番号 = "";
            this.userControl社員入力.M社員 = m社員1;
            this.userControl社員入力.Name = "userControl社員入力";
            this.userControl社員入力.ReadOnly社員番号 = false;
            this.userControl社員入力.Size = new System.Drawing.Size(258, 78);
            this.userControl社員入力.TabIndex = 63;
            this.userControl社員入力.userControl社員検索 = null;
            // 
            // userControl得意先入力
            // 
            this.userControl得意先入力.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.userControl得意先入力.Location = new System.Drawing.Point(189, 55);
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
            this.userControl得意先入力.TabIndex = 60;
            this.userControl得意先入力.userControl得意先検索 = null;
            // 
            // ucPageControl
            // 
            this.ucPageControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.ucPageControl.CurrentCount = 0;
            this.ucPageControl.dgvPager = null;
            this.ucPageControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPageControl.Location = new System.Drawing.Point(0, 694);
            this.ucPageControl.Name = "ucPageControl";
            this.ucPageControl.RowCount = 0;
            this.ucPageControl.Size = new System.Drawing.Size(845, 35);
            this.ucPageControl.TabIndex = 68;
            // 
            // Uc売上一覧
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.Controls.Add(this.ucPageControl);
            this.Controls.Add(this.cButton検索);
            this.Controls.Add(this.userControl売上伝票);
            this.Controls.Add(this.dgvPager売上一覧);
            this.Controls.Add(this.userControl得意先検索);
            this.Controls.Add(this.userControl社員検索);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userControl社員入力);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userControl得意先入力);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp期間終了);
            this.Controls.Add(this.dtp期間開始);
            this.Name = "Uc売上一覧";
            this.Size = new System.Drawing.Size(845, 729);
            this.Load += new System.EventHandler(this.UserControl売上日別売上一覧_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPager売上一覧)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtp期間終了;
        private System.Windows.Forms.DateTimePicker dtp期間開始;
        private Uc売上伝票 userControl売上伝票;
        private System.Windows.Forms.Label label1;
        private 共通UI.Uc得意先入力 userControl得意先入力;
        private System.Windows.Forms.Label label3;
        private 共通UI.Uc得意先検索 userControl得意先検索;
        private 共通UI.Uc社員入力 userControl社員入力;
        private System.Windows.Forms.Label label2;
        private 共通UI.Uc社員検索 userControl社員検索;
        private 共通UI.DgvPager dgvPager売上一覧;
        private 共通UI.CButton cButton検索;
        private 共通UI.UcPageControl ucPageControl;
    }
}
