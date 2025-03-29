using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdotePet.models
{
    public class Pessoa
    {
        public string? Id { get; set; }
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Endereco { get; set; }
        public Pessoa(string id, string nome, int idade, string endereco)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
        }
    }
}