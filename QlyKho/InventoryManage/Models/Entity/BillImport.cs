namespace InventoryManage.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BillImport")]
    public partial class BillImport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BillImport()
        {
            DetailImports = new HashSet<DetailImport>();
        }

        public int ID { get; set; }

        public int? IDCompany { get; set; }

        public int? IDStoreKeeper { get; set; }

        public DateTime? DateImport { get; set; }

        [StringLength(50)]
        public string NameCustom { get; set; }

        public virtual Company Company { get; set; }

        public virtual Storekeeper Storekeeper { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailImport> DetailImports { get; set; }
    }
}
