using System;
using System.Collections.Generic;
using System.Linq;
using テストDB.Models;

namespace テストDB.ViewModel
{

    public class ViewModel社員
    {
        public List<M社員> list社員 { get; private set; }

        public ViewModel社員()
        {
            using (var db = new テストDBContext())
            {

                list社員 = db.M社員s
                            .OrderBy(it => it.社員番号)
                            .ToList();
            }
        }

        public int Add(M社員 追加社員)
        {
            using (var db = new テストDBContext())
            {
                // 追加用 ユニークチェック
                if (db.M社員s.Count(it => it.社員番号 == 追加社員.社員番号) > 0)
                    throw new Exception("社員番号が重複しています。");
 
                db.M社員s.Add(追加社員);
                db.SaveChanges();
            }

            return 追加社員.ID;

        }

        public void Update(M社員 更新社員)
        {
            using (var db = new テストDBContext())
            {

                // 修正用 ユニークチェック
                if (db.M社員s.Count(it => it.社員番号 == 更新社員.社員番号 && it.ID != 更新社員.ID) > 0)
                    throw new Exception("社員番号が重複しています。");

                var 社員 = db.M社員s
                            .Single(it => it.ID == 更新社員.ID);

                社員.社員番号 = 更新社員.社員番号;
                社員.社員名 = 更新社員.社員名;

                db.SaveChanges();
            }

        }

        public void Delete(int ID)
        {
            using (var db = new テストDBContext())
            {
                var 社員 = db.M社員s
                            .Single(it => it.ID == ID);

                db.M社員s.Remove(社員);
                db.SaveChanges();
            }

        }

        public int FindRowByID(int ID)
        {

            var row = list社員
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

        public int FindRow社員(string キーワード, int StartIndex)
        {

            var row = list社員
                        .Select((it, i) => new {
                            社員名 = it.社員名,
                            社員番号 = it.社員番号,
                            Index = i
                        })
                        .Where(it => it.Index >= StartIndex)
                        .Where(it => it.社員名.Contains(キーワード) || it.社員番号.Contains(キーワード))
                        .Select(it => it.Index)
                        .FirstOrDefault()
                        ;

            return row;

        }

        public M社員 Get社員ByID(int ID)
        {
            var 社員 = list社員
                    .Single(it => it.ID == ID)
                    ;

            return 社員;
        }

        public M社員 Get社員By社員番号(string 社員番号)
        {
            var 社員 = list社員
                    .Single(it => it.社員番号 == 社員番号)
                    ;

            return 社員;
        }

    }

}
