namespace テストDB.UI
{
    partial class Form売上分析
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form売上分析));
            this.button期間検索 = new System.Windows.Forms.Button();
            this.dtp期間開始 = new 共通UI.CDateTimePicker();
            this.chart売上上位得意先 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart売上上位商品 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart売上高 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanelG2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelG1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label粗利益 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label取引件数 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label売上高 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel件数 = new System.Windows.Forms.TableLayoutPanel();
            this.button過去30日 = new System.Windows.Forms.Button();
            this.button過去7日 = new System.Windows.Forms.Button();
            this.button期間本日 = new System.Windows.Forms.Button();
            this.button期間カスタム = new System.Windows.Forms.Button();
            this.dtp期間終了 = new 共通UI.CDateTimePicker();
            this.ucロード中 = new 共通UI.Ucロード中();
            ((System.ComponentModel.ISupportInitialize)(this.chart売上上位得意先)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart売上上位商品)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart売上高)).BeginInit();
            this.tableLayoutPanelG2.SuspendLayout();
            this.tableLayoutPanelG1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel件数.SuspendLayout();
            this.SuspendLayout();
            // 
            // button期間検索
            // 
            this.button期間検索.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.button期間検索.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button期間検索.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.button期間検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button期間検索.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button期間検索.Image = global::テストDB.Properties.Resources.虫眼鏡のアイコン;
            this.button期間検索.Location = new System.Drawing.Point(332, 2);
            this.button期間検索.Margin = new System.Windows.Forms.Padding(10);
            this.button期間検索.Name = "button期間検索";
            this.button期間検索.Size = new System.Drawing.Size(35, 35);
            this.button期間検索.TabIndex = 33;
            this.button期間検索.UseVisualStyleBackColor = false;
            this.button期間検索.Click += new System.EventHandler(this.button期間検索_Click);
            // 
            // dtp期間開始
            // 
            this.dtp期間開始.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtp期間開始.CustomFormat = "yyyy/MM/dd";
            this.dtp期間開始.Enabled = false;
            this.dtp期間開始.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp期間開始.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp期間開始.Location = new System.Drawing.Point(17, 2);
            this.dtp期間開始.Margin = new System.Windows.Forms.Padding(10);
            this.dtp期間開始.Name = "dtp期間開始";
            this.dtp期間開始.Size = new System.Drawing.Size(142, 31);
            this.dtp期間開始.TabIndex = 30;
            // 
            // chart売上上位得意先
            // 
            this.chart売上上位得意先.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsReversed = true;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX.MajorTickMark.LineWidth = 0;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.Format = "{#,##0,}";
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisY.MajorTickMark.LineWidth = 0;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            chartArea1.BorderColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chart売上上位得意先.ChartAreas.Add(chartArea1);
            this.chart売上上位得意先.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart売上上位得意先.Location = new System.Drawing.Point(429, 10);
            this.chart売上上位得意先.Margin = new System.Windows.Forms.Padding(10);
            this.chart売上上位得意先.Name = "chart売上上位得意先";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series1.BackSecondaryColor = System.Drawing.Color.DarkGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Color = System.Drawing.Color.GreenYellow;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.LabelFormat = "{#,##0,}";
            series1.Name = "Series1";
            this.chart売上上位得意先.Series.Add(series1);
            this.chart売上上位得意先.Size = new System.Drawing.Size(400, 265);
            this.chart売上上位得意先.TabIndex = 29;
            this.chart売上上位得意先.Text = "chartTopProducts";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            title1.Name = "Title1";
            title1.Text = "売上上位 得意先５件";
            this.chart売上上位得意先.Titles.Add(title1);
            this.chart売上上位得意先.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.chart売上上位得意先_MouseDoubleClick);
            // 
            // chart売上上位商品
            // 
            this.chart売上上位商品.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.IsReversed = true;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisX.LineWidth = 0;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisX.MajorGrid.LineWidth = 0;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisX.MajorTickMark.Size = 0F;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisY.LabelStyle.Format = "{#,##0,}";
            chartArea2.AxisY.LineWidth = 0;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.MajorTickMark.Size = 0F;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea2.Name = "ChartArea1";
            this.chart売上上位商品.ChartAreas.Add(chartArea2);
            this.chart売上上位商品.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart売上上位商品.Location = new System.Drawing.Point(10, 10);
            this.chart売上上位商品.Margin = new System.Windows.Forms.Padding(10);
            this.chart売上上位商品.Name = "chart売上上位商品";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series2.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Color = System.Drawing.Color.LightSeaGreen;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.LabelFormat = "{#,##0,}";
            series2.Name = "Series1";
            this.chart売上上位商品.Series.Add(series2);
            this.chart売上上位商品.Size = new System.Drawing.Size(399, 265);
            this.chart売上上位商品.TabIndex = 28;
            this.chart売上上位商品.Text = "chart1";
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            title2.Name = "Title1";
            title2.Text = "売上上位 商品５種";
            this.chart売上上位商品.Titles.Add(title2);
            this.chart売上上位商品.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.chart売上上位商品_MouseDoubleClick);
            // 
            // chart売上高
            // 
            this.chart売上高.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.AxisX.LineWidth = 0;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.AxisX.MajorGrid.LineWidth = 0;
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.AxisX.MajorTickMark.Size = 0F;
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.AxisY.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.AxisY.LineWidth = 0;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(137)))), ((int)(((byte)(163)))));
            chartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(137)))), ((int)(((byte)(163)))));
            chartArea3.AxisY.MajorTickMark.Size = 0F;
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.TitleForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea3.Name = "ChartArea1";
            this.chart売上高.ChartAreas.Add(chartArea3);
            this.chart売上高.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart売上高.Location = new System.Drawing.Point(10, 10);
            this.chart売上高.Margin = new System.Windows.Forms.Padding(10);
            this.chart売上高.Name = "chart売上高";
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series3.BackSecondaryColor = System.Drawing.Color.Violet;
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            series3.IsValueShownAsLabel = true;
            series3.LabelForeColor = System.Drawing.Color.WhiteSmoke;
            series3.LabelFormat = "{#,##0,}";
            series3.Name = "Series1";
            this.chart売上高.Series.Add(series3);
            this.chart売上高.Size = new System.Drawing.Size(825, 270);
            this.chart売上高.TabIndex = 19;
            this.chart売上高.Text = "chartGrossRevenue";
            title3.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            title3.Name = "Title1";
            title3.Text = "売上高(千円)";
            this.chart売上高.Titles.Add(title3);
            this.chart売上高.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.chart売上高_MouseDoubleClick);
            // 
            // tableLayoutPanelG2
            // 
            this.tableLayoutPanelG2.ColumnCount = 2;
            this.tableLayoutPanelG2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelG2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelG2.Controls.Add(this.chart売上上位得意先, 0, 0);
            this.tableLayoutPanelG2.Controls.Add(this.chart売上上位商品, 0, 0);
            this.tableLayoutPanelG2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelG2.Location = new System.Drawing.Point(3, 293);
            this.tableLayoutPanelG2.Name = "tableLayoutPanelG2";
            this.tableLayoutPanelG2.RowCount = 1;
            this.tableLayoutPanelG2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelG2.Size = new System.Drawing.Size(839, 285);
            this.tableLayoutPanelG2.TabIndex = 20;
            // 
            // tableLayoutPanelG1
            // 
            this.tableLayoutPanelG1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelG1.ColumnCount = 1;
            this.tableLayoutPanelG1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelG1.Controls.Add(this.chart売上高, 0, 0);
            this.tableLayoutPanelG1.Controls.Add(this.tableLayoutPanelG2, 0, 1);
            this.tableLayoutPanelG1.Location = new System.Drawing.Point(0, 145);
            this.tableLayoutPanelG1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanelG1.Name = "tableLayoutPanelG1";
            this.tableLayoutPanelG1.RowCount = 2;
            this.tableLayoutPanelG1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelG1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelG1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelG1.Size = new System.Drawing.Size(845, 581);
            this.tableLayoutPanelG1.TabIndex = 38;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(9, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label粗利益
            // 
            this.label粗利益.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label粗利益.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label粗利益.Location = new System.Drawing.Point(27, 45);
            this.label粗利益.Name = "label粗利益";
            this.label粗利益.Size = new System.Drawing.Size(199, 25);
            this.label粗利益.TabIndex = 1;
            this.label粗利益.Text = "100000";
            this.label粗利益.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(173)))));
            this.label12.Location = new System.Drawing.Point(68, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "粗利益(千円)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label取引件数
            // 
            this.label取引件数.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label取引件数.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label取引件数.Location = new System.Drawing.Point(29, 45);
            this.label取引件数.Name = "label取引件数";
            this.label取引件数.Size = new System.Drawing.Size(198, 25);
            this.label取引件数.TabIndex = 1;
            this.label取引件数.Text = "100000";
            this.label取引件数.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label粗利益);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(572, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 80);
            this.panel3.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            this.label3.Location = new System.Drawing.Point(77, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "取引件数";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label取引件数);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 80);
            this.panel1.TabIndex = 28;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::テストDB.Properties.Resources.売上高;
            this.pictureBox2.Location = new System.Drawing.Point(12, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label売上高
            // 
            this.label売上高.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label売上高.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label売上高.Location = new System.Drawing.Point(31, 45);
            this.label売上高.Name = "label売上高";
            this.label売上高.Size = new System.Drawing.Size(196, 25);
            this.label売上高.TabIndex = 1;
            this.label売上高.Text = "100000";
            this.label売上高.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(62, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "売上高(千円)";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label売上高);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(291, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 80);
            this.panel2.TabIndex = 29;
            // 
            // tableLayoutPanel件数
            // 
            this.tableLayoutPanel件数.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel件数.ColumnCount = 3;
            this.tableLayoutPanel件数.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel件数.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel件数.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel件数.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel件数.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel件数.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel件数.Location = new System.Drawing.Point(0, 39);
            this.tableLayoutPanel件数.Name = "tableLayoutPanel件数";
            this.tableLayoutPanel件数.RowCount = 1;
            this.tableLayoutPanel件数.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel件数.Size = new System.Drawing.Size(845, 100);
            this.tableLayoutPanel件数.TabIndex = 37;
            // 
            // button過去30日
            // 
            this.button過去30日.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.button過去30日.FlatAppearance.BorderSize = 2;
            this.button過去30日.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button過去30日.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button過去30日.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button過去30日.Location = new System.Drawing.Point(723, 2);
            this.button過去30日.Margin = new System.Windows.Forms.Padding(5);
            this.button過去30日.Name = "button過去30日";
            this.button過去30日.Size = new System.Drawing.Size(114, 35);
            this.button過去30日.TabIndex = 36;
            this.button過去30日.Text = "過去30日";
            this.button過去30日.UseVisualStyleBackColor = false;
            this.button過去30日.Click += new System.EventHandler(this.button過去30日_Click);
            // 
            // button過去7日
            // 
            this.button過去7日.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.button過去7日.FlatAppearance.BorderSize = 2;
            this.button過去7日.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button過去7日.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button過去7日.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.button過去7日.Location = new System.Drawing.Point(609, 2);
            this.button過去7日.Margin = new System.Windows.Forms.Padding(5);
            this.button過去7日.Name = "button過去7日";
            this.button過去7日.Size = new System.Drawing.Size(114, 35);
            this.button過去7日.TabIndex = 35;
            this.button過去7日.Text = "過去7日";
            this.button過去7日.UseVisualStyleBackColor = false;
            this.button過去7日.Click += new System.EventHandler(this.button過去7日_Click);
            // 
            // button期間本日
            // 
            this.button期間本日.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.button期間本日.FlatAppearance.BorderSize = 2;
            this.button期間本日.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button期間本日.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button期間本日.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.button期間本日.Location = new System.Drawing.Point(496, 2);
            this.button期間本日.Margin = new System.Windows.Forms.Padding(5);
            this.button期間本日.Name = "button期間本日";
            this.button期間本日.Size = new System.Drawing.Size(114, 35);
            this.button期間本日.TabIndex = 34;
            this.button期間本日.Text = "本日";
            this.button期間本日.UseVisualStyleBackColor = false;
            this.button期間本日.Click += new System.EventHandler(this.button期間本日_Click);
            // 
            // button期間カスタム
            // 
            this.button期間カスタム.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            this.button期間カスタム.FlatAppearance.BorderSize = 2;
            this.button期間カスタム.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button期間カスタム.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button期間カスタム.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.button期間カスタム.Location = new System.Drawing.Point(383, 2);
            this.button期間カスタム.Margin = new System.Windows.Forms.Padding(5);
            this.button期間カスタム.Name = "button期間カスタム";
            this.button期間カスタム.Size = new System.Drawing.Size(114, 35);
            this.button期間カスタム.TabIndex = 32;
            this.button期間カスタム.Text = "カスタム";
            this.button期間カスタム.UseVisualStyleBackColor = false;
            this.button期間カスタム.Click += new System.EventHandler(this.button期間カスタム_Click);
            // 
            // dtp期間終了
            // 
            this.dtp期間終了.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtp期間終了.CustomFormat = "yyyy/MM/dd";
            this.dtp期間終了.Enabled = false;
            this.dtp期間終了.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp期間終了.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp期間終了.Location = new System.Drawing.Point(175, 2);
            this.dtp期間終了.Margin = new System.Windows.Forms.Padding(10);
            this.dtp期間終了.Name = "dtp期間終了";
            this.dtp期間終了.Size = new System.Drawing.Size(142, 31);
            this.dtp期間終了.TabIndex = 31;
            // 
            // ucロード中
            // 
            this.ucロード中.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucロード中.BackColor = System.Drawing.Color.Black;
            this.ucロード中.Location = new System.Drawing.Point(245, 300);
            this.ucロード中.Name = "ucロード中";
            this.ucロード中.Size = new System.Drawing.Size(340, 125);
            this.ucロード中.TabIndex = 39;
            // 
            // Form売上分析
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(845, 729);
            this.Controls.Add(this.ucロード中);
            this.Controls.Add(this.button期間検索);
            this.Controls.Add(this.dtp期間開始);
            this.Controls.Add(this.tableLayoutPanelG1);
            this.Controls.Add(this.tableLayoutPanel件数);
            this.Controls.Add(this.button過去30日);
            this.Controls.Add(this.button過去7日);
            this.Controls.Add(this.button期間本日);
            this.Controls.Add(this.button期間カスタム);
            this.Controls.Add(this.dtp期間終了);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form売上分析";
            this.Text = "Form売上分析";
            this.Load += new System.EventHandler(this.Form売上分析_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart売上上位得意先)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart売上上位商品)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart売上高)).EndInit();
            this.tableLayoutPanelG2.ResumeLayout(false);
            this.tableLayoutPanelG1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel件数.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button期間検索;
        private 共通UI.CDateTimePicker dtp期間開始;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart売上上位得意先;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart売上上位商品;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart売上高;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelG2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelG1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label粗利益;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label取引件数;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label売上高;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel件数;
        private System.Windows.Forms.Button button過去30日;
        private System.Windows.Forms.Button button過去7日;
        private System.Windows.Forms.Button button期間本日;
        private System.Windows.Forms.Button button期間カスタム;
        private 共通UI.CDateTimePicker dtp期間終了;
        private 共通UI.Ucロード中 ucロード中;
    }
}