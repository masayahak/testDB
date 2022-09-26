using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using テストDB.Models;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace テストDB.ViewModel
{
    public class ViewModel売上
    {

        public T売上[] list売上 { get; private set; }
        public T売上明細[] list売上明細 { get; private set; }

        // -------------------------------------------------------------------------
        // コンストラクタ
        // -------------------------------------------------------------------------

        public ViewModel売上()
        {
        }

        // -------------------------------------------------------------------------
        // 公開するプロパティ
        // -------------------------------------------------------------------------
        public int 取引件数 { get; private set; }
        public int 売上高 { get; private set; }
        public int 粗利益 { get; private set; }

        public class 売上高List
        {
            public DateTime 売上日 { get; set; }
            public int 売上高 { get; set; }

        }
        public 売上高List[] 売上高lists { get; private set; }


        public class 商品売上高List
        {
            public string 商品名 { get; set; }
            public int 売上高 { get; set; }

        }
        public 商品売上高List[] 売上上位商品lists { get; private set; }


        public class 得意先売上高List
        {
            public string 得意先名 { get; set; }
            public int 売上高 { get; set; }

        }
        public 得意先売上高List[] 売上上位得意先list { get; private set; }

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
        // データの読み込み
        // -------------------------------------------------------------------------
        public void LoadData(int ID)
        {
            using (var db = new テストDBContext())
            {
                list売上 = db.T売上s
                            .Where(it => it.ID == ID)
                            .ToArray();

                int[] 売上IDs = list売上.Select(it => it.ID).ToArray();

                list売上明細 = db.T売上明細s
                            .Where(it => 売上IDs.Contains(it.売上ID))
                            .ToArray();
            }
        }

        // -------------------------------------------------------------------------
        // T売上の読み込み
        // -------------------------------------------------------------------------
        public void LoadT売上(DateTime 期間開始, DateTime 期間終了, string 得意先CD = "", string 担当社員番号 = "")
        {
            using (var db = new テストDBContext())
            {
                list売上 = db.T売上s
                            .Where(it => it.売上日 >= 期間開始 && it.売上日 <= 期間終了)
                            .ToArray();

                if (!string.IsNullOrWhiteSpace(得意先CD))
                {
                    list売上 = list売上
                                .Where(it => it.得意先CD == 得意先CD)
                                .ToArray();
                }

                if (!string.IsNullOrWhiteSpace(担当社員番号))
                {
                    list売上 = list売上
                                .Where(it => it.担当社員番号 == 担当社員番号)
                                .ToArray();
                }

            }
        }

        // -------------------------------------------------------------------------
        // T売上明細の読み込み
        // -------------------------------------------------------------------------
        public void LoadT売上明細(DateTime 期間開始, DateTime 期間終了, string バーコード = "", string 得意先CD = "")
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

        // -------------------------------------------------------------------------
        // 各種データの読み込み
        // -------------------------------------------------------------------------
        public void Load売上分析(DateTime fromDate, DateTime toDate)
        {
            using (var db = new テストDBContext())
            {

                list売上 = db.T売上s
                            .Where(it => it.売上日 >= fromDate && it.売上日 <= toDate)
                            .ToArray();

                int[] 売上IDs = list売上.Select(it => it.ID).ToArray(); 

                list売上明細 = db.T売上明細s
                            .Where(it => 売上IDs.Contains(it.売上ID))
                            .ToArray();
            }

            取引件数 = list売上.Length;
            売上高 = list売上.Sum(it => it.売上高);
            粗利益 = 売上高 - list売上.Sum(it => it.仕入高);

            // 売上高リスト
            売上高lists = list売上
                .GroupBy(it => new
                {
                    it.売上日
                })
                .OrderBy(it => it.Key.売上日)
                .Select(g => new 売上高List
                {
                    売上日 = g.Key.売上日,
                    売上高 = g.Sum(s => s.売上高)
                })
                .ToArray();

            売上上位商品lists = list売上明細
                .GroupBy(it => new
                {
                    it.商品名
                })
                .Select(g => new 商品売上高List
                {
                    商品名 = g.Key.商品名,
                    売上高 = g.Sum(s => s.明細売上高)
                })
                .OrderByDescending(it => it.売上高)
                .Take(5)
                .ToArray();

            売上上位得意先list = list売上
                .GroupBy(it => new
                {
                    it.得意先名
                })
                .Select(g => new 得意先売上高List
                {
                    得意先名 = g.Key.得意先名,
                    売上高 = g.Sum(s => s.売上高)
                })
                .OrderByDescending(it => it.売上高)
                .Take(5)
                .ToArray();

        }

    }
}
