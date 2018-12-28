using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_Model.DBObjects
{
    public abstract class Member
    {
        public Member()
        {
            Fines = new List<Fine>();
            MemberTransactions = new List<MemberTransaction>();
        }
        public int MemberId { get; set; }
        public string Type { get; set; }
        public DateTime DateOfMember { get; set; }
        public int NoOfBookesIssued { get; set; }
        public int MaxBookLimit { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public long ContactNumber { get; set; }
        public virtual IList<Fine> Fines { get; set; }
        public virtual IList<MemberTransaction> MemberTransactions { get; set; }
    }
}
