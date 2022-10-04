using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using テストDB.Models;
using テストDB.ViewModel;
using static 共通UI.UcGridPager;
using 共通UI;
using System.Collections.Generic;

namespace テストDB.UI
{
    public partial class Form社員Mメンテ : Form
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

        // ------------------------------------------------------------
        //  処理モード変更時
        // ------------------------------------------------------------
        private void ChangeMode_追加()
        {
            ds社員一覧 newItem = new ds社員一覧()
            {
                ID = -1,
                社員番号 = "",
                社員名 = "",
            };
            ShowDetail(newItem);

            this.textBox社員番号.ReadOnly = false;
            this.textBox社員名.ReadOnly = false;

            panel詳細.BringToFront();
            ucGridPager.Enabled = false;
        }

        private void ChangeMode_修正()
        {
            var row = ucGridPager.pagerDataGridView.SelectedRows[0];

            ds社員一覧 currentItem = new ds社員一覧()
            {
                ID = (int)row.Cells[(int)ds社員一覧_Col.ID].Value,
                社員番号 = (string)row.Cells[(int)ds社員一覧_Col.社員番号].Value,
                社員名 = (string)row.Cells[(int)ds社員一覧_Col.社員名].Value,
            };

            ShowDetail(currentItem);

            this.textBox社員番号.ReadOnly = false;
            this.textBox社員名.ReadOnly = false;

            panel詳細.BringToFront();
            ucGridPager.Enabled = false;
        }

        private void ChangeMode_照会()
        {
            this.textBox社員番号.ReadOnly = true;
            this.textBox社員名.ReadOnly = true;

            panel詳細.SendToBack();
            ucGridPager.Enabled = true;
        }

        private void ShowDetail(ds社員一覧 社員)
        {
            textBox社員ID.Text = 社員.ID.ToString();
            textBox社員番号.Text = 社員.社員番号;
            textBox社員名.Text = 社員.社員名;
        }

        // ------------------------------------------------------------
        //  初期化
        // ------------------------------------------------------------
        public Form社員Mメンテ()
        {
            InitializeComponent();

            ucCRUD.ChangeMode追加 += ChangeMode_追加;
            ucCRUD.ChangeMode修正 += ChangeMode_修正;
            ucCRUD.ChangeMode照会 += ChangeMode_照会;
            ucCRUD.ChangeMode_照会();

            ucCRUD.On削除Click += On削除Click;
            ucCRUD.On保存Click += On保存Click;
            ucCRUD.OnキャンセルClick += OnキャンセルClick;

            // グリッドのフォーマットイベント
            this.ucGridPager.OnGridFormat += OnGrid_Format;

            // グリッドのダブルクリック
            this.ucGridPager.OnGridDoubleClick += OnGrid_DoubleClick;
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
            var list = new List<Object>();

            await Task.Run(() =>
            {
                vm社員 = new ViewModel社員();

                list = vm社員.list社員
                    .OrderBy(it => it.社員番号)
                    .Select((it, i) => new 
                    {
                        No = i + 1,
                        ID = it.ID,
                        社員番号 = it.社員番号,
                        社員名 = it.社員名,
                    })
                    .Cast<Object>().ToList();
                    ;

            });

            this.ucGridPager.SetFullDatasource(list);
            this.ucGridPager.ShowPage();

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
            DataGridView dg = this.ucGridPager.pagerDataGridView;

            dg.Columns[(int)ds社員一覧_Col.ID].Visible = false;
            dg.Columns[(int)ds社員一覧_Col.社員名].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            ucGridPager_SizeChanged(this, null);
        }

        // ----------------------------------------------------------------
        // 一覧のサイズ変更
        // ----------------------------------------------------------------
        private void ucGridPager_SizeChanged(object sender, EventArgs e)
        {
            // 処理なし
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
                    社員Add();
                }
                else
                {
                    社員Update();
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
        private void 社員Add()
        {

            var 追加社員 = new M社員
            {
                社員番号 = textBox社員番号.Text,
                社員名 = textBox社員名.Text,

            };
            var ID = vm社員.Add(追加社員);
        }

        private void 社員Update()
        {
            var 更新社員 = new M社員
            {
                ID = int.Parse(textBox社員ID.Text),
                社員番号 = textBox社員番号.Text,
                社員名 = textBox社員名.Text,

            };
            vm社員.Update(更新社員);
        }

        // ------------------------------------------------------------
        // 削除ボタン
        // ------------------------------------------------------------
        private void On削除Click()
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

            // 削除が終わったら照会モードへ
            ucCRUD.ChangeMode_照会();
            // データ再取得
            DataLoad();

        }

        private void 社員Delete(int ID)
        {
            vm社員.Delete(ID);
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
