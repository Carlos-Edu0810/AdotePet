using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdotePet.models;

namespace AdotePet.controller
{
    public class Autoincrem
    {
        private string GerarAutoincrem()
        {
            Random random = new();
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            char[] autoincrem = new char[12];
            for (int i = 0; i < autoincrem.Length; i++)
            {
                autoincrem[i] = caracteres[random.Next(caracteres.Length)];
            }
            return new string(autoincrem);
        }

        public string CriarAutoincremVerificado(List<Animal> animais)
        {
            string id = GerarAutoincrem();

            bool revalidacao;
            do
            {
                revalidacao = false;
                for (int i = 0; i < animais.Count; i++)
                {
                    Console.WriteLine("Autoincrem sendo verificado...");
                    if (animais[i].Id == id)
                    {
                        Console.WriteLine("Ja gerado...");
                        id = GerarAutoincrem();
                        revalidacao = true;
                    }
                }
            } while (revalidacao != false);
            Console.WriteLine("Autoincrem validado!");
            return id;
        }
    }
}