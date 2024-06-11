using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    // O : diz que vai implementar
    public class SerieRepositorio : IRepositorio<Serie>
    {
        List<Serie> listaSerie = new List<Serie>();
        // Coloca o objeto(serie) em uma posição na lista
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }
        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
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