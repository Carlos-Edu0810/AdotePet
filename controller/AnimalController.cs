using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdotePet.controller;
using AdotePet.models;

namespace AdotePet.controller
{
    public class AnimalController
    {
        public List<Animal> animais = new List<Animal>();
        private Autoincrem auto = new();
        public void CadastrarAnimal(string nome, int idade, char especie, string personalidade = "")
        {
            string id = auto.CriarAutoincremVerificado(animais);
            Animal novoAnimal = new(id, nome, idade, especie, personalidade);
            animais.Add(novoAnimal);
        }

    }
}