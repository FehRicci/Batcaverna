﻿using Batcaverna.Modelos;
using Batcaverna.Repositorios;
using System;

namespace Batcaverna
{
    class Batcave
    {
        static void Main(string[] args)
        {
            var opcaoSelecionada = "";
            var batTrajes = new BatTrajeRepositorio();
            var batCarros = new BatCarroRepositorio();
            var idInformado = "";

            Console.WriteLine("Bem-vindo à Batcaverna!");

            while (opcaoSelecionada != "x") 
            {
                opcaoSelecionada = ObterOpçãoDoMenuComUsuário();

                if (opcaoSelecionada == "1") 
                {
                    batTrajes.AdicionarTraje(new BatTraje());
                    Console.WriteLine($"Traje adicionado com sucesso :) \n");
                }

                if(opcaoSelecionada == "2") 
                {
                    var quantidadeDeTrajes = batTrajes.ListarTrajes().Count;
                    Console.WriteLine($"Quantidade de trajes: {quantidadeDeTrajes}\n");
                }


                if (opcaoSelecionada == "3")
                {
                    Console.WriteLine("Favor, informar o Id: ");
                    idInformado = Console.ReadLine();

                    var traje = batTrajes.ObterPorId(Int64.Parse(idInformado));

                    if (traje != null)
                        Console.WriteLine($"O traje existe! \n");
                    else
                        Console.WriteLine("Traje não encontrado :/ \n");
                }

                if (opcaoSelecionada == "4") 
                {
                    batCarros.AdicionarCarro(new BatCarro());
                    Console.WriteLine($"Carro adicionado com sucesso :) \n");
                }

                if(opcaoSelecionada == "5") 
                {
                    var quantidadeDeCarros = batCarros.ListarCarros().Count;
                    Console.WriteLine($"Quantidade de carros: {quantidadeDeCarros}\n");
                }


                if (opcaoSelecionada == "6")
                {
                    Console.WriteLine("Favor, informar o Id: ");
                    idInformado = Console.ReadLine();

                    var carro = batCarros.ObterPorId(Int64.Parse(idInformado));

                    if (carro != null)
                        Console.WriteLine($"O carro existe! \n");
                    else
                        Console.WriteLine("Carro não encontrado :/ \n");
                }
                if (opcaoSelecionada == "7") 
                {
                    Console.WriteLine("Favor, informar o Id: ");
                    idInformado = Console.ReadLine();

                    batCarros.ExcluirCarro(batCarros.ObterPorId(Int64.Parse(idInformado)));
                    Console.WriteLine($"Carro excluido com sucesso :) \n");
                }
            }
        }

        static string ObterOpçãoDoMenuComUsuário() 
        {
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1. Cadastrar BatTraje");
            Console.WriteLine("2. Quantidade de BatTrajes");
            Console.WriteLine("3. Verificar se traje existe");
            Console.WriteLine("4. Cadastrar BatCarro");
            Console.WriteLine("5. Quantidade de BatCarros");
            Console.WriteLine("6. Verificar se carro existe");
            Console.WriteLine("7. Excluir Batcarro");
            Console.WriteLine("X. Sair");

            return Console.ReadLine();
        }
    }
}