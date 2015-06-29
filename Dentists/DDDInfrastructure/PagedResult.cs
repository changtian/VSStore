using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDDInfrastructure
{
    public class PagedResult<T>:ICollection<T>
    {
        public PagedResult()
        {
            this.data = new List<T>();
        }

        #region Public Properties
        private int? totalRecords;
        public int? TotalRecords
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }

        private int? totalPages;
        public int? TotalPages
        {
            get { return totalPages; }
            set { totalPages = value; }
        }

        private int? pageSize;
        public int? PageSize
        {
            get { return pageSize; }
            set { pageSize = value; }
        }

        private int? pageNumber;
        public int? PageNumber
        {
            get { return pageNumber; }
            set { pageNumber = value; }
        }

        private IList<T> data;
        public IEnumerable<T> Data
        {
            get { return data; }
        }
        #endregion

        #region ICollection<T> Members
        public void Add(T item)
        {
            data.Add(item);
        }

        public void Clear()
        {
            data.Clear();
        }

        public bool Contains(T item)
        {
            return data.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            data.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return data.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(T item)
        {
            return data.Remove(item);
        }
        #endregion
        #region IEnumerable<T> Members
        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>A System.Collections.Generic.IEnumerator{T} that can be used to iterate through
        /// the collection.</returns>
        public IEnumerator<T> GetEnumerator()
        {
            return data.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members
        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>An System.Collections.IEnumerator object that can be used to iterate through
        /// the collection.</returns>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return data.GetEnumerator();
        }

        #endregion
    }
}
