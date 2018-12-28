using LIMS_DataLayer.Repositories;
using LIMS_IBusinessLogicLayer;
using LIMS_IBusinessLogicLayer.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_DataLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LIMSDBContext _context;

        public UnitOfWork(LIMSDBContext context)
        {
            _context = context;
            Books = new BookRepository(_context);
            Bills = new BillRepository(_context);
        }

        public IBookRepository Books { get; private set; }
        public IBillRepository Bills { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
