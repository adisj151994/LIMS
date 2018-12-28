using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_Model.DBObjects
{
    public abstract class Transaction
    {
        public int TransactionId { get; set; }
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        public int NoOfBooks { get; set; }
        public string TransactionType { get; set; }
    }
}
