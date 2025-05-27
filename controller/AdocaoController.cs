using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdotePet.models;
using Newtonsoft.Json;

namespace AdotePet.controller
{
    public class AdocaoController
    {
        private List<Adocao> Adocoes = new();

        private string AdocoesSerializadas = string.Empty;
        private string Diretorio = @"C:\Workspace\AdotePet\Database\Adocoes.Json";
        AnimalController Animal = new();

        public string RegistrarAdocao(Pessoa adotante, Animal adotado, out string status)
        {
            List<Animal> animaisDisponiveis = Animal.AnimalDisponivelParaAdocao();
            if (animaisDisponiveis.FindIndex(x => x.Id == adotado.Id) != -1 && adotado.AdocaoDisponivel == 'S')
            {
                RegistrarAdocao(new Adocao(adotante, adotado, DateTime.Now));
                Animal.AnimalAdotado(adotado);
                status = "Animal Adotado com Sucesso";
                return status;
            }
            else
            {
                status = "Animal não esta disponivel para Adoção";
                return status;
            }

        }

        public List<Adocao> ListaDeAdocoes()
        {
            AdocoesSerializadas = File.ReadAllText(Diretorio);
            // AdocoesSerializadas = string.IsNullOrEmpty(File.ReadAllText(Diretorio)) ? string.Empty : File.ReadAllText(Diretorio);
            List<Adocao> ListaDeAdocoesAtual = JsonConvert.DeserializeObject<List<Adocao>>(AdocoesSerializadas) ?? new();
            return ListaDeAdocoesAtual;
        }

        private void RegistrarAdocao(Adocao adocao)
        {
            Adocoes = ListaDeAdocoes();
            Adocoes.Add(adocao);
            AdocoesSerializadas = JsonConvert.SerializeObject(Adocoes, Formatting.Indented);
            File.WriteAllText(Diretorio, AdocoesSerializadas);
        }
    }
}