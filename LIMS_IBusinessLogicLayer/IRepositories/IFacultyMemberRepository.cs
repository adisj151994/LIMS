using LIMS_Model.DBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_IBusinessLogicLayer.IRepositories
{
    public interface IFacultyMemberRepository : IRepository<FacultyMember>
    {
        Database Update(Database database);
        int Delete(Database database);
    }
}
