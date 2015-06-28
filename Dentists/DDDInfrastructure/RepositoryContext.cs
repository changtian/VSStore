using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DDDInfrastructure
{
    public abstract class RepositoryContext:DisposableObject, IRepositoryContext
    {
        private readonly Guid id = Guid.NewGuid();
        private readonly ThreadLocal<List<object>> localNewCollection = new ThreadLocal<List<object>>(() => new List<object>());
        private readonly ThreadLocal<List<object>> localModifiedCollection = new ThreadLocal<List<object>>(() => new List<object>());
        private readonly ThreadLocal<List<object>> localDeletedCollection = new ThreadLocal<List<object>>(() => new List<object>());
        private readonly ThreadLocal<bool> localCommitted = new ThreadLocal<bool>(() => true);

        protected IEnumerable<object> NewCollection
        { get { return localNewCollection.Value; } }

        protected IEnumerable<object> ModifiedCollection
        {
            get 
            {
                return localModifiedCollection.Value;
            }
        }

        protected IEnumerable<object> DeletedCollection
        {
            get 
            {
                return localDeletedCollection.Value;
            }
        }

        public Guid ID
        {
            get { return id; }
        }

        protected void ClearRegistrations()
        {
            this.localNewCollection.Value.Clear();
            this.localModifiedCollection.Value.Clear();
            this.localDeletedCollection.Value.Clear();
        }

        public virtual void RegisterDeleted(object obj)
        {
            if (localNewCollection.Value.Contains(obj))
            {
                if (localNewCollection.Value.Remove(obj))
                    return;
            }
            bool removedFromModified = localModifiedCollection.Value.Remove(obj);
            bool addedToDeleted = false;
            if (!localDeletedCollection.Value.Contains(obj))
            {
                localDeletedCollection.Value.Add(obj);
                addedToDeleted = true;
            }
            localCommitted.Value = !(removedFromModified || addedToDeleted);
        }

        public virtual void RegisterModified(object obj)
        {
            if (localDeletedCollection.Value.Contains(obj))
                throw new InvalidOperationException("The object cannot be registered as a modified object since it was marked as deleted.");
            if (!localModifiedCollection.Value.Contains(obj) && !localNewCollection.Value.Contains(obj))
                localModifiedCollection.Value.Add(obj);
            Committed = false;
        }

        public virtual void RegisterNew(object obj)
        {
            localNewCollection.Value.Add(obj);
            Committed = false;
        }

        public virtual bool DistributedTransactionSupported
        {
            get { return false; }
        }

        public virtual bool Committed
        {
            get { return localCommitted.Value; }
            protected set { localCommitted.Value = value; }
        }

        public abstract void Rollback();

        public abstract void Commit();

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.localCommitted.Dispose();
                this.localDeletedCollection.Dispose();
                this.localModifiedCollection.Dispose();
                this.localNewCollection.Dispose();
            }
        }

        
    }
}
