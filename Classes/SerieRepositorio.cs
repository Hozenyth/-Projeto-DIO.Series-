using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Serie>

    {
        private List<Serie> listaSerie = new List<Serie>(); // variável lista que vai conter todas as séries.
        public void Atualizar(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
            //pode implementar envio de e-mail ao excluir um objeto.
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
            return listaSerie.Count; //coleção baseada na primeira posição 0.
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}