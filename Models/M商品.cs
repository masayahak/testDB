namespace テストDB.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class M商品 
    {
        // アノテーションによるバリデーションで全て入力をチェックしたいが、
        // そうもいかない事情がある。
        // Modelのプロパティの属性がintやDatetimeの場合、そもそも画面入力結果が
        // 属性を満たしていない可能性がある。
        // この属性へのCASTの可否はアノテーションではチェックし切れない。


        public int ID { get; set; }

        [Required(ErrorMessage = "{0}は必須項目です")]
        [StringLength(20, ErrorMessage = "{0}は{1}文字以内にしてください")]
        public string バーコード { get; set; }

        [Required(ErrorMessage = "{0}は必須項目です")]
        [StringLength(256, ErrorMessage = "{0}は{1}文字以内にしてください")]
        public string 商品名 { get; set; }

        [Required(ErrorMessage = "{0}は必須項目です")]
        [Range(1, 999, ErrorMessage = "{0}は{1}円以上{2}円以下にしてください")]
        [GreaterThan("仕入単価", ErrorMessage = "{0}は{1}より高額にしてください")]
        public int 販売単価 { get; set; }

        [Required(ErrorMessage = "{0}は必須項目です")]
        [Range(1, 999, ErrorMessage = "{0}は{1}円以上{2}円以下にしてください")]
        public int 仕入単価 { get; set; }

    }
}
