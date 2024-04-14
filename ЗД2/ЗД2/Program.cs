using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЗД2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class myClass = new Class();

          
            Console.WriteLine("Число ПИ: " + myClass.PI());
            Console.WriteLine("число: " + myClass.Int());
            Console.WriteLine("число в квадрате: " + myClass.Kvadrt(5));
            Console.WriteLine("Корень" + myClass.Coren(25));
        }
    }
}
