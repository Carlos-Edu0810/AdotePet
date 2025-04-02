using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace AdotePet.models
{
    public class Animal
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Especie { get; set; }
        public string Personalidade { get; set; }
        public string Historia { get; set; }

        public Animal(string id, string nome, int idade, string especie, string personalidade, string historia)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Especie = especie;
            Personalidade = personalidade;
            Historia = historia;
        }

    }
}