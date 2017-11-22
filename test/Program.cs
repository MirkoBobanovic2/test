using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace test
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Porukkaaa");
            Console.WriteLine("message");
            Console.WriteLine("Werbung");

            
           string unos = Console.ReadLine();
            try
            {
                double broj = double.Parse(unos);
                Console.WriteLine(KvadratniKoijen(broj));
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }

        public static double KvadratniKoijen(double broj)
        {
            return Math.Sqrt(broj);
        }
        
    }
}
