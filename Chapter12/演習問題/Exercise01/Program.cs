using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            Exercise1_1 ( "employee.xml" );

            // これは確認用
            Console.WriteLine ( File.ReadAllText ( "employee.xml" ) );
            Console.WriteLine ();

            Exercise1_2 ( "employees.xml" );
            Exercise1_3 ( "employees.xml" );
            Console.WriteLine ();

            Exercise1_4 ( "employees.json" );

            // これは確認用
            Console.WriteLine ( File.ReadAllText ( "employees.json" ) );
        }

        private static void Exercise1_1(string v) {
            Employee emp1 = new Employee {
                Id = 1,
                Name = "Taro",
                HireDate = DateTime.Now,
            };

            var settings = new XmlWriterSettings {
                Encoding = new System.Text.UTF8Encoding ( false ),
                Indent = true,
                IndentChars = " ",
            };

            using (var writer = XmlWriter.Create(v)) {
                var serializer = new XmlSerializer ( emp1.GetType () );
                serializer.Serialize ( writer, emp1 );
            }

        }

        private static void Exercise1_2(string v) {



            Employee[] emps2 = new Employee[] {
                new Employee {
                    Id = 100, Name = "百", HireDate = DateTime.Parse ( "2010/1/15" ),
                },
                new Employee {
                    Id = 200 , Name = "二百", HireDate = DateTime.Parse ( "2011/1/15" )
                },

                new Employee {
                    Id = 300, Name = "三百", HireDate = DateTime.Parse ( "2013/1/15" ) },
            };

            EmployeeCollection employeeCollection = new EmployeeCollection {
                employeeList = emps2
            };


            using (var writer = XmlWriter.Create(v)) {
                    var serializer = new XmlSerializer (employeeCollection.GetType());
                serializer.Serialize ( writer, employeeCollection );
            }

            

    }

        private static void Exercise1_3(string v) {
            using (XmlReader reader = XmlReader.Create(v)) {
                var serializer = new XmlSerializer ( typeof ( EmployeeCollection) );
                var emps = serializer.Deserialize( reader ) as EmployeeCollection;

                foreach (var emp in emps.employeeList) {
                    Console.WriteLine ( "ID :{0} Name :{1} HireDate :{2}" ,emp.Id , emp.Name, emp.HireDate);
                }
            }

        }

        private static void Exercise1_4(string v) {
            Employee[] emps = new Employee[] {
                new Employee {
                    Id = 1000, Name = "千", HireDate = DateTime.Parse ( "2020/1/15" ),
                },
                new Employee {
                    Id = 2000 , Name = "二千", HireDate = DateTime.Parse ( "2021/1/15" )
                },

                new Employee {
                    Id = 3000, Name = "三千", HireDate = DateTime.Parse ( "2023/1/15" ) },
            };

            using (var stream = new FileStream(v, FileMode.Create, FileAccess.Write)) {
                var serializer = new DataContractJsonSerializer (emps.GetType());
                serializer.WriteObject ( stream, emps );

            }

        }
        

    }
    
}
