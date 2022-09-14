namespace テストDB.Models
{
    using System.ComponentModel.DataAnnotations;

    public partial class M得意先
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string 得意先CD { get; set; }

        [Required]
        [StringLength(256)]
        public string 得意先名 { get; set; }

        public int 担当社員ID { get; set; }
    }


    public class M得意先一覧
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
