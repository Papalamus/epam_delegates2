using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Office office = new Office();
            Random r = new Random();
            Person[] testPersons =
            {
                new Person() {Name = "Irina"},
                new Person() {Name = "Pavel"},
                new Person() {Name = "Peka"},
                new Person() {Name = "Terrlo"}
            };
            foreach (Person testPerson in testPersons)
            {
                Console.WriteLine("[На работу пришел {0}]",testPerson.Name);
                office.Income(testPerson);
                Console.WriteLine();
            }
            Console.WriteLine("_____________________________________________________________");
            foreach (Person testPerson in testPersons)
            {
                Console.WriteLine("[С работы уходит {0}]", testPerson.Name);
                office.Leave(testPerson);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
