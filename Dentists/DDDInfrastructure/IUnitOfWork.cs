using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDInfrastructure
{
    public interface IUnitOfWork
    {
        bool DistributedTransactionSupported { get; }
        bool Committed { get;}
        void Rollback();
        void Commit();
    }
}
