namespace MyApp
{
    public interface IArmazenamento
    {
        public bool Salvar(string nome, byte[] dados);
        public byte[] Carregar(string nome);
        public bool Excluir(string nome);
        public List<string> ListaArquivos();
    }
}