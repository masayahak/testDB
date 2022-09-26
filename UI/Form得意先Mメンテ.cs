using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using テストDB.Models;
using テストDB.ViewModel;
using static テストDB.共通UI.UcBasePager;
using static テストDB.共通UI.Uc社員検索;

namespace テストDB.UI
{
    public partial class Form得意先Mメンテ : Form
    {
        // ----------------------------------------------------------------
        // 表示する一覧の定義
        // ----------------------------------------------------------------
        public class ds得意先一覧
        {
            public int No { get; set; }
            public int ID { get; set; }
            public string 得意先CD { get; set; }
            public string 得意先名 { get; set; }
            public int 担当社員ID { get; set; }
            public string 担当社員番号 { get; set; }
            public string 担当社員名 { get; set; }
        }

        public enum ds得意先一覧_Col
        {
            No = 0,
            ID = 1,
            得意先CD = 2,
            得意先名 = 3,
            担当社員ID = 4,
            担当社員番号 = 5,
            担当社員名 = 6,
        }

        private ViewModel得意先 vm得意先;

        // ------------------------------------------------------------
        //  処理モード変更時
        // ------------------------------------------------------------
        private void ChangeMode_追加()
        {

            ds得意先一覧 newItem = new ds得意先一覧()
            {
                ID = -1,
                得意先CD = "",
                得意先名 = "",
                担当社員ID = -1,
                担当社員番号 = "",
                担当社員名 = "",
            };
            ShowDetail(newItem);

            this.textBox得意先CD.ReadOnly = false;
            this.textBox得意先名.ReadOnly = false;
            this.uc社員入力.ReadOnly社員番号 = false;

            panel詳細.BringToFront();
            ucPager.Enabled = false;
        }

        private void ChangeMode_修正()
        {
            ds得意先一覧 currentItem = (ds得意先一覧)ucPager.pagerDataGridView.SelectedRows[0].DataBoundItem;
            ShowDetail(currentItem);

            this.textBox得意先CD.ReadOnly = false;
            this.textBox得意先名.ReadOnly = false;
            this.uc社員入力.ReadOnly社員番号 = false;

            panel詳細.BringToFront();
            ucPager.Enabled = false;
        }

        private void ChangeMode_照会()
        {
            this.textBox得意先CD.ReadOnly = true;
            this.textBox得意先名.ReadOnly = true;
            this.uc社員入力.ReadOnly社員番号 = true;

            panel詳細.SendToBack();
            ucPager.Enabled = true;
        }

        private void ShowDetail(ds得意先一覧 得意先)
        {
            textBox得意先ID.Text = 得意先.ID.ToString();
            textBox得意先CD.Text = 得意先.得意先CD;
            textBox得意先名.Text = 得意先.得意先名;

            uc社員入力.M社員 = new M社員
            {
                ID = 得意先.担当社員ID,
                社員番号 = 得意先.担当社員番号,
                社員名 = 得意先.担当社員名,
            };
        }

        private void On社員番号_Selected(On社員番号SelectedEventArgs arg)
        {
            uc社員入力.M社員 = arg.m社員;
        }

        // ------------------------------------------------------------
        //  初期化
        // ------------------------------------------------------------
        public Form得意先Mメンテ()
        {
            InitializeComponent();

            ucCRUD.ChangeMode追加 += ChangeMode_追加;
            ucCRUD.ChangeMode修正 += ChangeMode_修正;
            ucCRUD.ChangeMode照会 += ChangeMode_照会;
            ucCRUD.ChangeMode_照会();

            ucCRUD.On削除Click += On削除Click;
            ucCRUD.On保存Click += On保存Click;
            ucCRUD.OnキャンセルClick += OnキャンセルClick;

            uc社員検索.Visible = false;
            uc社員検索.On社員番号Selected += On社員番号_Selected;

            // グリッドのフォーマットイベント
            this.ucPager.OnGridFormat += OnGrid_Format;

            // グリッドのダブルクリック
            this.ucPager.OnGridDoubleClick += OnGrid_DoubleClick;
        }
        // ------------------------------------------------------------
        // コントロール表示時に全データを読み込み
        //      ただし、デザインモードではデータを読み込まない
        // ------------------------------------------------------------
        private void Form得意先メンテ_Load(object sender, EventArgs e)
        {
            DataLoad();

        }

        private async void DataLoad()
        {
            if (DesignMode) return;

            // ロード中
            ShowLoading();

            // 非同期でデータ取得
            await Task.Run(() =>
            {
                vm得意先 = new ViewModel得意先();
            });

            var list = vm得意先.list得意先一覧
                .OrderBy(it => it.得意先CD)
                .Select((it, i) => new ds得意先一覧
                {
                    No = i + 1,
                    ID = it.ID,
                    得意先CD = it.得意先CD,
                    得意先名 = it.得意先名,
                    担当社員ID = it.担当社員ID,
                    担当社員番号 = it.担当社員番号,
                    担当社員名 = it.担当社員名,
                })
                .ToList()
                ;

            this.ucPager.RowsInPage = 100;
            this.ucPager.SetFullDatasource<ds得意先一覧>(list);
            this.ucPager.ShowPage();

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
        // グリッドの書式
        // ----------------------------------------------------------------
        // グリッドの書式設定
        private void OnGrid_Format()
        {
            DataGridView dg = this.ucPager.pagerDataGridView;

            dg.Columns[(int)ds得意先一覧_Col.ID].Visible = false;
            dg.Columns[(int)ds得意先一覧_Col.担当社員ID].Visible = false;

            ucPager_SizeChanged(this, null);
        }

        // ----------------------------------------------------------------
        // 一覧のサイズ変更
        // ----------------------------------------------------------------
        private void ucPager_SizeChanged(object sender, EventArgs e)
        {

            DataGridView dg = this.ucPager.pagerDataGridView;

            // データ0行ならなにもしない
            if (dg.RowCount == 0) return;

            dg.Columns[(int)ds得意先一覧_Col.得意先名].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            int ColWidthSum = 0;
            foreach (DataGridViewColumn column in dg.Columns)
            {
                ColWidthSum += column.Width;
            }

            if (dg.Width > ColWidthSum)
            {
                dg.Columns[(int)ds得意先一覧_Col.担当社員番号].Visible = true;

                dg.Columns[(int)ds得意先一覧_Col.得意先名].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                dg.Columns[(int)ds得意先一覧_Col.担当社員番号].Visible = false;

                dg.Columns[(int)ds得意先一覧_Col.得意先名].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        // ----------------------------------------------------------------
        // 一覧のダブルクリック
        // ----------------------------------------------------------------
        private void OnGrid_DoubleClick(OnGridDoubleClickArgs args)
        {
            // 修正モードへ
            ucCRUD.ChangeMode_修正();
        }

        // ------------------------------------------------------------
        // 保存ボタン
        // ------------------------------------------------------------
        private void On保存Click()
        {

            if (IsInputCheckError()) return;

            try
            {
                if (ucCRUD.状態 == 処理モード.状態.追加中)
                {
                    得意先Add();
                }
                else
                {
                    得意先Update();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("データベースに登録できませんでした。\r\n" + ex.Message,
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }


            // 追加 or 修正が終わったら照会モードへ
            ucCRUD.ChangeMode_照会();

            // データ再取得
            DataLoad();

        }

        // ------------------------------------------------------------
        // 入力情報のチェック
        // ------------------------------------------------------------
        private bool IsInputCheckError()
        {

            var 得意先CD = textBox得意先CD.Text;
            if (string.IsNullOrWhiteSpace(得意先CD))
            {
                MessageBox.Show("得意先CDは必須です。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return true;
            }

            var 得意先名 = textBox得意先名.Text;
            if (string.IsNullOrWhiteSpace(得意先名))
            {
                MessageBox.Show("得意先名は必須です。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return true;
            }

            if (uc社員入力.M社員.ID <= 0)
            {
                MessageBox.Show("担当者は必須です。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return true;
            }

            return false;
        }


        // ------------------------------------------------------------
        // DB更新
        // ------------------------------------------------------------
        private void 得意先Add()
        {

            var 追加得意先 = new M得意先
            {
                得意先CD = textBox得意先CD.Text,
                得意先名 = textBox得意先名.Text,
                担当社員ID = uc社員入力.M社員.ID,
            };

            var ID = vm得意先.Add(追加得意先);
        }

        private void 得意先Update()
        {
            var 更新得意先 = new M得意先
            {
                ID = int.Parse(textBox得意先ID.Text),
                得意先CD = textBox得意先CD.Text,
                得意先名 = textBox得意先名.Text,
                担当社員ID = uc社員入力.M社員.ID,
            };

            vm得意先.Update(更新得意先);
        }

        // ------------------------------------------------------------
        // 削除ボタン
        // ------------------------------------------------------------
        private void On削除Click()
        {

            var ID = int.Parse(textBox得意先ID.Text);

            var result = MessageBox.Show("削除しますか？",
                "確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            //「はい」以外はなにもしない。
            if (result != DialogResult.Yes) return;

            try
            {
                得意先Delete(ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("データベースから削除できませんでした。\r\n" + ex.Message,
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            // 削除が終わったら照会モードへ
            ucCRUD.ChangeMode_照会();
            // データ再取得
            DataLoad();
        }

        private void 得意先Delete(int ID)
        {
            vm得意先.Delete(ID);
        }

        // ------------------------------------------------------------
        // キャンセルボタン
        // ------------------------------------------------------------
        private void OnキャンセルClick()
        {
            ucCRUD.ChangeMode_照会();
        }

    }
}
