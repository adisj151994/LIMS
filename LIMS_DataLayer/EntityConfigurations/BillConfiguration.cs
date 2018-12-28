using LIMS_Model.DBObjects;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_DataLayer.EntityConfigurations
{
    public class BillConfiguration : EntityTypeConfiguration<Bill>
    {
        public BillConfiguration()
        {
            HasKey(b => b.BillId);

            Property(b => b.BillNo)
                .IsRequired()
                .HasMaxLength(50);

            Property(b => b.Date)
                .IsRequired();

            Property(b => b.Amount)
                .IsRequired();
        }
    }
}
