namespace テストDB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T売上明細
    {
        public int ID { get; set; }

        public int 売上ID { get; set; }

        public int 商品ID { get; set; }

        [Required]
        [StringLength(20)]
        public string バーコード { get; set; }

        [Required]
        [StringLength(256)]
        public string 商品名 { get; set; }

        public int 販売単価 { get; set; }

        public int 仕入単価 { get; set; }

        public int 販売数量 { get; set; }

        public int 明細売上高 { get; set; }

        public int 明細消費税額 { get; set; }

        public virtual T売上 T売上 { get; set; }
    }
}
