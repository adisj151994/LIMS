using LIMS_IBusinessLogicLayer.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_IBusinessLogicLayer
{
    public interface IUnitOfWork : IDisposable
    {
        IBookRepository Books { get; }
        IBillRepository Bills { get; }
        int Complete();
    }
}
