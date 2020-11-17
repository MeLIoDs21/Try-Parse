using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Me_Bruh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a whole number: ");
            int? a;
            TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Talet du skrev är: "+ a);
            System.Threading.Thread.Sleep(3000);
        }


        public static bool TryParse(string _A, out int? _Number)
        {
            try
            {
                _Number = Convert.ToInt32(_A);
                return true;
            }
            catch(FormatException)
            {
                Console.WriteLine("Felaktig inmättning! Använd bara Heltal.");
                _Number = null;
                return false;
            }
            catch(OverflowException)
            {
                Console.WriteLine("Felaktig inmättning! Talet är för stort.");
                _Number = null;
                return false;
            }




        }
    }
}
