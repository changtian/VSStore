using DDDInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentists.Models
{
    public class Address : IAggregateRoot
    {
        public string Province { get; set; }
        public string Citi { get; set; }
        public string District { get; set; }
        public string Detail { get; set; }

        private Guid id;
        public Guid ID
        {
            get
            {
                if (id == default(Guid)) id = Guid.NewGuid();
                return id;
            }
            set
            {
                id = value;
            }
        }
    }
}
