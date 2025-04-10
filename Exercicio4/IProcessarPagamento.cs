namespace MyApp
{
    public interface IProcessarPagamento
    {
        void ProcessarCartaoCredito(float valorProduto);

        void ProcessarBoleto(float valorProduto);

        void ProcessarPix(float valorProduto);
    }
}