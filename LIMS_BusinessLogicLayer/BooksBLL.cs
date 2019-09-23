using LIMS_DataLayer;
using LIMS_IBusinessLogicLayer;
using LIMS_IBusinessLogicLayer.IRepositories;
using LIMS_Model.DBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_BusinessLogicLayer
{
    public class BooksBLL
    {
        private readonly IUnitOfWork _unitOfWork;
        public BooksBLL()
        {
            _unitOfWork = new UnitOfWork();
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
            return _unitOfWork.Books.DisplayBookDetails(bookId);
        }
        public List<Book> AddNewBooks(List<Book> book)
        {
            var books = _unitOfWork.Books.AddNewBooks(book);
            _unitOfWork.Complete();
            return books;
        }
        public int DeleteBooks(int bookId)
        {
            throw new NotImplementedException();
        }
        public List<Book> SearchBooks(string bookName, string author)
        {
            return _unitOfWork.Books.SearchBooks(bookName, author);
        }
    }
}
