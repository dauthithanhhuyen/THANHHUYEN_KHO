namespace InventoryManage.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BillExport")]
    public partial class BillExport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BillExport()
        {
            DetailExports = new HashSet<DetailExport>();
        }

        public int ID { get; set; }

        public int? IDCustom { get; set; }

        public int? IDStoreKeeper { get; set; }

        public DateTime? DateExport { get; set; }

        [StringLength(50)]
        public string NameCustom { get; set; }

        public virtual Custom Custom { get; set; }

        public virtual Storekeeper Storekeeper { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailExport> DetailExports { get; set; }
    }
}
