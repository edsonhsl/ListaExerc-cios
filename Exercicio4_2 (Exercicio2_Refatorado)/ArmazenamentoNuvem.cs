namespace MyApp
{
    public class ArmazenamentoNuvem : IArmazenamento, IRastreavel, IDisposable
    {

        public IDisposable armazenamentoNuvem;

        public ArmazenamentoNuvem()
        {
            
        }
        public void Salvar(string nome, string mensagem){
            
            //salvar remotamente
            
        }

        public byte[] Carregar(string nome)
        {
            armazenamentoNuvem.Dispose();
            return null;
        }

        public bool Excluir(string nome)
        {
            //excluir arquivo remoto
            return false;
        }
        public List<string> ListaArquivos()
        {
            //retorna lista remota
            return new List<string>();
        }

        public void RegistrarOperacao(string operacao, string arquivo)
        {
            
        }

        public List<string> ObterHistoricoOperacoes()
        {
            return new List<string>();
        }

        public void Dispose(){

        }
      
    }
}