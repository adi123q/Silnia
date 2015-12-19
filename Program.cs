using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace silnia
{
    
    class Program
    {
        public static int Silnie(int a)
        {
            int suma = 1, silnia = 1, i = 1;

            while (a>i)
            {
                suma = a;
                silnia *= suma;
                a--;
            }
            return silnia;
        }

        static void Main(string[] args)
        {
            for (;;)
            {
                int b;
                Console.WriteLine("Podaj z jakiej liczby chcesz obliczyc silnie: ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("SILNIA WYNOSI: "+Silnie(b));
                
            }
        }
        
    }
}
