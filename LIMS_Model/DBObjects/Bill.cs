using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_Model.DBObjects
{
    public class Bill
    {
        public int BillId { get; set; }
        public string BillNo { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
    }
}
