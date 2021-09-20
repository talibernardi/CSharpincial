using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 4");
            double salario = 1200.50;

            //o int é um tipo de variavel que suporta valores de até 32 bits
            int salarioEmInteiro = (int)salario;
            

            Console.WriteLine(salarioEmInteiro);
            

            //o long é um variavel de 64 bits
            long idade = 130000000000000;
            Console.WriteLine(idade);

            //o short é um tipo de variavel de 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);
            

            Console.ReadLine();
        }
    }
}
