using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Runtime.Serialization;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            using (var reader = XmlReader.Create ( "Sample.xml" )) {
                var serializer = new DataContractSerializer ( typeof(Novelist) );
                Novelist novelist = serializer.ReadObject ( reader ) as Novelist;

                Console.WriteLine ( novelist );
            }
        }
    }
}

