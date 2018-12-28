using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_Model.DBObjects
{
    public class Status
    {
        public int StatusId { get; set; }
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        public int CatNo { get; set; }
    }
}
