// See https://aka.ms/new-console-template for more information
namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            ProdutoFisico produtoFisico= new ProdutoFisico("Caderno", "Caderno de caligrafia", 10);

            CarrinhoCompra carrinhoCompra = new CarrinhoCompra();
            carrinhoCompra.AddCarinho(produtoFisico);

            PagamentoMercadoPago pagamentoMercadoPago = new PagamentoMercadoPago();
            pagamentoMercadoPago.ProcessarCartaoCredito(carrinhoCompra.ValorTotal());
        }
    }
}
