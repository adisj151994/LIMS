using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_Model.DBObjects
{
    public class Database
    {
        public int DatabaseId { get; set; }
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        public int NoOfBooksIssued { get; set; }
        public int NoOfBooksAvailable { get; set; }
    }
}
