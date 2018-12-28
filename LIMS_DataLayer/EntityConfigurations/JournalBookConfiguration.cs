using LIMS_Model.DBObjects;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_DataLayer.EntityConfigurations
{
    public class JournalBookConfiguration : EntityTypeConfiguration<JournalBook>
    {
        public JournalBookConfiguration()
        {
            ToTable("JournalBooks");

            Property(j => j.JournalDescription)
                .IsRequired()
                .HasMaxLength(500);

            Property(j => j.PublishedDate)
                .IsRequired();
        }
    }
}
