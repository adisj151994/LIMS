using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_Model.DBObjects
{
    public class MemberTransaction : Transaction
    {
        public int MemberId { get; set; }
        public virtual Member Member { get; set; }
        public DateTime DateIssues { get; set; }
        public DateTime DueDate { get; set; }
    }
}
