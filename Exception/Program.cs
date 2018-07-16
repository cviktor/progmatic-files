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
            //try
            //{
            //    double result = Divide(13.4, 0);
            //    Console.WriteLine(result);
            //}
            //catch (ArgumentException e)
            //{
            //    //Console.WriteLine(e.StackTrace);
            //    //Console.WriteLine(e.Message);
            //    Console.WriteLine(e.ToString());
            //}
            //catch (InvalidOperationException ix)
            //{
            //    Console.WriteLine("Elkaptam");
            //}
            //catch/* (Exception ex)*/
            //{
            //    Console.WriteLine("Minden kivételt elkapok");
            //}

            try
            {
                Person p = new Person();
                //p.Salary = -1000;
                SetSalary(p);
                Console.WriteLine("Person fizetése: " + p.Salary);
            }
            catch (InvalidSalaryException ise)
            {
                Console.WriteLine("Hibás fizetés: " + ise.InvalidSalary);
                Console.WriteLine(ise.ToString());
            }

            Console.ReadKey();
        }

        static void SetSalary(Person p)
        {
            try
            {
                Console.WriteLine("Kérem adja meg a fizetést");
                string line = Console.ReadLine();
                int salary = int.Parse(line);
                p.Salary = salary;
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Hibás szám formátum");
            }
            catch (InvalidSalaryException ise)
            {
                Console.WriteLine("Hibás érték\n" + ise.ToString());
                //throw ise; ROSSZ MEGOLDÁS SOSE CSINÁLUNK ILYET
                throw;
            }
            finally
            {
                Console.WriteLine("Lefutott a SetSalary");
            }
        }

        static double Divide(double a, int b)
        {
            if (b == 0)
                throw new InvalidOperationException("Nem lehet 0-val osztani");

            return a / b;
        }
    }
}
