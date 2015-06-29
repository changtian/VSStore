using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDInfrastructure
{
    public interface IEntity<TKey>
    {
        TKey ID { get; set; }
    }

    public interface IEntity : IEntity<Guid>
    { }
}
