using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_Model.DBObjects
{
    public class FacultyMember : Member
    {
        public string FacultyName { get; set; }
        public int Experience { get; set; }
    }
}
