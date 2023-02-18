namespace MercadoVilleFord.Entities
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Quantidade { get; set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco, string quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
    }

}
