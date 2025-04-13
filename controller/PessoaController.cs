using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdotePet.models;

namespace AdotePet.controller
{
    public class PessoaController
    {
        public List<Pessoa> pessoas = new List<Pessoa>();
        Inputs input = new();
        Autoincrem autoincrem = new();
        public void CriarCadastros()
        {
            pessoas.Add(new Pessoa("001", "Ana", 25, "Rua das Flores, 100"));
            pessoas.Add(new Pessoa("002", "Bruno", 30, "Av. Central, 200"));
            pessoas.Add(new Pessoa("003", "Carla", 22, "Rua da Paz, 300"));
            pessoas.Add(new Pessoa("004", "Diego", 28, "Rua Nova, 150"));
            pessoas.Add(new Pessoa("005", "Eduarda", 35, "Travessa Verde, 45"));
        }
        public void CadastrarPessoa(string nome, int idade, string endereco)
        {
            string id = autoincrem.CriarAutoincremVerificado(pessoas);

            Pessoa novaPessoa = new(id, nome, idade, endereco);
            pessoas.Add(novaPessoa);
        }

        public void ListarPessoas(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    Console.Write("Insira o nome do cadastro: ");
                    string buscaNome = input.ReceberTexto(Console.ReadLine());
                    List<Pessoa> indice = new();
                    foreach (Pessoa pessoa in pessoas)
                    {
                        if (pessoa.Nome == buscaNome)
                        {
                            indice.Add(pessoa);
                        }
                    }
                    if (pessoas.FindIndex(p => p.Nome == buscaNome) != -1)
                    {
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
    }
}