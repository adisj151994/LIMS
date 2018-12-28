using LIMS_Model.DBObjects;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_DataLayer.EntityConfigurations
{
    public class LibrarianConfiguration : EntityTypeConfiguration<Librarian>
    {
        public LibrarianConfiguration()
        {
            HasKey(l => l.LibrarianId);

            Property(l => l.LibrarianName)
                .IsRequired()
                .HasMaxLength(50);

            Property(l => l.LibrarianContactNo)
                .IsRequired();
        }
    }
}
