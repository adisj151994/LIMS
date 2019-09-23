using LIMS_Model.DBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LIMS_BusinessLogicLayer;
using LIMS.Models;

namespace LIMS.Controllers
{
    public class BooksController : ApiController
    {
        BooksBLL bookBLL = new BooksBLL();
        [HttpGet]
        public Book DisplayBookDetails(int bookId)
        {
            return bookBLL.DisplayBookDetails(bookId);
        }
        [HttpPost]
        public List<Book> AddNewJournalBooks(List<JournalBook> journalBook)
        {
            List<Book> listOfBooks = journalBook.ConvertAll(x => (Book)x);

            return bookBLL.AddNewBooks(listOfBooks);
        }
        [HttpPost]
        public List<Book> AddNewMagazineBooks(List<MagazineBook> magazineBook)
        {
            List<Book> listOfBooks = magazineBook.ConvertAll(x => (Book)x);

            return bookBLL.AddNewBooks(listOfBooks);
        }
        [HttpDelete]
        public int DeleteBooks(int bookid)
        {
            return bookBLL.DeleteBooks(bookid);
        }
        [HttpGet]
        public List<Book> SearchBooks(string bookName,string authorName)
        {
            return bookBLL.SearchBooks(bookName, authorName);
        }
    }
}
