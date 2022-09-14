using System;
using System.Collections.Generic;
using System.Linq;
using テストDB.Models;

namespace テストDB.ViewModel
{
    internal class ViewModel得意先
    {
        public List<M得意先一覧> list得意先一覧 { get; private set; }

        public ViewModel得意先()
        {
            using (var db = new テストDBContext())
            {

                list得意先一覧 = db.M得意先s
                                .Join(
                                    db.M社員s,
                                    得意先 => 得意先.担当社員ID,
                                    社員 => 社員.ID,
                                    (得意先, 社員) => new M得意先一覧
                                    {
                                        ID =得意先.ID,
                                        得意先CD = 得意先.得意先CD,
                                        得意先名 = 得意先.得意先名,
                                        担当社員ID = 得意先.担当社員ID,
                                        担当社員番号 = 社員.社員番号,
                                        担当社員名 = 社員.社員名,
                                    }
                                )
                                .OrderBy(it => it.得意先CD)
                                .ToList();
            }
        }

        public int Add(M得意先 追加得意先)
        {
            using (var db = new テストDBContext())
            {
                // 追加用 ユニークチェック
                if (db.M得意先s.Count(it => it.得意先CD == 追加得意先.得意先CD) > 0)
                    throw new Exception("得意先コードが重複しています。");

                db.M得意先s.Add(追加得意先);
                db.SaveChanges();
            }

            return 追加得意先.ID;

        }

        public void Update(M得意先 更新得意先)
        {
            using (var db = new テストDBContext())
            {

                // 修正用 ユニークチェック
                if (db.M得意先s.Count(it => it.得意先CD == 更新得意先.得意先CD && it.ID != 更新得意先.ID) > 0)
                    throw new Exception("得意先コードが重複しています。");

                var 得意先 = db.M得意先s
                            .Single(it => it.ID == 更新得意先.ID);

                得意先.得意先CD = 更新得意先.得意先CD;
                得意先.得意先名 = 更新得意先.得意先名;
                得意先.担当社員ID = 更新得意先.担当社員ID;

                db.SaveChanges();
            }

        }

        public void Delete(int ID)
        {
            using (var db = new テストDBContext())
            {
                var 得意先 = db.M得意先s
                            .Single(it => it.ID == ID);

                db.M得意先s.Remove(得意先);
                db.SaveChanges();
            }

        }

        public int FindRowByID(int ID)
        {

            var row = list得意先一覧
                        .Select((it, i) => new {
                            ID = it.ID,
                            Index = i
                        })
                        .Where(it => it.ID == ID)
                        .Select(it => it.Index)
                        .FirstOrDefault()
                        ;

            return row;

        }

        public int FindRow得意先一覧(string キーワード, int StartIndex)
        {

            var row = list得意先一覧
                        .Select((it, i) => new {
                            得意先名 = it.得意先名,
                            得意先CD = it.得意先CD,
                            担当社員番号 = it.担当社員番号,
                            担当社員名D = it.担当社員名,
                            Index = i
                        })
                        .Where(it => it.Index >= StartIndex)
                        .Where(
                            it =>
                                it.得意先名.Contains(キーワード)
                             || it.得意先CD.Contains(キーワード)
                             || it.担当社員番号.Contains(キーワード)
                             || it.担当社員名D.Contains(キーワード)
                        )
                        .Select(it => it.Index)
                        .FirstOrDefault()
                        ;

            return row;

        }

        public M得意先一覧 Get得意先ByID(int ID)
        {
            var 得意先 = list得意先一覧
                    .Single(it => it.ID == ID)
                    ;

            return 得意先;

        }
        public M得意先一覧 Get得意先By得意先CD(string 得意先CD)
        {
            var 得意先 = list得意先一覧
                    .Single(it => it.得意先CD == 得意先CD)
                    ;

            return 得意先;

        }
        

        public int GetCount担当得意先(int 社員ID)
        {
            int cnt = list得意先一覧
                    .Count(it => it.担当社員ID == 社員ID)
                    ;

            return cnt;

        }
    }
}
