using LIMS_Model.DBObjects;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_DataLayer.EntityConfigurations
{
    public class BookConfiguration : EntityTypeConfiguration<Book>
    {
        public BookConfiguration()
        {
            HasKey(b => b.BookId);

            Property(b => b.ISBNo)
                .IsRequired()
                .HasMaxLength(50);

            HasRequired(b => b.Author)
                .WithMany(b => b.Books)
                .HasForeignKey(b => b.AuthorId);

            HasRequired(b => b.Publisher)
               .WithMany(b => b.Books)
               .HasForeignKey(b => b.PublisherId);

            Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(100);

            Property(b => b.Edition)
                .IsRequired();

            Property(b => b.Status)
                .IsRequired();

            Property(b => b.DateOfPurchase)
                .IsRequired();

            Property(b => b.NoOfBooks)
                .IsRequired();

            HasRequired(b => b.Database)
                .WithRequiredPrincipal(b => b.Book);
        }
    }
}
