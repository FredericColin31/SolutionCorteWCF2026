using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataContracts
{
    [DataContract()]
    public class CityTemp
    {
        [DataMember()]
        public String City { get; set; }
        [DataMember()]
        public Int32 Temperature { get; set; }
    }
}
