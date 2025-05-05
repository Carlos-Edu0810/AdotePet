using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using AdotePet.controller;
using AdotePet.models;

Inputs input = new();
PessoaController pessoa = new();
AnimalController animal = new();
AdocaoController adocao = new();

adocao.RegistrarAdocao(pessoa[1], animal[3], out string status);
Console.WriteLine(status);


// Menu();

// void Menu()
// {
//     // Console.Clear();
//     Console.WriteLine("=== AdotePet ===");
//     Console.WriteLine("1- Cadastros");
//     Console.WriteLine("2- Adotar");
//     Console.WriteLine("3- Relatorios");
//     Console.WriteLine("4- Sair");
//     Console.Write("Selecione a opção desejada: ");
//     int opcoesMenu = input.ReceberNumeroInteiro(Console.ReadLine());
//     switch (opcoesMenu)
//     {
//         case 1:
//             Cadastro();
//             break;
//         case 2: break;
//         case 3: Relatorios(); break;
//         case 4: Environment.Exit(0); break;
//         default: Menu(); break;
//     }
//     Menu();
// }

// void Cadastro()
// {
//     Console.Clear();
//     Console.WriteLine("=== Cadastros ===");
//     Console.WriteLine("1- Animal");
//     Console.WriteLine("2- Pessoa");
//     Console.WriteLine("3- Retornar ao Menu");
//     Console.Write("Selecione a opção desejada: ");
//     int opcoesMenu = input.ReceberNumeroInteiro(Console.ReadLine());
//     switch (opcoesMenu)
//     {
//         case 1:
//             Console.Clear();
//             Console.WriteLine("=== Cadastro de Animais ===");
//             Console.Write("Nome: ");
//             string nomeAnimal = input.ReceberTexto(Console.ReadLine());

//             Console.Write("\nIdade: ");
//             int idadeAnimal = input.ReceberNumeroInteiro(Console.ReadLine());

//             Console.Write("\nEspecie: ");
//             string especie = input.ReceberTexto(Console.ReadLine());

//             Console.Write("\nPersonalidade: ");
//             string personalidade = input.ReceberTextoVazio(Console.ReadLine());

//             Console.Write("\nHistoria: ");
//             string historia = input.ReceberTextoVazio(Console.ReadLine());

//             animal.CadastrarAnimal(nomeAnimal, idadeAnimal, especie, personalidade, historia);
//             break;
//         case 2:
//             Console.Clear();
//             Console.WriteLine("=== Cadastro de Pessoas ===");
//             Console.Write("Nome: ");
//             string nome = input.ReceberTexto(Console.ReadLine());

//             Console.Write("\nIdade: ");
//             bool idadeValida;
//             int idade;
//             do
//             {
//                 idade = input.ReceberNumeroInteiro(Console.ReadLine());
//                 idadeValida = idade >= 18;
//                 if (!idadeValida)
//                     Console.Write("\nIdade invalida, para adotar tem que ser maior que 18 anos.\nIdade: ");

//             } while (!idadeValida);

//             Console.Write("\nEndereço: ");
//             string endereco = input.ReceberTexto(Console.ReadLine());
//             pessoa.CadastrarPessoa(nome, idade, endereco);
//             break;
//         case 3: Menu(); break;
//         default: Cadastro(); break;
//     }
//     Menu();
// }

// void Relatorios()
// {
//     Console.WriteLine("=== Relatorios  ===");
//     Console.WriteLine("1. Buscar Pessoas");
//     Console.WriteLine("2. Buscar Animais");
//     Console.WriteLine("3. Buscar Adoções");
//     Console.WriteLine("4. Voltar ao Menu");
//     Console.Write("Selecione a opção desejada: ");
//     int opcoesMenu = input.ReceberNumeroInteiro(Console.ReadLine());
//     switch (opcoesMenu)
//     {
//         case 1:
//             Console.WriteLine("Relatorio de Pessoas");
//             Console.WriteLine("1. Buscar por Nome");
//             Console.WriteLine("2. Listar todos os Cadastros");
//             Console.WriteLine("3. Retornar para Relatorios");
//             Console.WriteLine("4. Retornar para Menu");
//             int opcaoRelatorio = input.ReceberNumeroInteiro(Console.ReadLine());
//             switch (opcaoRelatorio)
//             {
//                 case 1: pessoa.ListarPessoas(1); break;
//                 case 2: pessoa.ListarPessoas(2); break;
//                 case 3: Relatorios(); break;
//                 default: Menu(); break;
//             }
//             break;
//         case 2:
//             Console.WriteLine("Relatorio de Animais");
//             Console.WriteLine("1. Buscar por Nome");
//             Console.WriteLine("2. Buscar por Especies");
//             Console.WriteLine("3. Listar todos os Cadastros");
//             Console.WriteLine("4. Retornar para Relatorios");
//             Console.WriteLine("5. Retornar para Menu");
//             Console.Write("Selecione a opção desejada: ");
//             opcoesMenu = input.ReceberNumeroInteiro(Console.ReadLine());
//             switch (opcoesMenu)
//             {
//                 case 1: animal.ListarAnimais(1); break;
//                 case 2: animal.ListarAnimais(2); break;
//                 case 3: animal.ListarAnimais(3); break;
//                 case 4: Relatorios(); break;
//                 default: Menu(); break;
//             }
//             break;
//         case 3: break;
//         case 4: Menu(); break;
//         default: Relatorios(); break;
//     }
// }