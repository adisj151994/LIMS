using LIMS_Model.DBObjects;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_DataLayer.EntityConfigurations
{
    public class MemberTransactionConfiguration : EntityTypeConfiguration<MemberTransaction>
    {
        public MemberTransactionConfiguration()
        {
            ToTable("MemberTransactions");
        }
    }
}
