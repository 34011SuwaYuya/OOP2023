using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercise02 {
    [DataContract]
    class Novelist {

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember ( Name = "birth" )]
        public string Birth { get; set; }

        [DataMember ( Name = "masterpieces" )]
        public string[] Masterpieces { get; set; }

        

        public override string ToString() {
            return Name + "  " + Birth + "  ";
        }
    }

}
