using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using テストDB.Models;
using テストDB.ViewModel;
using static テストDB.UI.Form社員Mメンテ;
using static 共通UI.UcGridPager;
using 共通UI;
using static テストDB.UI.Form売上一覧;
using System.ComponentModel.DataAnnotations;

namespace テストDB.UI
{
    public partial class Form商品Mメンテ : Form
    {
        // ----------------------------------------------------------------
        // 表示する一覧の定義
        // ----------------------------------------------------------------
        public class ds商品一覧
        {
            public int No { get; set; }
            public int ID { get; set; }
            public string バーコード { get; set; }
            public string 商品名 { get; set; }
            public int? 販売単価 { get; set; }
            public int? 仕入単価 { get; set; }
        }

        public enum ds商品一覧_Col
        {
            No = 0,
            ID = 1,
            バーコード = 2,
            商品名 = 3,
            販売単価 = 4,
            仕入単価 = 5,
        }

        private ViewModel商品 vm商品;

        // ------------------------------------------------------------
        //  処理モード変更時
        // ------------------------------------------------------------
        private void ChangeMode_追加()
        {
            ds商品一覧 newItem = new ds商品一覧()
            {
                ID = -1,
                バーコード = "",
                商品名 = "",
                販売単価 = null,
                仕入単価 = null,
            };
            ShowDetail(newItem);

            this.textBoxバーコード.ReadOnly = false;
            this.textBox商品名.ReadOnly = false;
            this.textBox販売単価.ReadOnly = false;
            this.textBox仕入単価.ReadOnly = false;

            panel詳細.BringToFront();
            ucGridPager.Enabled = false;
        }

        private void ChangeMode_修正()
        {
            var row = ucGridPager.pagerDataGridView.SelectedRows[0];

            ds商品一覧 currentItem = new ds商品一覧()
            {
                ID = (int)row.Cells[(int)ds商品一覧_Col.ID].Value,
                バーコード = (string)row.Cells[(int)ds商品一覧_Col.バーコード].Value,
                商品名 = (string)row.Cells[(int)ds商品一覧_Col.商品名].Value,
                販売単価 = (int)row.Cells[(int)ds商品一覧_Col.販売単価].Value,
                仕入単価 = (int)row.Cells[(int)ds商品一覧_Col.仕入単価].Value,
            };

            ShowDetail(currentItem);

            this.textBoxバーコード.ReadOnly = false;
            this.textBox商品名.ReadOnly = false;
            this.textBox販売単価.ReadOnly = false;
            this.textBox仕入単価.ReadOnly = false;

            panel詳細.BringToFront();
            ucGridPager.Enabled = false;
        }

        private void ChangeMode_照会()
        {
            this.textBoxバーコード.ReadOnly = true;
            this.textBox商品名.ReadOnly = true;
            this.textBox販売単価.ReadOnly = true;
            this.textBox仕入単価.ReadOnly = true;

            panel詳細.SendToBack();
            ucGridPager.Enabled = true;
        }

        private void ShowDetail(ds商品一覧 商品)
        {
            textBox商品ID.Text = 商品.ID.ToString();
            textBoxバーコード.Text = 商品.バーコード;
            textBox商品名.Text = 商品.商品名;
            textBox販売単価.Text = 商品.販売単価.ToString();
            textBox仕入単価.Text = 商品.仕入単価.ToString();
        }

        // ------------------------------------------------------------
        //  初期化
        // ------------------------------------------------------------
        public Form商品Mメンテ()
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
        private void Form_Load(object sender, EventArgs e)
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
                vm商品 = new ViewModel商品();

                list = vm商品.list商品
                    .OrderBy(it => it.バーコード)
                    .Select((it, i) => new
                    {
                        No = i + 1,
                        ID = it.ID,
                        バーコード = it.バーコード,
                        商品名 = it.商品名,
                        販売単価 = it.販売単価,
                        仕入単価 = it.仕入単価,
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

            dg.Columns[(int)ds商品一覧_Col.ID].Visible = false;
            dg.Columns[(int)ds商品一覧_Col.商品名].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // 書式
            dg.Columns[(int)ds商品一覧_Col.販売単価].DefaultCellStyle.Format = "C";
            dg.Columns[(int)ds商品一覧_Col.仕入単価].DefaultCellStyle.Format = "C";

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

            if (!IsAll_Validated()) return;

            try
            {
                if (ucCRUD.状態 == 処理モード.状態.追加中)
                {
                    商品Add();
                }
                else
                {
                    商品Update();
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

        private bool IsAll_Validated()
        {

            bool allValidated = true;

            // エラープロバイダーを一旦全て消す
            errorProvider.Clear();

            // -------------------------------------------------
            // CAST可能か？
            // ※ CASTできなければValidatorでチェックできない
            // -------------------------------------------------
            int i販売単価;
            if (! int.TryParse(textBox販売単価.Text, out i販売単価))
            {
                errorProvider.SetError(textBox販売単価, "販売単価は数値を入力");
                allValidated = false;
            }

            int i仕入単価;
            if (!int.TryParse(textBox仕入単価.Text, out i仕入単価))
            {
                errorProvider.SetError(textBox仕入単価, "仕入単価は数値を入力");
                allValidated = false;
            }

            // CASTに失敗したら、チェックはそこまで
            if (allValidated == false) return false;


            // -------------------------------------------------
            // Modelのアノテーションを利用したチェック
            // -------------------------------------------------
            M商品 商品 = new M商品
            {
                バーコード = textBoxバーコード.Text,
                商品名 = textBox商品名.Text,
                販売単価 = i販売単価,
                仕入単価 = i仕入単価,
            };

            ValidationContext context = new ValidationContext(商品, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(商品, context, errors, true))
            {
                allValidated = false;

                foreach (ValidationResult result in errors)
                {
                    SetErrorProviders(result);
                }
            }

            return allValidated;
        }

        // エラープロバイダーのセット
        private void SetErrorProviders(ValidationResult result)
        {
            var エラー列名 = result.MemberNames.First();

            Control ErrorControl = null;

            switch (エラー列名)
            {
                case "バーコード":
                    {
                        ErrorControl = textBoxバーコード;
                        break;
                    }
                case "商品名":
                    {
                        ErrorControl = textBox商品名;
                        break;
                    }
                case "販売単価":
                    {
                        ErrorControl = textBox販売単価;
                        break;
                    }
                case "仕入単価":
                    {
                        ErrorControl = textBox仕入単価;
                        break;
                    }
            }

            errorProvider.SetError(ErrorControl, result.ErrorMessage);
        }


        // ------------------------------------------------------------
        // DB更新
        // ------------------------------------------------------------
        private void 商品Add()
        {
            var 追加商品 = new M商品
            {
                バーコード = textBoxバーコード.Text,
                商品名 = textBox商品名.Text,
                販売単価 = int.Parse(textBox販売単価.Text),
                仕入単価 = int.Parse(textBox仕入単価.Text),

            };

            var ID = vm商品.Add(追加商品);
        }

        private void 商品Update()
        {
            var 更新商品 = new M商品
            {
                ID = int.Parse(textBox商品ID.Text),
                バーコード = textBoxバーコード.Text,
                商品名 = textBox商品名.Text,
                販売単価 = int.Parse(textBox販売単価.Text),
                仕入単価 = int.Parse(textBox仕入単価.Text),

            };
            vm商品.Update(更新商品);
        }

        // ------------------------------------------------------------
        // 削除ボタン
        // ------------------------------------------------------------
        private void On削除Click()
        {

            var ID = int.Parse(textBox商品ID.Text);

            var result = MessageBox.Show("削除しますか？",
                "確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            //「はい」以外はなにもしない。
            if (result != DialogResult.Yes) return;

            try
            {
                商品Delete(ID);

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

        private void 商品Delete(int ID)
        {
            vm商品.Delete(ID);
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
