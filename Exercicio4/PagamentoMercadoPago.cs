namespace MyApp
{
    public class PagamentoMercadoPago : IProcessarPagamento, IDisposable
    {
        
        public IDisposable processarPagamento {get; set;}

        public PagamentoMercadoPago()
        {
            
        }

        public void ProcessarCartaoCredito(float valorProduto)
        {
            processarPagamento.Dispose();
        }

        public void ProcessarBoleto(float valorProduto)
        {
            processarPagamento.Dispose();
        }

        public void ProcessarPix(float valorProduto)
        {
            processarPagamento.Dispose();
        }

        public void Dispose()
        {

        }
    }
}