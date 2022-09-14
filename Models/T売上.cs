namespace テストDB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T売上
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T売上()
        {
            T売上明細 = new HashSet<T売上明細>();
        }

        public int ID { get; set; }

        public int 得意先ID { get; set; }

        [Required]
        [StringLength(20)]
        public string 得意先CD { get; set; }

        [Required]
        [StringLength(256)]
        public string 得意先名 { get; set; }

        public int 担当社員ID { get; set; }

        [Required]
        [StringLength(20)]
        public string 担当社員番号 { get; set; }

        [Required]
        [StringLength(256)]
        public string 担当社員名 { get; set; }

        public DateTime 売上日 { get; set; }

        public int 売上高 { get; set; }

        public int 消費税額 { get; set; }

        public int 仕入高 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T売上明細> T売上明細 { get; set; }
    }
}
