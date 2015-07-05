using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDInfrastructure.Serialization
{
    public interface IObjectSerializer
    {
        byte[] Serialize<TObject>(TObject obj);

        TObject Desirialize<TObject>(byte[] bytes);
    }
}
