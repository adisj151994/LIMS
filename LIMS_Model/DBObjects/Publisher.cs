using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_Model.DBObjects
{
    public class Publisher
    {
        public Publisher()
        {
            Books = new List<Book>();
        }
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public string PublisherAddress { get; set; }
        public long PublisherContactNo { get; set; }
        public virtual IList<Book> Books { get; set; }
    }
}
