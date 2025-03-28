using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace AdotePet.models
{
    public class Animal
    {
        public string? Id { get; set; }
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public char Especie { get; set; }
        public string? Personalidade { get; set; }

        public Animal(string id, string nome, int idade, char especie, string personalidade)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Especie = especie;
            Personalidade = personalidade;
        }

    }
}