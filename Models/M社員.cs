namespace テストDB.Models
{
    using System.ComponentModel.DataAnnotations;

    public partial class M社員
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string 社員番号 { get; set; }

        [Required]
        [StringLength(256)]
        public string 社員名 { get; set; }
    }
}
