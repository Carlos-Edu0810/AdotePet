using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdotePet.models
{
    public class Adocao
    {
        public Adocao(Pessoa pessoaAdotante, Animal animalAdotado, DateTime dataAdocao)
        {
            PessoaAdotante = pessoaAdotante;
            AnimalAdotado = animalAdotado;
            DataAdocao = dataAdocao;
        }

        public Pessoa PessoaAdotante { get; set; }
        public Animal AnimalAdotado { get; set; }
        public DateTime DataAdocao { get; set; }
    }
}