using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdotePet.controller
{
    public class Inputs
    {
        public int ReceberNumeroInteiro(string? inteiro)
        {
            while (true)
            {
                bool input = int.TryParse(inteiro, out int numeroRecebido);
                if (input == false)
                {
                    Console.Write("Opção invalida, tente novamente: ");
                    inteiro = Console.ReadLine();
                }
                else
                {
                    return numeroRecebido;
                }
            }
        }
        public double ReceberNumeroFlutuante()
        {
            while (true)
            {
                bool input = double.TryParse(Console.ReadLine(), out double numeroRecebido);
                if (input == false)
                {
                    Console.Write("Opção invalida, tente novamente: ");
                }
                else
                {
                    return numeroRecebido;
                }
            }
        }

        public string ReceberTexto(string? texto)
        {
            while (true)
            {

                if (!string.IsNullOrEmpty(texto))
                {
                    return texto;
                }
                else
                {
                    Console.Write("\nO valor informado não pode ser vazio\nTente novamente: ");
                    texto = Console.ReadLine();
                }
            }
        }

        public string ReceberTextoVazio(string? texto) => !string.IsNullOrEmpty(texto) ? texto : "Não Informado";
    }
}