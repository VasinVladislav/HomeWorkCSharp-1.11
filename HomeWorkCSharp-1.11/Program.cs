using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp_1._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.11. Составить программу вывода на экран «столбиком» четырех любых чисел.
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                int a = rnd.Next();
                Console.WriteLine($"{a}");
            }
        }
    }
}
