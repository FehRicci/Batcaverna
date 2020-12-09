using Batcaverna.Interfaces;
using Batcaverna.Repositorios;
using System;

namespace Batcaverna.Menu
{
    public abstract class MenuBase<T> where T : IEntidadeCadastravel
    {
        private string _entidadeDoMenu;
        protected BaseRepositorio<T> _repositorioBase;

        public MenuBase(string entidadeDoMenu, BaseRepositorio<T> repositorioBase)
        {
            _entidadeDoMenu = entidadeDoMenu;
            _repositorioBase = repositorioBase;
        }

        public abstract void Cadastrar();

        public void Excluir()
        {
            var idInformado = "";
            Console.WriteLine("Favor, informar o Id: ");
            idInformado = Console.ReadLine();

            var carro = _repositorioBase.ObterPorId(Int64.Parse(idInformado));

            if (carro != null)
            {
                _repositorioBase.Excluir(_repositorioBase.ObterPorId(Int64.Parse(idInformado)));
                Console.WriteLine($"{_entidadeDoMenu} excluido com sucesso :) \n");
            }
            else
                Console.WriteLine($"{_entidadeDoMenu} não encontrado :/ \n");
        }

        public void Quantidade()
        {
            var quantidadeDeCarros = _repositorioBase.Listar().Count;
            Console.WriteLine($"Quantidade de {_entidadeDoMenu}: {quantidadeDeCarros}\n");
        }

        public void Verificar()
        {
            var idInformado = "";
            Console.WriteLine("Favor, informar o Id: ");
            idInformado = Console.ReadLine();

            var carro = _repositorioBase.ObterPorId(Int64.Parse(idInformado));

            if (carro != null)
                Console.WriteLine($"O {_entidadeDoMenu} existe! \n");
            else
                Console.WriteLine($"{_entidadeDoMenu} não encontrado :/ \n");
        }
    }

}