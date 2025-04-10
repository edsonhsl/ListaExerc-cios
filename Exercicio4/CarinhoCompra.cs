namespace MyApp
{
    public class CarrinhoCompra
    {
        
        public List<Produto> listaProdutos = new List<Produto>();

        public CarrinhoCompra()
        {

        }

        public void AddCarinho(Produto produto)
        {
            listaProdutos.Add(produto);
        }

        public float ValorTotal()
        {
            float valorTotal = 0;
            foreach (Produto produto in listaProdutos)
            {
                valorTotal += produto.preco;
            }

            return valorTotal;
        }
    }
}