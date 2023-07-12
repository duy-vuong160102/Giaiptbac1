using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giaiptbac1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cho phuong trinh: 'a * x + b = 0', nhap a va b:");
            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a != 0)
            {
                double solution = -b / a;
                Console.Write("co nghiem la: {0}!", solution);
            }
            else
            {
                if (b == 0)
                {
                    Console.Write("vo so nghiem!");
                }
                else
                {
                    Console.Write("vo nghiem!");
                }
            }
        }
    }
}
