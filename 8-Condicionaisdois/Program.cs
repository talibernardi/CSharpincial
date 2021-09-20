using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionaisdois
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 8 - Condicionais 2");
            int idadeJoao = 16;
            int quantidadePessoas = 2;

            bool acompanhado = quantidadePessoas >= 2;

            // int quantidadePessoas  2;
            // bool acompanhado = true;

            if (idadeJoao >= 18 && acompanhado == false)
            {
                Console.WriteLine("João pode entrar.");
            }
            else
            {
                Console.WriteLine("João não pode entrar");
            }

            Console.ReadLine();
        }
    }

}