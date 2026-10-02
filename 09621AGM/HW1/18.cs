using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW1
{
    internal class _18
    {
        static void Main18(string[] args)
        {
            // Составить программу, которая: 
            //а) запрашивает имя человека и повторяет его на экране;
            //б) запрашивает имя человека и повторяет его на экране с приветствием. 
            string name = Console.ReadLine();

            Console.WriteLine(name);

            Console.WriteLine($"Привет, {name}");
        }
    }
}
