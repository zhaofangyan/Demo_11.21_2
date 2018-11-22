using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.ServiceReference1;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
          using (CalculatorServiceClient proxy = new CalculatorServiceClient())
           {
                Calculator t1 = new Calculator { x1 = 1 };
                Calculator t2 = new Calculator { y1 = 2 };
                Console.WriteLine("x + y = {2} when x = {0} and y = {1}", t1.x1, t2.y1, proxy.AddExy(t1, t2).tp);
                Console.WriteLine("x - y = {2} when x = {0} and y = {1}", t1.x1, t2.y1, proxy.Subtract(t1, t2).tp);
                Console.WriteLine("x * y = {2} when x = {0} and y = {1}", t1.x1, t2.y1, proxy.Multiply(t1, t2).tp);
                Console.WriteLine("x / y = {2} when x = {0} and y = {1}", t1.x1, t2.y1, proxy.Divide(t1, t2).tp);
                Console.ReadKey();

                 }
            }
    }
}
