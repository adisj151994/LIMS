using LIMS_Model.DBObjects;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_DataLayer.EntityConfigurations
{
    public class FineConfiguration : EntityTypeConfiguration<Fine>
    {
        public FineConfiguration()
        {
            HasKey(f => f.FineId);

            Property(f => f.Amount)
                .IsRequired();

            Property(f => f.Date)
                .IsRequired();

            HasRequired(f => f.Member)
                .WithMany(f => f.Fines)
                .HasForeignKey(f => f.MemberId)
                .WillCascadeOnDelete(false);
        }
    }
}
