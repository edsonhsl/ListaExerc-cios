namespace MyApp
{
    public abstract class Produto : IEntregavel, ITributavel, IReembolsavel
    {

        public string nome { get; set; }
        public string descricao { get; set; }
        public float preco { get; set; }
        public Produto(string nome, string descricao, float preco)
        {
            this.nome = nome;
            this.descricao = descricao;
            this.preco = preco;
        }

        public virtual float CalcularPrecoFinal()
        {
            return 0;
        }

        public virtual string ExibirDetalhes()
        {
            return "";
        }

        public void Entregar(Produto produto)
        {

        }

        public void Tributar(float tributo)
        {

        }

        public void Reembolsar(float reembolso)
        {

        }

    }
}