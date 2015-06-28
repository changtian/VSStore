using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDInfrastructure
{
    public class EntityFrameworkRepositoryContext:RepositoryContext, IEntityFrameworkRepositoryContext
    {
        #region Private Fields
        private readonly DbContext efContext;
        private readonly object sync = new object();
        #endregion

        #region Ctor
        public EntityFrameworkRepositoryContext(DbContext efContext)
        {
            this.efContext = efContext;
        }
        #endregion

        #region Protected Methods
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                efContext.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion

        #region IEntityFrameworkRepositoryContext Members
        public System.Data.Entity.DbContext Context
        {
            get { return this.efContext; }
        }
        #endregion

        #region IRepositoryContext Members
        public override void RegisterDeleted(object obj)
        {
            this.efContext.Entry(obj).State = System.Data.Entity.EntityState.Deleted;
            Committed = false;
        }

        public override void RegisterModified(object obj)
        {
            this.efContext.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            Committed = false;
        }

        public override void RegisterNew(object obj)
        {
            this.efContext.Entry(obj).State = System.Data.Entity.EntityState.Added;
            Committed = false;
        }
        #endregion

        #region IUnitOfWork Members
        public override bool DistributedTransactionSupported
        {
            get { return true; }
        }

        public override void Rollback()
        {
            Committed = false;
        }

        public override void Commit()
        {
            if (!Committed)
            {
                lock (sync)
                {
                    efContext.SaveChanges();
                }
                Committed = true;
            }
        }
        #endregion
    }
}
