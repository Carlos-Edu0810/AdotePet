using AdotePet.controller;
using AdotePet.models;

Autoincrem autoincrem = new();
Animal animal = new();
List<Animal> animais = new List<Animal>();

animal.Id = autoincrem.CriarAutoincremVerificado(animais);
animal.Nome = "teste1";
animal.Personalidade = "teste2";
animal.tipo = 'G';
animais.Add(animal);