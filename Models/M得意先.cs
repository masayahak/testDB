namespace テストDB.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class M得意先
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "{0}は必須項目です")]
        [StringLength(20, ErrorMessage = "{0}は{1}文字以内にしてください")]
        public string 得意先CD { get; set; }

        [Required(ErrorMessage = "{0}は必須項目です")]
        [StringLength(256, ErrorMessage = "{0}は{1}文字以内にしてください")]
        public string 得意先名 { get; set; }

        [Required(ErrorMessage = "{0}は必須項目です")]
        public int 担当社員ID { get; set; }

    }


    public class M得意先J担当者
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string 得意先CD { get; set; }

        [Required]
        [StringLength(256)]
        public string 得意先名 { get; set; }

        public int 担当社員ID { get; set; }
        public string 担当社員番号 { get; set; }
        public string 担当社員名 { get; set; }
    }
}
