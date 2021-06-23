using System.Collections.Generic;
using ExemploMvcEplayers.Models;

namespace ExemploMvcEplayers.Interfaces
{
    public interface IEquipe
    {
        void Criar(Equipe e);

        List<Equipe> LerTodas();

        void Alterar(Equipe e);

        void Deletar(int id);
    }
}