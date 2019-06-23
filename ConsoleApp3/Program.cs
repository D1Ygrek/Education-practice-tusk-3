using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            double x = DoubleCheck();
            Console.WriteLine("Введите y");
            double y = DoubleCheck();
            bool ok = false;
            if (y >= 0)
            {
                if (y <= Math.Sqrt(1 - x * x))
                {
                    if (x <= 0)
                    {
                        ok = true;
                    }
                    else
                    {
                        if ((0.3 * 0.3 - (x * x)) < 1)
                        {
                            ok = true;
                        }
                        else
                        {
                            if (y >= Math.Sqrt(0.3 * 0.3 - (x * x)))
                            {
                                ok = true;
                            }

                        }
                        
                    }
                }
                
            }
            double u = 0;
            if (ok)
            {
                u = x * x * x - 1;
            }
            else
            {
                u = Math.Sqrt(Math.Abs(x - 1));
            }
            Console.WriteLine("u= "+u);
            Console.ReadLine();
            
        }
        static double DoubleCheck()
        {
            double n;
            bool ok = false;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string s = Console.ReadLine();
            do
            {
                ok = double.TryParse(s, out n);
                if (ok == false)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Ввод неправильный. Повторите.");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    s = Console.ReadLine();
                }
            } while (!ok);
            Console.ForegroundColor = ConsoleColor.White;
            return (n);
        }
    }
}
