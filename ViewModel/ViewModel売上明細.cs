using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using テストDB.Models;

namespace テストDB.ViewModel
{
    internal class ViewModel売上明細
    {
        public class V売上明細
        {
            public int ID { get; set; }
            public string 得意先CD { get; set; }
            public string 得意先名 { get; set; }
            public string 担当社員番号 { get; set; }
            public string 担当社員名 { get; set; }
            public DateTime 売上日 { get; set; }
            public string バーコード { get; set; }
            public string 商品名 { get; set; }
            public int 販売単価 { get; set; }
            public int 販売数量 { get; set; }
            public int 明細売上高 { get; set; }
        }

        public enum V売上明細_Col
        {
            ID = 0,
            得意先CD = 1,
            得意先名 = 2,
            売上日 = 3,
            バーコード = 4,
            商品名 = 5,
            販売単価 = 6,
            販売数量 = 7,
            明細売上高 = 8,
        }


        public V売上明細[] listV売上明細 { get; private set; }

        // -------------------------------------------------------------------------
        // コンストラクタ
        // -------------------------------------------------------------------------

        public ViewModel売上明細()
        {
        }

        // -------------------------------------------------------------------------
        // T売上明細の読み込み
        // -------------------------------------------------------------------------
        public void LoadT売上明細(DateTime 期間開始, DateTime 期間終了, string 商品名 = "", string バーコード = "", string 得意先CD = "")
        {
            using (var db = new テストDBContext())
            {
                listV売上明細 = db.T売上s
                            .Where(it => it.売上日 >= 期間開始 && it.売上日 <= 期間終了)
                            .Join(
                                db.T売上明細s,
                                売上 => 売上.ID,
                                明細 => 明細.売上ID,
                                (売上, 明細) => new V売上明細 // 目的のクラスを指定する
                                {
                                    ID = 売上.ID,
                                    得意先CD = 売上.得意先CD,
                                    得意先名 = 売上.得意先名,
                                    売上日 = 売上.売上日,
                                    バーコード = 明細.バーコード,
                                    商品名 = 明細.商品名,
                                    販売単価 = 明細.販売単価,
                                    販売数量 = 明細.販売数量,
                                    明細売上高 = 明細.明細売上高,
                                })
                            .ToArray()
                            ;

                if (!string.IsNullOrWhiteSpace(商品名))
                {
                    listV売上明細 = listV売上明細
                                .Where(it => it.商品名 == 商品名)
                                .ToArray();
                }

                if (!string.IsNullOrWhiteSpace(バーコード))
                {
                    listV売上明細 = listV売上明細
                                .Where(it => it.バーコード == バーコード)
                                .ToArray();
                }

                if (!string.IsNullOrWhiteSpace(得意先CD))
                {
                    listV売上明細 = listV売上明細
                                .Where(it => it.得意先CD == 得意先CD)
                                .ToArray();
                }

            }
        }


    }
}
