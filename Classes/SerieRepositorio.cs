using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private readonly IList<Serie> _series = new List<Serie>();
        public void Atualizar(int id, Serie objeto) => _series[id] = objeto;

        public void Excluir(int id) => _series[id].Excluir();

        public void Inserir(Serie objeto) => _series.Add(objeto);

        public IList<Serie> Listar() => _series;

        public int ObterProximoId() => _series.Count;

        public Serie ObterPorId(int id) => _series[id];
    }
}