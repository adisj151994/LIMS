using LIMS_IBusinessLogicLayer.IRepositories;
using LIMS_Model.DBObjects;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_DataLayer.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
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

        public int RemoveFromCatelog(Book book)
        {
            throw new NotImplementedException();
        }

        public int AddToCatelog(Book book)
        {
            throw new NotImplementedException();
        }

        public Book DisplayBookDetails(int bookId)
        {
            throw new NotImplementedException();
        }

        public int AddNewBooks(IEnumerable<Book> books)
        {
            throw new NotImplementedException();
        }

        public int DeleteBooks(IEnumerable<Book> books)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> SearchBooks(string bookName, string author)
        {
            return LIMSDBContext.Books
                 .Include(b => b.Author);
                 //.Where(b => b.Author.AuthorName == author && b.Name == bookName);
        }
        public LIMSDBContext LIMSDBContext { get { return Context as LIMSDBContext; } }
    }
}
