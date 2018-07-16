using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double result = Divide(13.4, 0);
                Console.WriteLine(result);
            }
            
            catch (ArgumentException e)
            {
                //Console.WriteLine(e.StackTrace);
                //Console.WriteLine(e.Message);
                Console.WriteLine(e.ToString());
            }
            catch (InvalidOperationException ix)
            {
                Console.WriteLine("Elkaptam");
            }
            catch/* (Exception ex)*/
            {
                Console.WriteLine("Minden kivételt elkapok");
            }

            Console.ReadKey();
        }

        static double Divide(double a, int b)
        {
            if (b == 0)
                throw new InvalidOperationException("Nem lehet 0-val osztani");

            return a / b;
        }
    }
}
