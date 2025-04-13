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
        Inputs input = new();

        /*
            1. X8F2B1LZQ7MA
            2. N3KJ9W0T2VCE
            3. H7X2LZQ9N5RB
            4. M1P9T6KD8WJQ
            5. B4ZT3YVWQ9LN

        */

        public void CriarCadastros()
        {
            animais.Add(new Animal("X8F2B1LZQ7MA", "Sinistra", 9, "Gato", "Carinhosa", "Não informado"));
            animais.Add(new Animal("N3KJ9W0T2VCE", "Thor", 5, "Cachorro", "Protetor", "Não informado"));
            animais.Add(new Animal("H7X2LZQ9N5RB", "Mimi", 2, "Gato", "Brincalhona", "Não informado"));
            animais.Add(new Animal("M1P9T6KD8WJQ", "Luna", 4, "Coelho", "Curiosa", "Não informado"));
            animais.Add(new Animal("B4ZT3YVWQ9LN", "Spike", 7, "Cachorro", "Agitado", "Não informado"));

        }

        public void CadastrarAnimal(string nome, int idade, string especie, string personalidade, string historia)
        {
            string id = auto.CriarAutoincremVerificado(animais);

            Animal novoAnimal = new(id, nome, idade, especie, personalidade, historia);
            animais.Add(novoAnimal);
        }

        public void ListarAnimais(int listarOpcoes)
        {
            switch (listarOpcoes)
            {
                case 1:
                    Console.Write("Insira o nome do animal: ");
                    string nomeAnimal = input.ReceberTexto(Console.ReadLine()).ToUpper();
                    if (animais.FindIndex(a => a.Nome == nomeAnimal) != -1)
                    {
                        List<Animal> indice = animais.FindAll(a => a.Nome == nomeAnimal);
                        foreach (Animal animal in indice)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"ID: {animal.Id}");
                            Console.WriteLine($"Nome: {animal.Nome}");
                            Console.WriteLine($"Idade: {animal.Idade}");
                            Console.WriteLine($"Especie: {animal.Especie}");
                            Console.WriteLine($"Personaldade: {animal.Personalidade}");
                            Console.WriteLine($"Historia: {animal.Historia}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhum animal encontrado com esse nome.");
                    }
                    break;
                case 2:
                    Console.Write("Insira a especie do animal: ");
                    string especieAnimal = input.ReceberTexto(Console.ReadLine()).ToUpper();
                    if (animais.FindIndex(a => a.Especie == especieAnimal) != -1)
                    {
                        List<Animal> indice = animais.FindAll(a => a.Especie == especieAnimal);
                        foreach (Animal animal in indice)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"ID: {animal.Id}");
                            Console.WriteLine($"Nome: {animal.Nome}");
                            Console.WriteLine($"Idade: {animal.Idade}");
                            Console.WriteLine($"Especie: {animal.Especie}");
                            Console.WriteLine($"Personaldade: {animal.Personalidade}");
                            Console.WriteLine($"Historia: {animal.Historia}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhum animal encontrado com essa especie.");
                    }
                    break;
                case 3:
                    if (animais.Count > 0)
                    {
                        foreach (Animal animal in animais)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"ID: {animal.Id}");
                            Console.WriteLine($"Nome: {animal.Nome}");
                            Console.WriteLine($"Idade: {animal.Idade}");
                            Console.WriteLine($"Especie: {animal.Especie}");
                            Console.WriteLine($"Personaldade: {animal.Personalidade}");
                            Console.WriteLine($"Historia: {animal.Historia}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Não existe animais cadastros");
                    }
                    break;
            }
        }

    }
}