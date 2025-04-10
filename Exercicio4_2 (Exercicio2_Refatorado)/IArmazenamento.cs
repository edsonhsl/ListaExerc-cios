namespace MyApp
{
    public interface IArmazenamento
    {
        public void Salvar(string nome, string mensagem);
        public byte[] Carregar(string nome);
        public bool Excluir(string nome);
        public List<string> ListaArquivos();
    }
}