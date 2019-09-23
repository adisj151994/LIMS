using LIMS_IBusinessLogicLayer.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_IBusinessLogicLayer
{
    public interface IUnitOfWork : IDisposable
    {
        IAuthorRepository Author { get; }
        IBookRepository Books { get; }
        IBillRepository Bills { get; }
        IDatabaseRepository Database { get; }
        IFacultyMemberRepository FacultyMember { get; }
        IFineRepository Fine { get; }
        IJournalBookRepository JournalBook { get; }
        ILibrarianRepository Librarian { get; }
        IMagazineBookRepository MagazineBook { get; }
        IMemberBookRepository MemberBook { get; }
        IPublisherRepository Publisher { get; }
        IStudentMemberRepository StudentMember { get; }
        ISupplierRepository Supplier { get; }
        ISupplierTransactionRepository SupplierTransaction { get; }
        ITransactionRepository Transaction { get; }
        int Complete();
    }
}
