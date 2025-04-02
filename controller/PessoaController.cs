using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdotePet.models;

namespace AdotePet.controller
{
    public class PessoaController
    {
        public List<Pessoa> pessoas = new List<Pessoa>();
        public Inputs input = new();
        Autoincrem autoincrem = new();
        public void CadastrarPessoa(string nome, int idade, string endereco)
        {
            string id = autoincrem.CriarAutoincremVerificado(null, pessoas);

            Pessoa novaPessoa = new(id, nome, idade, endereco);
            pessoas.Add(novaPessoa);
        }
    }
}