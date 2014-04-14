using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    //internal delegate void GreetingsHandler(string incomerName, Time time);
    //internal delegate void GoodbuyHandler(string leaverName);

    internal delegate void GreetingsHandler(object sender, IncomeOfficeEventArgs e);
    internal delegate void GoodbyeHandler(object sender);
    struct Time
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public override string ToString()
        {
            return String.Format(
                "{0:00}:{1:00}:{2:00}",
                this.Hours, this.Minutes, this.Seconds);
        }

        public static Time GetRandomTime()
        {
           Random r = new Random();
           return new Time{Hours = r.Next(24)};
        }
    }

    class Person
    {
        public string Name { get; set; }

        public event GreetingsHandler EmployeeIncome;
        public event GoodbyeHandler EmployeeLeave;


        public void NeedToGo()
        {
            if (EmployeeLeave != null)
            {
                EmployeeLeave(this);
            }
        }
        public void Arriving(Time t)
        {
            if (EmployeeIncome!=null)
            {
                EmployeeIncome(this, new IncomeOfficeEventArgs(t));
            }
        }

        private void Greetings(string incomerName, Time time)
        {
            if (time.Hours<12)
            {
                Console.WriteLine("\"Good morning {0}!\"- said {1}", incomerName, Name);
            }
            else if (time.Hours > 17)
            {
                Console.WriteLine("\"Good evening {0}!\"- said {1}", incomerName, Name);
            }
            else
            {
                Console.WriteLine("\"Good afternoon  {0}!\"- said {1}", incomerName, Name);
            } 
            
            
        }

        private void Goodbye(string leaverName)
        {
            Console.WriteLine("\"Goodbye {0}!\"- said {1}", leaverName, Name);
        }

        public void Goodbye(object sender)
        {
            Person leaver = sender as Person;
            if (leaver == null)
            {
                throw new ArgumentException("Событие сгенерированно не класоом Person", "sender");
            }
            Goodbye(leaver.Name);
        }
        

        public void Greetings(object sender, IncomeOfficeEventArgs e)
        {
            Person incomer = sender as Person;
            if (incomer == null)
            {
                throw new ArgumentException("Событие сгенерированно не класоом Person","sender");
            }
            this.Greetings(incomer.Name,e.IncomeTime);
        }
    }
}
