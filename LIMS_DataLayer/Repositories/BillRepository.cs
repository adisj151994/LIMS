using LIMS_IBusinessLogicLayer.IRepositories;
using LIMS_Model.DBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_DataLayer.Repositories
{
    public class BillRepository : Repository<Bill>, IBillRepository
    {
        public LIMSDBContext LIMSDBContext { get { return Context as LIMSDBContext; } }

        public BillRepository(LIMSDBContext context)
            : base(context)
        {
        }
        public IEnumerable<Bill> GetBooksWithBook(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
