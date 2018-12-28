using LIMS_IBusinessLogicLayer.IRepositories;
using LIMS_Model.DBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_DataLayer.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public LIMSDBContext LIMSDBContext { get { return Context as LIMSDBContext; } }

        public BookRepository(LIMSDBContext context)
            : base(context)
        {
        }

        public IEnumerable<Book> GetBooksWithAuthor(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetBooksWithPublisher(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
