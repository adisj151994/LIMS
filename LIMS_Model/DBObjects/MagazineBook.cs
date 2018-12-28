using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_Model.DBObjects
{
    public class MagazineBook : Book
    {
        public string MagazineDescription { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
