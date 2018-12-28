using LIMS_Model.DBObjects;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_DataLayer.EntityConfigurations
{
    public class DatabaseConfiguration : EntityTypeConfiguration<Database>
    {
        public DatabaseConfiguration()
        {
            HasKey(d => d.DatabaseId);

            Property(b => b.NoOfBooksIssued)
                .IsRequired();

            Property(b => b.NoOfBooksAvailable)
                .IsRequired();
        }
    }
}
