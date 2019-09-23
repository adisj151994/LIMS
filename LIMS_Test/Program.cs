using LIMS_BusinessLogicLayer;
using LIMS_DataLayer;
using LIMS_Model.DBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //var books = new Books();
            using (var unitOfWork = new UnitOfWork())
            {
                // Example1
                //var course = unitOfWork.Books.GetAll(); //

                var Books = unitOfWork.Books.SearchBooks("Eloquent JavaScript, Second Edition", "Marijn Haverbeke").ToList();

                //var books = new List<Book>();

                //Book book = new MagazineBook();

                //var Books = unitOfWork.Books.AddNewBooks(books);

                // Example2
                //var courses = unitOfWork.Books.Get(3);

                // Example3
                //var author = unitOfWork.Authors.GetAuthorWithCourses(1);
                //unitOfWork.Courses.RemoveRange(author.Courses);
                //unitOfWork.Authors.Remove(author);
                unitOfWork.Complete();
            }
        }
    }
}
