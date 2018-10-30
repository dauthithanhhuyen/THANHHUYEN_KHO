namespace InventoryManage.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [Key]
        [StringLength(20)]
        public string UserName { get; set; }

        [StringLength(20)]
        public string Pass { get; set; }

        public int? ID { get; set; }

        public virtual Storekeeper Storekeeper { get; set; }
    }
}
