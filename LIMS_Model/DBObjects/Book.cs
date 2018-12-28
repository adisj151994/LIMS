using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_Model.DBObjects
{
    public abstract class Book
    {
        public int BookId { get; set; }
        public string ISBNo { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public int PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }
        public string Name { get; set; }
        public int Edition { get; set; }
        public string Status { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public int NoOfBooks { get; set; }
        public virtual Database Database { get; set; }
    }
}
