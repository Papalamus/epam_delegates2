using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Office
    {
        

        List<Person> presentPersons = new List<Person>();

        private void AddWorker(Person employee)
        {
            foreach (Person presentPerson in presentPersons)
            {
                //Подписываемся на события тех кто уже в офисе
                presentPerson.EmployeeIncome += employee.Greetings;
                presentPerson.EmployeeLeave += employee.Goodbye;
                //Те кто в офисе подписываются на наши события
                employee.EmployeeIncome += presentPerson.Greetings;
                employee.EmployeeLeave += presentPerson.Goodbye;
            }
        }
        private void RemoveWorker(Person employee)
        {
            foreach (Person presentPerson in presentPersons)
            {
                presentPerson.EmployeeIncome -= employee.Greetings;
                presentPerson.EmployeeLeave -= employee.Goodbye;
            }
        }

        public void Income(Person p)
        {
            Time t = Time.GetRandomTime();
            AddWorker(p);
            p.Arriving(t);
            presentPersons.Add(p);
            
        }

        public void Leave(Person p)
        {
            p.NeedToGo();
            RemoveWorker(p);
            presentPersons.Remove(p);
        }


        public Person this[int i]
        {
            get { return presentPersons[i]; }
        }

    }
}
