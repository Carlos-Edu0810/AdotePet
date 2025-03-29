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

        public string CriarAutoincremVerificado(List<Animal>? animais, List<Pessoa>? pessoas = null)
        {
            string id = GerarAutoincrem();
            bool revalidacao;
            if (animais != null)
            {
                do
                {
                    revalidacao = false;
                    for (int i = 0; i < animais.Count; i++)
                    {
                        if (animais[i].Id == id)
                        {
                            id = GerarAutoincrem();
                            revalidacao = true;
                        }
                    }
                } while (revalidacao != false);
            }
            else if (pessoas != null)
            {
                do
                {
                    revalidacao = false;
                    for (int i = 0; i < pessoas.Count; i++)
                    {
                        if (pessoas[i].Id == id)
                        {
                            id = GerarAutoincrem();
                            revalidacao = true;
                        }
                    }
                } while (revalidacao != false);
            }
            return id;
        }
    }
}