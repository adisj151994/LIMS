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
            return LIMSDBContext.Books
                .Where(b => b.BookId == bookId)
                .SingleOrDefault();
        }

        public List<Book> AddNewBooks(List<Book> books)
        {
            return LIMSDBContext.Books
                .AddRange(books)
                .ToList();
        }

        public List<Book> DeleteBooks(List<Book> books)
        {
            return LIMSDBContext.Books
                .RemoveRange(books)
                .ToList();
        }

        public List<Book> SearchBooks(string bookName, string author)
        {
            return LIMSDBContext.Books
                 .Include(b => b.Author)
                 .Include(b => b.Publisher)
                 .Where(b => b.Author.AuthorName == author && b.Name == bookName).ToList();
        }
        public LIMSDBContext LIMSDBContext { get { return Context as LIMSDBContext; } }
    }
}
