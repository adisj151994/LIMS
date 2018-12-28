using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_Model.DBObjects
{
    public class StudentMember : Member
    {
        public string StudentName { get; set; }
        public string Grade { get; set; }
    }
}
