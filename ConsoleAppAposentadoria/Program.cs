using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAposentadoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos anos você tem: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("A quantos anos ingressou na empresa: ");
            int anoi = int.Parse(Console.ReadLine());

           
            if (id <= 65 && anoi >= 30 || id >= 60 && anoi >= 25)
            {
                Console.WriteLine("Tem direito a aposentadoria.");
            }
            else 
            {
                Console.WriteLine("Não tem direito a aposentadoria.");
            }

            Console.ReadKey();  

        }
    }
}
