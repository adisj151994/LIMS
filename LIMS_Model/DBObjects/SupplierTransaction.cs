using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_Model.DBObjects
{
    public class SupplierTransaction : Transaction
    {
        public int SuplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
        public int BillNo { get; set; }
        public virtual Bill Bill { get; set; }
    }
}
