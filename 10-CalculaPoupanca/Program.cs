using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 10 - Calcula Poupanca");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido * 0.0036);

                //contadorMes = contadorMes + 1;
                //contadorMes += 1;
                contadorMes++;

                
            }



            Console.ReadLine();
        }
    }
}
