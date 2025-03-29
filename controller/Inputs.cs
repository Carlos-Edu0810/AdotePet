using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdotePet.controller
{
    public class Inputs
    {
        public int ReceberNumeroInteiro()
        {
            while (true)
            {
                bool input = int.TryParse(Console.ReadLine(), out int numeroRecebido);
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

        public string ReceberTexto()
        {
            while (true)
            {
                string? textoRecebido = Console.ReadLine();
                if (!string.IsNullOrEmpty(textoRecebido))
                {
                    return textoRecebido;
                }
            }
        }
    }
}