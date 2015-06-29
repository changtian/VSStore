using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DDDInfrastructure
{
    /// <summary>
    /// Represents that the implemented classes are repository contexts that utilize
    /// the functionality provided by Entity Framework.
    /// </summary>
    public interface IEntityFrameworkRepositoryContext : IRepositoryContext
    {
        /// <summary>
        /// Gets the <see cref="DbContext"/> instance handled by Entity Framework.
        /// </summary>
        DbContext Context { get; }
    }
}
