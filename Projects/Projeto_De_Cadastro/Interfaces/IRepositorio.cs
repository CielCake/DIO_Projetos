using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_De_Cadastro.Interfaces
{
    interface IRepositorio <T>
    {
        List<T> Lista(); //Retorna uma lista de "T".
        T RetornaPorId(int id); //Através de um ID retorna o "T"
        void Insere(T entidade);
        void Excluir(int id);
        void Atualiza(int id, T entidade);
        int ProximoId(); //Retorna o próximo ID.
    }
}
