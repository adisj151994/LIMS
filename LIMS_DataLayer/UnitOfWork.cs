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

        public UnitOfWork()
        {
            _context = new LIMSDBContext();
            Books = new BookRepository(_context);
            Bills = new BillRepository(_context);
        }

        public IBookRepository Books { get; private set; }
        public IBillRepository Bills { get; private set; }

        public IAuthorRepository Author { get; private set; }

        public IDatabaseRepository Database { get; private set; }

        public IFacultyMemberRepository FacultyMember { get; private set; }

        public IFineRepository Fine { get; private set; }

        public IJournalBookRepository JournalBook { get; private set; }

        public ILibrarianRepository Librarian { get; private set; }

        public IMagazineBookRepository MagazineBook { get; private set; }

        public IMemberBookRepository MemberBook { get; private set; }

        public IPublisherRepository Publisher { get; private set; }

        public IStudentMemberRepository StudentMember { get; private set; }

        public ISupplierRepository Supplier { get; private set; }

        public ISupplierTransactionRepository SupplierTransaction { get; private set; }

        public ITransactionRepository Transaction { get; private set; }

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
