using LIMS_Model.DBObjects;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_DataLayer.EntityConfigurations
{
    public class FacultyMemberConfiguration : EntityTypeConfiguration<FacultyMember>
    {
        public FacultyMemberConfiguration()
        {
            ToTable("FacultyMembers");

            Property(f => f.FacultyName)
                .IsRequired()
                .HasMaxLength(50);

            Property(f => f.Experience)
                .IsRequired();
        }
    }
}
