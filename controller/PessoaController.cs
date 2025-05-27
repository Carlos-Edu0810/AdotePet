using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdotePet.models;
using Newtonsoft.Json;

namespace AdotePet.controller
{
    public class PessoaController
    {
        private List<Pessoa> pessoas = new List<Pessoa>();
        Inputs input = new();
        Autoincrem autoincrem = new();
        private string serializado = string.Empty;
        private const string diretorio = @"C:\Workspace\AdotePet\Database\Pessoas.Json";

        public List<Pessoa> ListaDePessoas()
        {
            string serializado = File.ReadAllText(diretorio);
            List<Pessoa> listaDePessoas = JsonConvert.DeserializeObject<List<Pessoa>>(serializado) ?? new List<Pessoa>();
            return listaDePessoas;
        }
        private void AdicionarNaLista(Pessoa pessoa)
        {
            pessoas = ListaDePessoas();
            pessoas.Add(pessoa);
            serializado = JsonConvert.SerializeObject(pessoas, Formatting.Indented);
            File.WriteAllText(diretorio, serializado);
        }

        public void CadastrarPessoa(string nome, int idade, string endereco)
        {
            string id = autoincrem.CriarAutoincremVerificado(pessoas);

            Pessoa novaPessoa = new(id, nome, idade, endereco);
            AdicionarNaLista(novaPessoa);
        }

        public void ListarPessoas(int opcao)
        {
            pessoas = ListaDePessoas();
            switch (opcao)
            {
                case 1:
                    Console.Write("Insira o nome do cadastro: ");
                    string buscaNome = input.ReceberTexto(Console.ReadLine());
                    if (pessoas.FindIndex(p => p.Nome == buscaNome) != -1)
                    {
                        List<Pessoa> indice = pessoas.FindAll(p => p.Nome == buscaNome);
                        foreach (Pessoa pessoaIndice in indice)
                        {
                            Console.WriteLine();
                            Console.WriteLine("ID: " + pessoaIndice.Id);
                            Console.WriteLine("Nome: " + pessoaIndice.Nome);
                            Console.WriteLine("Idade: " + pessoaIndice.Idade);
                            Console.WriteLine("Endereço: " + pessoaIndice.Endereco);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhum cadastro encontrado com esse nome!");
                    }
                    Console.ReadKey();
                    break;
                case 2:
                    foreach (Pessoa pessoa in pessoas)
                    {
                        Console.WriteLine();
                        Console.WriteLine("ID: " + pessoa.Id);
                        Console.WriteLine("Nome: " + pessoa.Nome);
                        Console.WriteLine("Idade: " + pessoa.Idade);
                        Console.WriteLine("Endereço: " + pessoa.Endereco);
                    }
                    break;
                case 3: break;
            }
        }

        public Pessoa this[int index]
        {
            // get => pessoas[index];
            get
            {
                pessoas = ListaDePessoas();
                return pessoas[index];
            }
        }
    }
}