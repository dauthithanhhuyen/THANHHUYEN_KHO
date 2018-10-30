namespace InventoryManage.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            DetailExports = new HashSet<DetailExport>();
            DetailImports = new HashSet<DetailImport>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Quantity { get; set; }

        public int? IdCom { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        public virtual Company Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailExport> DetailExports { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailImport> DetailImports { get; set; }
    }
}
