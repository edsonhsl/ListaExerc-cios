namespace MyApp
{
    public class ProdutoDigital : Produto
    {
        public ProdutoDigital(string nome, string descricao, float preco) 
        : base(nome, descricao, preco)
        {

        }

        public override float CalcularPrecoFinal()
        {
            return 0;
        }

        public override string ExibirDetalhes()
        {
            return "";
        }

        public new void Entregar(Produto produto)
        {

        }

        public new void Tributar(float tributo)
        {

        }

        public new void Reembolsar(float reembolso)
        {

        }
    }
}