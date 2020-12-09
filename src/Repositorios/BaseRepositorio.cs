using Batcaverna.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Batcaverna.Repositorios
{
    public abstract class BaseRepositorio<T> where T : IEntidadeCadastravel
    {
        protected long _contadorRegistros;
        protected readonly List<T> _listaDeDados;

        public BaseRepositorio()
        {
            _listaDeDados = new List<T>();
            _contadorRegistros = _listaDeDados.Count;
        }

        public void Adicionar(T entidade)
        {
            entidade.Id = _contadorRegistros + 1;

            _listaDeDados.Add(entidade);
            _contadorRegistros++;
        }

        public List<T> Listar()
        {
            return _listaDeDados;
        }

        public T ObterPorId(long id)
        {
            var entidade = _listaDeDados.FirstOrDefault(item => item.Id == id);
            return entidade;
        }
        public void Excluir(T entidade)
        {
            _listaDeDados.Remove(entidade);
        }
    }
}
