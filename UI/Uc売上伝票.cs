using System;
using System.Linq;
using System.Windows.Forms;
using テストDB.Models;
using テストDB.ViewModel;

namespace テストDB.UI
{
    public partial class Uc売上伝票 : UserControl
    {
        private ViewModel売上 vm売上;

        private int _売上ID = 1;
        public int 売上ID
        {
            get { return _売上ID; }
            set
            {
                _売上ID = value;
            }
        }

        public Uc売上伝票()
        {
            InitializeComponent();
        }

        private class 売上明細list
        {
            public string バーコード { get; set; }
            public string 商品名 { get; set; }
            public int 販売単価 { get; set; }
            public int 販売数量 { get; set; }
            public int 明細売上高 { get; set; }
            public int 明細消費税額 { get; set; }
        }

        enum 売上明細list_Col
        {
            バーコード = 0,
            商品名 = 1,
            販売単価 = 2,
            販売数量 = 3,
            明細売上高 = 4,
            明細消費税額 = 5,
        }


        public void LoadData()
        {
            if (DesignMode) return;

            vm売上 = new ViewModel売上();
            vm売上.LoadData(売上ID);

            var 売上 = vm売上.list売上[0];

            this.textBox伝票NO.Text = 売上.ID.ToString();
            this.textBox得意先CD.Text = 売上.得意先CD.ToString();
            this.textBox得意先名.Text = 売上.得意先名.ToString();
            this.textBox担当社員番号.Text = 売上.担当社員番号.ToString();
            this.textBox担当社員名.Text = 売上.担当社員名.ToString();
            this.textBox売上日.Text = 売上.売上日.ToString("yyyy/MM/dd");
            this.textBox売上高.Text = 売上.売上高.ToString("C");
            this.textBox消費税額.Text = 売上.消費税額.ToString("C");
            this.textBox仕入高.Text = 売上.仕入高.ToString("C");

            var 売上明細lists = vm売上.list売上明細
                            .Select(it => new 売上明細list
                            {
                                バーコード = it.バーコード,
                                商品名 = it.商品名,
                                販売単価 = it.販売単価,
                                販売数量 = it.販売数量,
                                明細売上高 = it.明細売上高,
                                明細消費税額 = it.明細消費税額,
                            })
                            .ToArray()
                            ;

            this.dataGridView売上明細.DataSource = 売上明細lists;

            // 列幅の設定:
            dataGridView売上明細.Columns[(int)売上明細list_Col.バーコード].Visible = false;
            dataGridView売上明細.Columns[(int)売上明細list_Col.商品名].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView売上明細.Columns[(int)売上明細list_Col.販売単価].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView売上明細.Columns[(int)売上明細list_Col.販売数量].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView売上明細.Columns[(int)売上明細list_Col.明細売上高].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView売上明細.Columns[(int)売上明細list_Col.明細消費税額].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // 書式
            dataGridView売上明細.Columns[(int)売上明細list_Col.販売単価].DefaultCellStyle.Format = "@#,##0";
            dataGridView売上明細.Columns[(int)売上明細list_Col.販売数量].DefaultCellStyle.Format = "#,##0";
            dataGridView売上明細.Columns[(int)売上明細list_Col.明細売上高].DefaultCellStyle.Format = "C";
            dataGridView売上明細.Columns[(int)売上明細list_Col.明細消費税額].DefaultCellStyle.Format = "C";

            dataGridView売上明細.Columns[(int)売上明細list_Col.販売単価].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView売上明細.Columns[(int)売上明細list_Col.販売数量].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView売上明細.Columns[(int)売上明細list_Col.明細売上高].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView売上明細.Columns[(int)売上明細list_Col.明細消費税額].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // ヘッダー
            dataGridView売上明細.Columns[(int)売上明細list_Col.販売単価].HeaderText = "単価";
            dataGridView売上明細.Columns[(int)売上明細list_Col.販売数量].HeaderText = "数量";
            dataGridView売上明細.Columns[(int)売上明細list_Col.明細売上高].HeaderText = "売上高";
            dataGridView売上明細.Columns[(int)売上明細list_Col.明細消費税額].HeaderText = "消費税";
        }

        private void buttonｷｬﾝｾﾙ_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
