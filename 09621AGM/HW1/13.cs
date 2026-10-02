using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW1
{
    internal class _13
    {
        static void Main13(string[] args)
        {
            //Составить программу обмена значениями трех переменных величин а, b, c по следующим двум схемам:
            //а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
            //б) b присвоить значение а, с присвоить значение b, а присвоить значение с. 

            Console.WriteLine("Введите чсиал a, b, c по очереди:");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            (a, b, c) = (b, c, a);
            Console.WriteLine((a, b, c));

            (b, c, a) = (a, b, c);
            (a, b, c) = (c, a, b);
            Console.WriteLine((a, b, c));
        }
    }
}
