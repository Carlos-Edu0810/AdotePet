# AdotePet 🐾

Este projeto, **AdotePet**, é uma aplicação de console desenvolvida em C# para simular um sistema de gerenciamento de adoção de animais. Ele foi criado por **Carlos Ramos** com propósitos didáticos, explorando conceitos de programação orientada a objetos (POO), manipulação de arquivos JSON para persistência de dados e interatividade via console.

## Funcionalidades ✨

O sistema **AdotePet** permite:

* **Cadastro de Animais:** 🐶 Registre novos animais com informações como nome, idade, espécie, personalidade e histórico.
* **Cadastro de Pessoas:** 🧑‍🦱 Cadastre pessoas interessadas em adotar, com nome, idade (maiores de 18 anos) e endereço.
* **Registro de Adoções:** ❤️‍🩹 Associe um animal disponível a uma pessoa apta a adotar.
* **Relatórios:** 📊
    * Buscar pessoas por nome ou listar todos os cadastros.
    * Buscar animais por nome ou espécie, listar todos os animais ou listar apenas os animais disponíveis para adoção.

## Estrutura do Projeto 🏗️

O projeto é dividido em módulos para organizar as responsabilidades:

* **`Program.cs`**: O ponto de entrada da aplicação, responsável pelo menu principal e pela orquestração das chamadas aos controladores.
* **`Controllers/`**: Contém as classes controladoras que gerenciam a lógica de negócios e a interação com os dados:
    * **`AdocaoController.cs`**: Gerencia o registro e a listagem de adoções.
    * **`AnimalController.cs`**: Gerencia o cadastro, a atualização e a listagem de animais.
    * **`PessoaController.cs`**: Gerencia o cadastro e a listagem de pessoas.
    * **`Autoincrem.cs`**: Responsável por gerar IDs únicos para pessoas e animais.
    * **`Inputs.cs`**: Oferece métodos para validação de entradas do usuário (números e textos).
* **`Models/`**: Contém as classes de modelo que representam as entidades do sistema:
    * **`Adocao.cs`**: Define a estrutura de uma adoção, associando uma pessoa a um animal e uma data.
    * **`Animal.cs`**: Define a estrutura de um animal, incluindo suas características e status de disponibilidade para adoção.
    * **`Pessoa.cs`**: Define a estrutura de uma pessoa, incluindo suas informações pessoais.

## Persistência de Dados 💾

Os dados são armazenados em arquivos JSON localmente, simulando um banco de dados simples. Os arquivos são salvos no diretório `C:\Workspace\AdotePet\Database\` e incluem:

* `Animais.Json`
* `Pessoas.Json`
* `Adocoes.Json`

## Como Executar ▶️

Para executar este projeto, siga os passos abaixo:

1.  **Clone o repositório** (se estiver em um).
2.  **Abra a solução** no Visual Studio ou em outra IDE compatível com .NET.
3.  **Restaure os pacotes NuGet** (se necessário). As dependências incluem `Newtonsoft.Json` para serialização/desserialização de JSON.
4.  **Verifique os diretórios de banco de dados**: Certifique-se de que a pasta `C:\Workspace\AdotePet\Database\` exista em seu sistema, ou altere os caminhos nos arquivos `AnimalController.cs`, `PessoaController.cs` e `AdocaoController.cs` para um diretório de sua preferência.
5.  **Compile e execute** a aplicação.

O sistema será iniciado no console, apresentando o menu principal para interação.

## Contribuição 🤝

Este projeto é um esforço pessoal e didático de **Carlos Ramos**. Sugestões e melhorias são bem-vindas para fins de aprendizado e aprimoramento do código.
