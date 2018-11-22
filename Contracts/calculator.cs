using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    [Serializable]
    [DataContract]
    public class Calculator
    {
        [DataMember]
        public int x1{ get; set; }

        [DataMember]
        public int y1 { get; set; }

        [DataMember]
        public int tp { get; set; }
    }
}
