using LIMS_Model.DBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_IBusinessLogicLayer.IRepositories
{
    public interface ILibrarianRepository : IRepository<Librarian>
    {
        int IssueBooks(List<Book> books, int memberId);
        int ReturnBooks(List<Book> books, int memberId);
        int CollectFine(int memberId, int amount);
        List<Book> SearchBooks(string bookName, string author);
        Member VerifyMember(int memberId);
        int PayBills(Bill bill);
    }
}
