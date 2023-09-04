using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercise02 {
    [XmlRoot("novleist")]
    class Novelist {
        [XmlElement(ElementName  = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "birth")]
        public string Birth { get; set; }

        [XmlElement(ElementName = "masterpieces")]
        public string[] Masterpieces { get; set; }

        

        public override string ToString() {
            return Name + "  " + Birth + "  ";
        }
    }

}
