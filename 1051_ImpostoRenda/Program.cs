using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1051_ImpostoRenda
{
    class Program
    {
        static void Main(string[] args)
        {


            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto;

            if (salario <= 2000)
            {
                imposto = 0.0;
            }
            else if(salario <= 3000)
            {
                imposto = (salario - 2000) * 0.08;
            }
            else if (salario <= 4500)
            {
                imposto = (salario - 3000) * 0.18 + 1000 * 0.08;
            }
            else
            {
                imposto = (salario - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            } else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }


            
            Console.ReadLine();        
        }
    }
}
