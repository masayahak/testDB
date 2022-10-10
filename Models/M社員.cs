namespace テストDB.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class M社員
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "{0}は必須項目です")]
        [StringLength(20, ErrorMessage = "{0}は{1}文字以内にしてください")]
        public string 社員番号 { get; set; }

        [Required(ErrorMessage = "{0}は必須項目です")]
        [StringLength(256, ErrorMessage = "{0}は{1}文字以内にしてください")]
        public string 社員名 { get; set; }

    }
}
