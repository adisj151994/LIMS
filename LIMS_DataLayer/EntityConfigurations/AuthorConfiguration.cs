using LIMS_Model.DBObjects;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_DataLayer.EntityConfigurations
{
    public class AuthorConfiguration : EntityTypeConfiguration<Author>
    {
        public AuthorConfiguration()
        {
            HasKey(a => a.AuthorId);

            Property(a => a.AuthorName)
                .IsRequired()
                .HasMaxLength(50);

            Property(a => a.AuthorDescription)
                .IsRequired()
                .HasMaxLength(500);
        }
    }
}
