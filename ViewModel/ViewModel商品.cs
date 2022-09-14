using System;
using System.Collections.Generic;
using System.Linq;
using テストDB.Models;

namespace テストDB.ViewModel
{
    public class ViewModel商品
    {
        public List<M商品> list商品 { get; private set; }

        public ViewModel商品()
        {
            using (var db = new テストDBContext())
            {

                list商品 = db.M商品s
                            .OrderBy(it => it.バーコード)
                            .ToList();
            }
        }

        public int Add(M商品 追加商品)
        {
            using (var db = new テストDBContext())
            {
                // 追加用 ユニークチェック
                if (db.M商品s.Count(it => it.バーコード == 追加商品.バーコード) > 0)
                    throw new Exception("バーコードが重複しています。");
 
                db.M商品s.Add(追加商品);
                db.SaveChanges();
            }

            return 追加商品.ID;

        }

        public void Update(M商品 更新商品)
        {
            using (var db = new テストDBContext())
            {

                // 修正用 ユニークチェック
                if (db.M商品s.Count(it => it.バーコード == 更新商品.バーコード && it.ID != 更新商品.ID) > 0)
                    throw new Exception("バーコードが重複しています。");

                var 商品 = db.M商品s
                            .Single(it => it.ID == 更新商品.ID);

                商品.バーコード = 更新商品.バーコード;
                商品.商品名 = 更新商品.商品名;

                db.SaveChanges();
            }

        }

        public void Delete(int ID)
        {
            using (var db = new テストDBContext())
            {
                var 商品 = db.M商品s
                            .Single(it => it.ID == ID);

                db.M商品s.Remove(商品);
                db.SaveChanges();
            }

        }

        public int FindRowByID(int ID)
        {

            var row = list商品
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

        public int FindRow商品(string キーワード, int StartIndex)
        {

            var row = list商品
                        .Select((it, i) => new {
                            商品名 = it.商品名,
                            バーコード = it.バーコード,
                            Index = i
                        })
                        .Where(it => it.Index >= StartIndex)
                        .Where(it => it.商品名.Contains(キーワード) || it.バーコード.Contains(キーワード))
                        .Select(it => it.Index)
                        .FirstOrDefault()
                        ;

            return row;

        }

        public M商品 Get商品ByID(int ID)
        {
            var 商品 = list商品
                    .Single(it => it.ID == ID)
                    ;

            return 商品;
        }

        public M商品 Get商品Byバーコード(string バーコード)
        {
            var 商品 = list商品
                    .Single(it => it.バーコード == バーコード)
                    ;

            return 商品;
        }

    }
}
