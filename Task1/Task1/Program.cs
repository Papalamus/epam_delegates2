using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] test = "quick brown fox jump over the lazy dog".Split(' ');
            foreach (string s in test)
            {
                Console.WriteLine(s);
            }
            test.sorting(0,test.Length-1,stringCompare);
            Console.WriteLine("___________________");
            foreach (string s in test)
            {
                Console.WriteLine(s);    
            }
            Console.ReadKey();

        }

        public  static int stringCompare(string s1,string s2)
        {
            if (s1.Length > s2.Length)
            {
                return 1;
            }
            if (s1.Length < s2.Length)
            {
                return -1;
            }
            
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] > s2[i])
                {
                    return 1;
                }
                if (s1[i] < s2[i])
                {
                    return -1;
                }
            }
            return 0;
        }
    }
}
