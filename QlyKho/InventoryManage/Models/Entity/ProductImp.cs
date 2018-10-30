using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManage.Models.Entity
{
    public class ProductImp
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public int? Quantity { get; set; }

        public string Unit { get; set; }
    }
}
