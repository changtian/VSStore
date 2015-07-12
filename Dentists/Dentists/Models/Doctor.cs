using DDDInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dentists.Models
{
    public class Doctor:IAggregateRoot
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Guid Disease { get; set; }
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
