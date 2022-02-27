using System;
using System.Collections.Generic;
using System.Text;
using Projeto_De_Cadastro.Interfaces;

namespace Projeto_De_Cadastro
{
    class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
           
        }

        public void Excluir(int id)
        {
            listaSerie[id].RetornaExcluido();
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}
