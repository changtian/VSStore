using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDDInfrastructure
{
    public interface IAggregateRoot<TKey>:IEntity<TKey>
    {
    }

    /// <summary>
    /// Represents that the implemented classes are aggregate roots.
    /// </summary>
    public interface IAggregateRoot : IAggregateRoot<Guid>, IEntity
    {

    }
}
