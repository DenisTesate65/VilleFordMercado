using MercadoVilleFord.Entities;
using System.Collections.Generic;

namespace MercadoVilleFord.Banco_de_dados
{
    public interface IBancoDoEstoque
    {
        List<Produto> _listProdutos { get; set; }
    }
}