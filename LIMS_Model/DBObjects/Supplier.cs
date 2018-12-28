using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_Model.DBObjects
{
    public class Supplier
    {
        public Supplier()
        {
            SupplierTransactions = new List<SupplierTransaction>();
        }
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
        public virtual IList<SupplierTransaction> SupplierTransactions { get; set; }
    }
}
