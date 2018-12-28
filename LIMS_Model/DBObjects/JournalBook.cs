using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_Model.DBObjects
{
    public class JournalBook : Book
    {
        public string JournalDescription { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
