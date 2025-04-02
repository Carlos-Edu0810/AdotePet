using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AdotePet.controller;
using AdotePet.models;

Inputs input = new();

Menu();


void Menu()
{
    //Console.Clear();
    Console.WriteLine("=== AdotePet ===");
    Console.WriteLine("1- Cadastros");
    Console.WriteLine("2- Adotar");
    Console.WriteLine("3- Relatorios");
    Console.WriteLine("4- Sair");
    Console.Write("Selecione a opção desejada: ");
    int opcoesMenu = input.ReceberNumeroInteiro(Console.ReadLine());
    switch (opcoesMenu)
    {
        case 1:
            Cadastro();
            break;
        case 2: break;
        case 3: break;
        case 4: Environment.Exit(0); break;
        default: Menu(); break;
    }
}

void Cadastro()
{
    //Console.Clear();
    Console.WriteLine("=== Cadastros ===");
    Console.WriteLine("1- Animal");
    Console.WriteLine("2- Pessoa");
    Console.WriteLine("3- Retornar ao Menu");
    int opcoesMenu = input.ReceberNumeroInteiro(Console.ReadLine());
    switch (opcoesMenu)
    {
        case 1: break;
        case 2:
            PessoaController pessoa = new();
            Console.WriteLine("=== Cadastro de Pessoas ===");
            Console.Write("Nome: ");
            string nome = input.ReceberTexto(Console.ReadLine());

            Console.Write("\nIdade: ");
            bool idadeValida;
            int idade;
            do
            {
                idade = input.ReceberNumeroInteiro(Console.ReadLine());
                idadeValida = idade >= 18;
                if (!idadeValida)
                    Console.Write("\nIdade invalida, para adotar tem que ser maior que 18 anos.\nIdade: ");

            } while (!idadeValida);

            Console.Write("\nEndereço: ");
            string endereco = input.ReceberTexto(Console.ReadLine());

            pessoa.CadastrarPessoa(nome, idade, endereco);
            break;
        case 3: Menu(); break;
        default: Cadastro(); break;
    }
    Menu();
}


// List<Pessoa> pessoa = new List<Pessoa>();
// List<Animal> animal = new List<Animal>();
// Autoincrem autoincrem = new();

// string idPessoa = autoincrem.CriarAutoincremVerificado(null, pessoa);
// string idAnimal = autoincrem.CriarAutoincremVerificado(animal);
// Console.WriteLine($"Pessoa: {idPessoa}");
// Console.WriteLine($"Animal: {idAnimal}");
