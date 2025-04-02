using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdotePet.controller;

namespace AdotePet.models
{
    public class Pessoa
    {
        private string _nome = string.Empty;
        public string Id { get; set; }
        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }
        public int Idade { get; set; }
        public string Endereco { get; set; }
        public Pessoa(string id, string nome, int idade, string endereco)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
        }
    }
}