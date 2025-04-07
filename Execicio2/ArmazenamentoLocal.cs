namespace MyApp
{
    public class ArmazenamentoLocal : IArmazenamento
    {
        public ArmazenamentoLocal()
        {

        }
        public bool Salvar(string nome, byte[] dados){
            
            //salvar localmente
            return false;
        }

        public byte[] Carregar(string nome)
        {
            //Carregar arquivo local
            return null;
        }

        public bool Excluir(string nome)
        {
            //excluir arquivo local
            return false;
        }
        public List<string> ListaArquivos()
        {
            //retorna lista local
            return new List<string>();
        }
       
    }
}