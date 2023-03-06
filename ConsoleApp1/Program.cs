using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MySet<int> Set1 = new MySet<int>();
            MySet<int> Set2 = new MySet<int>();
            Set1.Add(1);
            Set1.Add(2);
            Set1.Add(3);
            Set1.Remove(2);
            Set2.Add(4);
            Set2.Add(5);
            Console.WriteLine((Set1.Objedinenie(Set2)).ToString());
            Console.ReadLine();
        }
    }
}
