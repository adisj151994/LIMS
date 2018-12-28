using LIMS_Model.DBObjects;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_DataLayer.EntityConfigurations
{
    public class MagazineBookConfiguration : EntityTypeConfiguration<MagazineBook>
    {
        public MagazineBookConfiguration()
        {
            ToTable("MagazineBooks");

            Property(m => m.MagazineDescription)
                .IsRequired()
                .HasMaxLength(500);

            Property(m => m.PublishedDate)
                .IsRequired();
        }
    }
}
