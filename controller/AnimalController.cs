using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AdotePet.controller;
using AdotePet.models;
using Newtonsoft.Json;

namespace AdotePet.controller
{
    public class AnimalController
    {
        private List<Animal> animais = new List<Animal>();
        private Autoincrem auto = new();
        Inputs input = new();
        string serializado = string.Empty;
        const string diretorio = @"C:\Workspace\AdotePet\Database\Animais.Json";

        public List<Animal> AnimalDisponivelParaAdocao() => ListaDeAnimais().Where(x => x.AdocaoDisponivel == 'S').ToList();
        public void AnimalAdotado(Animal adotado)
        {
            animais = ListaDeAnimais();
            int localizarAnimal = animais.FindIndex(x => x.Id == adotado.Id);
            adotado.AdocaoDisponivel = 'N';
            animais[localizarAnimal] = adotado;
            AtualizarLista(animais);
        }

        public List<Animal> ListaDeAnimais()
        {
            serializado = File.ReadAllText(diretorio);
            List<Animal> listaDeAnimais = JsonConvert.DeserializeObject<List<Animal>>(serializado) ?? new List<Animal>();
            return listaDeAnimais;
        }
        private void AdicionarNaLista(Animal animal)
        {
            animais = ListaDeAnimais();
            animais.Add(animal);
            AtualizarLista(animais);
        }
        private void AtualizarLista(List<Animal> listaAnimal)
        {
            serializado = JsonConvert.SerializeObject(animais, Formatting.Indented);
            File.WriteAllText(diretorio, serializado);
        }

        public void CadastrarAnimal(string nome, int idade, string especie, string personalidade, string historia)
        {
            string id = auto.CriarAutoincremVerificado(animais);
            Animal novoAnimal = new(id, nome, idade, especie, personalidade, historia, 'S');
            AdicionarNaLista(novoAnimal);
        }

        public void ListarAnimais(int listarOpcoes)
        {
            animais = ListaDeAnimais();
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
                case 4:
                    if (animais.Exists(x => x.AdocaoDisponivel == 'S'))
                    {
                        foreach (Animal animal in AnimalDisponivelParaAdocao())
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
                        Console.WriteLine("Não existe animais disponiveis para adoção");
                    }
                    break;
            }
        }

        public Animal this[int index]
        {
            // get => animais[index];
            get
            {
                animais = ListaDeAnimais();
                return animais[index];
            }
        }
    }
}