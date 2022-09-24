using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using テストDB.Models;
using テストDB.ViewModel;
using static テストDB.共通UI.UcPager;

namespace テストDB.UI
{
    public partial class Form社員メンテ : Form
    {
        // ----------------------------------------------------------------
        // 表示する一覧の定義
        // ----------------------------------------------------------------
        public class ds社員一覧
        {
            public int No { get; set; }
            public int ID { get; set; }
            public string 社員番号 { get; set; }
            public string 社員名 { get; set; }
        }

        public enum ds社員一覧_Col
        {
            No = 0,
            ID = 1,
            社員番号 = 2,
            社員名 = 3,
        }

        private ViewModel社員 vm社員;

        private void ShowRow(M社員 社員)
        {
            textBox社員ID.Text = 社員.ID.ToString();
            textBox社員番号.Text = 社員.社員番号;
            textBox社員名.Text = 社員.社員名;
        }

        // ------------------------------------------------------------
        //  処理モードの変更
        // ------------------------------------------------------------
        private void buttonｷｬﾝｾﾙ_Click(object sender, EventArgs e)
        {
            userControl処理モード.ChangeMode_照会();
        }

        // ------------------------------------------------------------
        //  処理モード変更時
        // ------------------------------------------------------------
        private void ChangeMode_追加()
        {
            this.textBox社員ID.Text = "-1";
            this.textBox社員番号.Text = "";
            this.textBox社員名.Text = "";

            this.textBox社員番号.ReadOnly = false;
            this.textBox社員名.ReadOnly = false;

            button削除.Enabled = false;
            button保存.Enabled = true;
            buttonｷｬﾝｾﾙ.Enabled = true;

            panel詳細.BringToFront();
        }

        private void ChangeMode_修正()
        {
            this.textBox社員番号.ReadOnly = false;
            this.textBox社員名.ReadOnly = false;

            button削除.Enabled = true;
            button保存.Enabled = true;
            buttonｷｬﾝｾﾙ.Enabled = true;

            panel詳細.BringToFront();
        }

        private void ChangeMode_照会()
        {
            this.textBox社員番号.ReadOnly = true;
            this.textBox社員名.ReadOnly = true;

            button削除.Enabled = false;
            button保存.Enabled = false;
            buttonｷｬﾝｾﾙ.Enabled = false;

            ucPager.BringToFront();
        }

        // ------------------------------------------------------------
        //  初期化
        // ------------------------------------------------------------
        public Form社員メンテ()
        {
            InitializeComponent();

            userControl処理モード.ChangeMode追加 += ChangeMode_追加;
            userControl処理モード.ChangeMode修正 += ChangeMode_修正;
            userControl処理モード.ChangeMode照会 += ChangeMode_照会;

            userControl処理モード.ChangeMode_照会();

            // グリッドのフォーマットイベント
            this.ucPager.OnGridFormat += OnGrid_Format;

            // グリッドのダブルクリック
            this.ucPager.OnGridDoubleClick += OnGrid_DoubleClick;
        }

        // ------------------------------------------------------------
        // コントロール表示時に全データを読み込み
        //      ただし、デザインモードではデータを読み込まない
        // ------------------------------------------------------------
        private void Form社員メンテ_Load(object sender, EventArgs e)
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
                vm社員 = new ViewModel社員();
            });

            var list = vm社員.list社員
                .OrderBy(it => it.社員番号)
                .Select((it, i) => new ds社員一覧
                {
                    No = i + 1,
                    ID = it.ID,
                    社員番号 = it.社員番号,
                    社員名 = it.社員名,
                })
                .ToList()
                ;

            this.ucPager.RowsInPage = 100;
            this.ucPager.KeyColumn = (int)ds社員一覧_Col.ID;

            this.ucPager.RowCount = list.Count();

            this.ucPager.SetFullDatasource<ds社員一覧>(list);
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

            dg.Columns[(int)ds社員一覧_Col.ID].Visible = false;
            dg.Columns[(int)ds社員一覧_Col.社員名].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            ucPager_SizeChanged(this, null);
        }

        // ----------------------------------------------------------------
        // 一覧のサイズ変更
        // ----------------------------------------------------------------
        private void ucPager_SizeChanged(object sender, EventArgs e)
        {
            // 処理なし
        }


        // ----------------------------------------------------------------
        // 一覧のダブルクリック
        // ----------------------------------------------------------------
        private void OnGrid_DoubleClick(OnGridDoubleClickArgs args)
        {
            int 社員ID;

            int.TryParse(args.ID, out 社員ID);

            var item = vm社員.list社員
                .Select((it, i) => new ds社員一覧
                {
                    No = i + 1,
                    ID = it.ID,
                    社員番号 = it.社員番号,
                    社員名 = it.社員名,
                })
                .Where(it => it.ID == 社員ID)
                .First()
                ;

            this.textBox社員ID.Text = item.ID.ToString();
            this.textBox社員番号.Text = item.社員番号;
            this.textBox社員名.Text = item.社員名;

            // 修正モードへ
            userControl処理モード.ChangeMode_修正();
        }

        // ------------------------------------------------------------
        // 保存ボタン
        // ------------------------------------------------------------
        private void button保存_Click(object sender, EventArgs e)
        {

            if (IsInputCheckError()) return;

            int ID;
            try
            {
                if (userControl処理モード.状態 == 処理モード.状態.追加中)
                {
                    ID = 社員Add();
                }
                else
                {
                    ID = 社員Update();
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
            userControl処理モード.ChangeMode_照会();

            // データ再取得
            DataLoad();

        }

        // ------------------------------------------------------------
        // 入力情報のチェック
        // ------------------------------------------------------------
        private bool IsInputCheckError()
        {

            var 社員番号 = textBox社員番号.Text;
            if (string.IsNullOrWhiteSpace(社員番号))
            {
                MessageBox.Show("社員番号は必須です。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return true;
            }

            var 社員名 = textBox社員名.Text;
            if (string.IsNullOrWhiteSpace(社員名))
            {
                MessageBox.Show("社員名は必須です。",
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
        private int 社員Add()
        {

            var 追加社員 = new M社員
            {
                社員番号 = textBox社員番号.Text,
                社員名 = textBox社員名.Text,

            };
            var ID = vm社員.Add(追加社員);
            return ID;
        }

        private int 社員Update()
        {
            var 更新社員 = new M社員
            {
                ID = int.Parse(textBox社員ID.Text),
                社員番号 = textBox社員番号.Text,
                社員名 = textBox社員名.Text,

            };
            vm社員.Update(更新社員);
            return 更新社員.ID;
        }

        // ------------------------------------------------------------
        // 削除ボタン
        // ------------------------------------------------------------
        private void button削除_Click(object sender, EventArgs e)
        {

            var ID = int.Parse(textBox社員ID.Text);

            // 削除したい社員が担当している得意先が１件でもあったらダメ
            var vm得意先 = new ViewModel得意先();
            if (vm得意先.GetCount担当得意先(ID) > 0)
            {
                MessageBox.Show("担当している得意先があるので削除できません。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            var result = MessageBox.Show("削除しますか？",
                "確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            //「はい」以外はなにもしない。
            if (result != DialogResult.Yes) return;


            try
            {
                社員Delete(ID);
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

        }

        private void 社員Delete(int ID)
        {

            vm社員.Delete(ID);

            // 削除が終わったら照会モードへ
            userControl処理モード.ChangeMode_照会();
            // データ再取得
            DataLoad();

            // 今は削除後は先頭行が選択状態になる。
            // ちょっと微妙かとも思うが、マスターメンテナンスで削除されたデータの
            // １つ前を表示すると、なぜそれが選択されているのか直感的にわからない。
        }

    }
}
