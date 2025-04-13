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
        public void CadastrarAnimal(string nome, int idade, string especie, string personalidade, string historia)
        {
            string id = auto.CriarAutoincremVerificado(animais);

            Animal novoAnimal = new(id, nome, idade, especie, personalidade, historia);
            animais.Add(novoAnimal);
        }

    }
}