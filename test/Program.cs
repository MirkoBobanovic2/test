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
            int xy;

            

            Console.WriteLine("upisi neki broj za koji zelis kvadratni korijen:");

            
           string unos = Console.ReadLine();
            try
            {
                double broj = double.Parse(unos);
                double rezultat = KvadratniKoijen(broj);
                Console.WriteLine($"Kvadrani Korijen Od {broj} je {rezultat}");
               
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
