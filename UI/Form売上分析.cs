using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using テストDB.Models;
using テストDB.ViewModel;

namespace テストDB.UI
{
    public partial class Form売上分析 : Form
    {
        private ViewModel売上 vm売上;

        // ----------------------------------------------------------------
        // 期間のモード
        // ----------------------------------------------------------------
        enum Mode期間
        {
            本日,
            過去7日,
            過去30日,
            カスタム
        }

        private Mode期間 _mode期間;

        private Mode期間 mode期間
        {
            get { return _mode期間; }
            set
            {
                _mode期間 = value;

                switch (_mode期間)
                {
                    case Mode期間.本日:
                        dtp期間開始.Value = DateTime.Today;
                        dtp期間終了.Value = DateTime.Today;

                        ClearSelectedButton();
                        this.button期間本日.ForeColor = Color.White;

                        DataLoad();
                        SetDateMenuButtonsUI();
                        break;

                    case Mode期間.過去7日:
                        dtp期間開始.Value = DateTime.Today.AddDays(-7);
                        dtp期間終了.Value = DateTime.Today;

                        ClearSelectedButton();
                        this.button過去7日.ForeColor = Color.White;

                        DataLoad();
                        SetDateMenuButtonsUI();
                        break;

                    case Mode期間.過去30日:
                        dtp期間開始.Value = DateTime.Today.AddDays(-30);
                        dtp期間終了.Value = DateTime.Today;

                        ClearSelectedButton();
                        this.button過去30日.ForeColor = Color.White;

                        DataLoad();
                        SetDateMenuButtonsUI();
                        break;

                    case Mode期間.カスタム:
                        dtp期間開始.Enabled = true;
                        dtp期間終了.Enabled = true;

                        ClearSelectedButton();
                        this.button期間カスタム.ForeColor = Color.White;

                        button期間検索.Visible = true;
                        break;
                }
            }
        }

        private void ClearSelectedButton()
        {
            this.button期間カスタム.ForeColor = Color.FromArgb(124, 141, 181);
            this.button期間本日.ForeColor = Color.FromArgb(124, 141, 181);
            this.button過去7日.ForeColor = Color.FromArgb(124, 141, 181);
            this.button過去30日.ForeColor = Color.FromArgb(124, 141, 181);
        }


        // ----------------------------------------------------------------
        // 選択イベント
        // ----------------------------------------------------------------
        // 親へ選択した売上日をデリゲート
        public delegate void On売上日SelectedEventHandler(On売上日SelectedEventArgs e);
        public event On売上日SelectedEventHandler On売上日Selected;
        public class On売上日SelectedEventArgs : EventArgs
        {
            public DateTime 売上日;
        }


        // 親へ選択した商品をデリゲート
        public delegate void On商品SelectedEventHandler(On商品SelectedEventArgs e);
        public event On商品SelectedEventHandler On商品Selected;
        public class On商品SelectedEventArgs : EventArgs
        {
            public DateTime 期間開始;
            public DateTime 期間終了;
            public string 商品名;
        }

        // 親へ選択した得意先をデリゲート
        public delegate void On得意先SelectedEventHandler(On得意先SelectedEventArgs e);
        public event On得意先SelectedEventHandler On得意先Selected;
        public class On得意先SelectedEventArgs : EventArgs
        {
            public DateTime 期間開始;
            public DateTime 期間終了;
            public string 得意先名;
        }


        // ----------------------------------------------------------------
        // コンストラクタ
        // ----------------------------------------------------------------
        public Form売上分析()
        {
            InitializeComponent();

        }

        private void Form売上分析_Load(object sender, EventArgs e)
        {
            // 初期表示 過去7日
            this.mode期間 = Mode期間.過去7日;

            DataLoad();
        }

        // ----------------------------------------------------------------
        // データ読み込み
        // ----------------------------------------------------------------
        private async void DataLoad()
        {
            if (DesignMode) return;

            // ロード中
            ShowLoading();

            vm売上 = new ViewModel売上();

            // 非同期でデータ取得
            await Task.Run(() =>
            {
                vm売上.Load売上分析(dtp期間開始.Value.Date, dtp期間終了.Value.Date);
            });

            this.label取引件数.Text = vm売上.取引件数.ToString("#,##0 件");

            int 売上高100万円 = vm売上.売上高 / 1000;
            this.label売上高.Text = 売上高100万円.ToString("#,##0");

            int 粗利益100万円 = vm売上.粗利益 / 1000;
            this.label粗利益.Text = 粗利益100万円.ToString("#,##0");

            chart売上高.DataSource = vm売上.売上高lists;
            chart売上高.Series[0].XValueMember = "売上日";
            chart売上高.Series[0].YValueMembers = "売上高";
            chart売上高.Series[0].XValueType = ChartValueType.DateTime;
            chart売上高.DataBind();
            chart売上高.ChartAreas[0].AxisY.LabelStyle.Format = "{#,##0,}";
            chart売上高.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd";

            chart売上上位商品.DataSource = vm売上.売上上位商品lists;
            chart売上上位商品.Series[0].XValueMember = "商品名";
            chart売上上位商品.Series[0].YValueMembers = "売上高";
            chart売上上位商品.DataBind();

            chart売上上位得意先.DataSource = vm売上.売上上位得意先list;
            chart売上上位得意先.Series[0].XValueMember = "得意先名";
            chart売上上位得意先.Series[0].YValueMembers = "売上高";
            chart売上上位得意先.DataBind();

            // ロード終了
            OnLoaded();

        }

        // ロード中
        private void ShowLoading()
        {
            this.ucロード中.Visible = true;
            this.ucロード中.BringToFront();
        }

        private void OnLoaded()
        {
            this.ucロード中.Visible = false;
        }


        // ----------------------------------------------------------------
        // 期間 指定
        // ----------------------------------------------------------------
        private void button期間カスタム_Click(object sender, EventArgs e)
        {
            this.mode期間 = Mode期間.カスタム;
        }

        private void button期間本日_Click(object sender, EventArgs e)
        {
            this.mode期間 = Mode期間.本日;
        }

        private void button過去7日_Click(object sender, EventArgs e)
        {
            this.mode期間 = Mode期間.過去7日;
        }

        private void button過去30日_Click(object sender, EventArgs e)
        {
            this.mode期間 = Mode期間.過去30日;
        }

        private void button期間検索_Click(object sender, EventArgs e)
        {
            DataLoad();
            SetDateMenuButtonsUI();
        }

        private void SetDateMenuButtonsUI()
        {
            dtp期間開始.Enabled = false;
            dtp期間終了.Enabled = false;
            button期間検索.Visible = false;
        }


        // ----------------------------------------------------------------
        // グラフのダブルクリック
        // ----------------------------------------------------------------
        private void chart売上高_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            var result = chart売上高.HitTest(((MouseEventArgs)e).X, ((MouseEventArgs)e).Y);

            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                var selectedRow = chart売上高.Series[0].Points[result.PointIndex];

                var arg = new On売上日SelectedEventArgs
                {
                    売上日 = DateTime.FromOADate(selectedRow.XValue)
                };

                On売上日Selected(arg);
            }
        }

        // ----------------------------------------------------------------
        // グラフのダブルクリック
        // ----------------------------------------------------------------
        private void chart売上上位商品_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            var result = chart売上上位商品.HitTest(e.X, e.Y);

            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                var selectedRow = chart売上上位商品.Series[0].Points[result.PointIndex];
                var 商品名 = selectedRow.AxisLabel;

                var arg = new On商品SelectedEventArgs
                {
                    期間開始 = dtp期間開始.Value,
                    期間終了 = dtp期間終了.Value,
                    商品名 = 商品名
                };

                On商品Selected(arg);
            }
        }

        // ----------------------------------------------------------------
        // グラフのダブルクリック
        // ----------------------------------------------------------------
        private void chart売上上位得意先_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            var result = chart売上上位得意先.HitTest(e.X, e.Y);

            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                var selectedRow = chart売上上位得意先.Series[0].Points[result.PointIndex];
                var 得意先名 = selectedRow.AxisLabel;

                var arg = new On得意先SelectedEventArgs
                {
                    期間開始 = dtp期間開始.Value,
                    期間終了 = dtp期間終了.Value,
                    得意先名 = 得意先名
                };

                On得意先Selected(arg);
            }
        }
    }
}
