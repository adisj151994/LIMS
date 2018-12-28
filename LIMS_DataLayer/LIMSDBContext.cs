using LIMS_DataLayer.EntityConfigurations;
using LIMS_Model.DBObjects;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_DataLayer
{
    public class LIMSDBContext : DbContext
    {
        public LIMSDBContext()
            : base("name=LIMSDbContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<LIMS_Model.DBObjects.Database> Databases { get; set; }
        public virtual DbSet<FacultyMember> FacultyMembers { get; set; }
        public virtual DbSet<Fine> Fines { get; set; }
        public virtual DbSet<JournalBook> JournalBooks { get; set; }
        public virtual DbSet<Librarian> Librarians { get; set; }
        public virtual DbSet<MagazineBook> MagazineBooks { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<MemberTransaction> Membertransactions { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<StudentMember> StudentMembers { get; set; } 
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<SupplierTransaction> SupplierTransactions { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AuthorConfiguration());
            modelBuilder.Configurations.Add(new BillConfiguration());
            modelBuilder.Configurations.Add(new BookConfiguration());
            modelBuilder.Configurations.Add(new DatabaseConfiguration());
            modelBuilder.Configurations.Add(new FacultyMemberConfiguration());
            modelBuilder.Configurations.Add(new FineConfiguration());
            modelBuilder.Configurations.Add(new JournalBookConfiguration());
            modelBuilder.Configurations.Add(new LibrarianConfiguration());
            modelBuilder.Configurations.Add(new MagazineBookConfiguration());
            modelBuilder.Configurations.Add(new MemberConfiguration());
            modelBuilder.Configurations.Add(new MemberTransactionConfiguration());
            modelBuilder.Configurations.Add(new PublisherConfiguration());
            modelBuilder.Configurations.Add(new StatusConfiguration());
            modelBuilder.Configurations.Add(new StudentMemberConfiguration());
            modelBuilder.Configurations.Add(new SupplierConfiguration());
            modelBuilder.Configurations.Add(new SupplierTransactionConfiguration());
            modelBuilder.Configurations.Add(new TransactionConfiguration());
        }
    }
}
