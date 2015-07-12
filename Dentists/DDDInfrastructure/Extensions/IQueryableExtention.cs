using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDInfrastructure.Extensions
{
    public static class IQueryableExtention
    {
        public static List<T> ToList<T>(this IQueryable<T> iq)
        {
            List<T> list = new List<T>(iq);
            return list;
        }
    }
}
