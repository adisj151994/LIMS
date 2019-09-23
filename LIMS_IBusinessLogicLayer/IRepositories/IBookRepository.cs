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
        int RemoveFromCatelog(Book book);
        int AddToCatelog(Book book);
        Book DisplayBookDetails(int bookId);
        List<Book> AddNewBooks(List<Book> books);
        List<Book> DeleteBooks(List<Book> books);
        List<Book> SearchBooks(string bookName, string author);
    }
}
