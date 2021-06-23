using System.Collections.Generic;
using ExemploMvcEplayers.Models;

namespace ExemploMvcEplayers.Interfaces
{
    public interface IJogador
    {
        void Criar(Jogador j);

        List<Jogador> LerTodos();

        void Alterar(Jogador j);

        void Deletar(int id); 
    }
}