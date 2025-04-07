namespace MyApp
{
    public class ArmazenamentoNuvem : IArmazenamento, IRastreavel
    {
        public ArmazenamentoNuvem()
        {

        }
        public bool Salvar(string nome, byte[] dados){
            
            //salvar remotamente
            return false;
        }

        public byte[] Carregar(string nome)
        {
            //Carregar arquivo remoto
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
      
    }
}