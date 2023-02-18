using System;
using MercadoVilleFord.Services;
using System.Globalization;
using MercadoVilleFord.Banco_de_dados;

namespace MercadoVilleFord.Tela
{
    public class TelaDoUsuario
    {
        public static void ExibirTela()
        {
            EstoqueServices estoqueServices = new EstoqueServices(new BancoDoEstoque());

            Console.WriteLine("\n-----------------------------------------------------");
            Console.WriteLine("|      Bem Vindo(a) ao nosso Site do Estoque        |");
            Console.WriteLine("-----------------------------------------------------\n");

            //Tabela de produto
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("| Nome    | Preço    | Quantidade |");
            Console.WriteLine("-----------------------------------");

            foreach (var produto in estoqueServices._bancoDoEstoque._listProdutos)
            {
                Console.Write(" " + produto.Nome
                    + "   | " + produto.Preco.ToString("F2", CultureInfo.InvariantCulture)
                    + "    | " + produto.Quantidade + "        |\n");
            }
            Console.WriteLine("-----------------------------------");
            //Final da Tabela

            //Tela de Gerencia
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("           Gerenciar o Estoque           |");
            Console.WriteLine("----------------------------------------- ");
            Console.WriteLine("                                         |");
            Console.WriteLine("#1 Adicioanar Item: Precione \"A\"         |");
            Console.WriteLine("                                         |");
            Console.WriteLine("#2 Remover Item: Precione \"R\"            |");
            Console.WriteLine("                                         |");
            Console.WriteLine("#3 Buscar Item: Precione \"B\"             |");
            Console.WriteLine("-----------------------------------------\n");
            //Final da Tela Gerencia

            TelaService.RealizarOperacoes();
        }
    }
}
