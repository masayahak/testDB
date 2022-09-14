namespace テストDB.Models
{
    using System.ComponentModel.DataAnnotations;

    public partial class M商品
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string バーコード { get; set; }

        [Required]
        [StringLength(256)]
        public string 商品名 { get; set; }

        public int 販売単価 { get; set; }

        public int 仕入単価 { get; set; }
    }
}
