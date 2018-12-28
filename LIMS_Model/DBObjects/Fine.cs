using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_Model.DBObjects
{
    public class Fine
    {
        public int FineId { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; } 
        public int MemberId { get; set; }
        public virtual Member Member { get; set; }
    }
}
