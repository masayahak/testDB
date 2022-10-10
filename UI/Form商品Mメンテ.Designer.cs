﻿namespace テストDB.UI
{
    partial class Form商品Mメンテ
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
            this.components = new System.ComponentModel.Container();
            this.panel詳細 = new System.Windows.Forms.Panel();
            this.textBox仕入単価 = new 共通UI.CTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox販売単価 = new 共通UI.CTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLineRight = new System.Windows.Forms.Label();
            this.labelLineBottom = new System.Windows.Forms.Label();
            this.labelLineLeft = new System.Windows.Forms.Label();
            this.labelLineTop = new System.Windows.Forms.Label();
            this.textBox商品名 = new 共通UI.CTextBox();
            this.textBoxバーコード = new 共通UI.CTextBox();
            this.textBox商品ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucCRUD = new 共通UI.UcCRUD();
            this.ucロード中 = new 共通UI.Ucロード中();
            this.ucGridPager = new 共通UI.UcGridPager();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel詳細.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel詳細
            // 
            this.panel詳細.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel詳細.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.panel詳細.Controls.Add(this.textBox仕入単価);
            this.panel詳細.Controls.Add(this.label4);
            this.panel詳細.Controls.Add(this.textBox販売単価);
            this.panel詳細.Controls.Add(this.label3);
            this.panel詳細.Controls.Add(this.labelLineRight);
            this.panel詳細.Controls.Add(this.labelLineBottom);
            this.panel詳細.Controls.Add(this.labelLineLeft);
            this.panel詳細.Controls.Add(this.labelLineTop);
            this.panel詳細.Controls.Add(this.textBox商品名);
            this.panel詳細.Controls.Add(this.textBoxバーコード);
            this.panel詳細.Controls.Add(this.textBox商品ID);
            this.panel詳細.Controls.Add(this.label2);
            this.panel詳細.Controls.Add(this.label1);
            this.panel詳細.Location = new System.Drawing.Point(153, 122);
            this.panel詳細.Name = "panel詳細";
            this.panel詳細.Size = new System.Drawing.Size(473, 406);
            this.panel詳細.TabIndex = 40;
            // 
            // textBox仕入単価
            // 
            this.textBox仕入単価.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox仕入単価.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBox仕入単価.Location = new System.Drawing.Point(123, 215);
            this.textBox仕入単価.MaxLength = 3;
            this.textBox仕入単価.Name = "textBox仕入単価";
            this.textBox仕入単価.ReadOnly = true;
            this.textBox仕入単価.Size = new System.Drawing.Size(47, 31);
            this.textBox仕入単価.TabIndex = 41;
            this.textBox仕入単価.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(11, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "仕入単価";
            // 
            // textBox販売単価
            // 
            this.textBox販売単価.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox販売単価.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBox販売単価.Location = new System.Drawing.Point(123, 165);
            this.textBox販売単価.MaxLength = 3;
            this.textBox販売単価.Name = "textBox販売単価";
            this.textBox販売単価.ReadOnly = true;
            this.textBox販売単価.Size = new System.Drawing.Size(47, 31);
            this.textBox販売単価.TabIndex = 39;
            this.textBox販売単価.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(11, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "販売単価";
            // 
            // labelLineRight
            // 
            this.labelLineRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLineRight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelLineRight.Location = new System.Drawing.Point(468, 0);
            this.labelLineRight.Name = "labelLineRight";
            this.labelLineRight.Size = new System.Drawing.Size(5, 406);
            this.labelLineRight.TabIndex = 37;
            // 
            // labelLineBottom
            // 
            this.labelLineBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLineBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelLineBottom.Location = new System.Drawing.Point(0, 401);
            this.labelLineBottom.Name = "labelLineBottom";
            this.labelLineBottom.Size = new System.Drawing.Size(473, 5);
            this.labelLineBottom.TabIndex = 36;
            // 
            // labelLineLeft
            // 
            this.labelLineLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLineLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelLineLeft.Location = new System.Drawing.Point(0, 0);
            this.labelLineLeft.Name = "labelLineLeft";
            this.labelLineLeft.Size = new System.Drawing.Size(5, 406);
            this.labelLineLeft.TabIndex = 35;
            // 
            // labelLineTop
            // 
            this.labelLineTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLineTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelLineTop.Location = new System.Drawing.Point(0, 0);
            this.labelLineTop.Name = "labelLineTop";
            this.labelLineTop.Size = new System.Drawing.Size(473, 5);
            this.labelLineTop.TabIndex = 34;
            // 
            // textBox商品名
            // 
            this.textBox商品名.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox商品名.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBox商品名.Location = new System.Drawing.Point(123, 118);
            this.textBox商品名.MaxLength = 256;
            this.textBox商品名.Name = "textBox商品名";
            this.textBox商品名.ReadOnly = true;
            this.textBox商品名.Size = new System.Drawing.Size(251, 31);
            this.textBox商品名.TabIndex = 33;
            // 
            // textBoxバーコード
            // 
            this.textBoxバーコード.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBoxバーコード.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBoxバーコード.Location = new System.Drawing.Point(123, 73);
            this.textBoxバーコード.MaxLength = 25;
            this.textBoxバーコード.Name = "textBoxバーコード";
            this.textBoxバーコード.ReadOnly = true;
            this.textBoxバーコード.Size = new System.Drawing.Size(168, 31);
            this.textBoxバーコード.TabIndex = 32;
            // 
            // textBox商品ID
            // 
            this.textBox商品ID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox商品ID.Location = new System.Drawing.Point(123, 20);
            this.textBox商品ID.Name = "textBox商品ID";
            this.textBox商品ID.ReadOnly = true;
            this.textBox商品ID.Size = new System.Drawing.Size(168, 31);
            this.textBox商品ID.TabIndex = 31;
            this.textBox商品ID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(11, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "商品名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(11, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "バーコード";
            // 
            // ucCRUD
            // 
            this.ucCRUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucCRUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(91)))), ((int)(((byte)(108)))));
            this.ucCRUD.Location = new System.Drawing.Point(716, 0);
            this.ucCRUD.Name = "ucCRUD";
            this.ucCRUD.Size = new System.Drawing.Size(127, 729);
            this.ucCRUD.TabIndex = 42;
            // 
            // ucロード中
            // 
            this.ucロード中.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucロード中.BackColor = System.Drawing.Color.Black;
            this.ucロード中.Location = new System.Drawing.Point(253, 302);
            this.ucロード中.Name = "ucロード中";
            this.ucロード中.Size = new System.Drawing.Size(340, 125);
            this.ucロード中.TabIndex = 39;
            // 
            // ucGridPager
            // 
            this.ucGridPager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucGridPager.Location = new System.Drawing.Point(1, 0);
            this.ucGridPager.Name = "ucGridPager";
            this.ucGridPager.RowsInPage = 10000;
            this.ucGridPager.Size = new System.Drawing.Size(715, 729);
            this.ucGridPager.TabIndex = 41;
            this.ucGridPager.SizeChanged += new System.EventHandler(this.ucGridPager_SizeChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form商品Mメンテ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(845, 729);
            this.Controls.Add(this.panel詳細);
            this.Controls.Add(this.ucCRUD);
            this.Controls.Add(this.ucロード中);
            this.Controls.Add(this.ucGridPager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form商品Mメンテ";
            this.Text = "Form商品Mメンテ";
            this.Load += new System.EventHandler(this.Form_Load);
            this.panel詳細.ResumeLayout(false);
            this.panel詳細.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel詳細;
        private System.Windows.Forms.Label labelLineRight;
        private System.Windows.Forms.Label labelLineBottom;
        private System.Windows.Forms.Label labelLineLeft;
        private System.Windows.Forms.Label labelLineTop;
        private 共通UI.CTextBox textBox商品名;
        private 共通UI.CTextBox textBoxバーコード;
        private System.Windows.Forms.TextBox textBox商品ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private 共通UI.UcCRUD ucCRUD;
        private 共通UI.Ucロード中 ucロード中;
        private 共通UI.UcGridPager ucGridPager;
        private 共通UI.CTextBox textBox仕入単価;
        private System.Windows.Forms.Label label4;
        private 共通UI.CTextBox textBox販売単価;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}