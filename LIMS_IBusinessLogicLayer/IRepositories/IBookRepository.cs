using LIMS_Model.DBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_IBusinessLogicLayer.IRepositories
{
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable<Book> GetBooksWithAuthor(int pageIndex, int pageSize);
        IEnumerable<Book> GetBooksWithPublisher(int pageIndex, int pageSize);
        int RemoveFromCatelog(Book book);
        int AddToCatelog(Book book);
        Book DisplayBookDetails(int bookId);
        IEnumerable<Book> AddNewBooks(IEnumerable<Book> books);
        IEnumerable<Book> DeleteBooks(IEnumerable<Book> books);
        IEnumerable<Book> SearchBooks(string bookName, string author);
    }
}
