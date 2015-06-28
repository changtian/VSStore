using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDInfrastructure
{
    public interface IRepositoryContext:IUnitOfWork, IDisposable
    {
        Guid ID { get; }
        void RegisterDeleted(object obj);
        void RegisterModified(object obj);
        void RegisterNew(object obj);
    }
}
