namespace MyApp
{
    public class ArmazenamentoLocal : IArmazenamento, IDisposable
    {

        public IDisposable armazenamentoLocal;

        public ArmazenamentoLocal()
        {
            
        }
        public void Salvar(string nome, string mensagem){
            
            StreamWriter escrever = new StreamWriter($"C:\\Users\\Edson\\Documents\\UNIP\\DocumetosListaExercicio1\\DocumentosExercicio4_2\\{nome}.txt");
            escrever.WriteLine($"Mensagem: {mensagem}");
            escrever.Close();
        }

        public byte[] Carregar(string nome)
        {
            //Carregar arquivo local
            return null;
        }

        public bool Excluir(string nome)
        {
            armazenamentoLocal.Dispose();
            return false;
        }
        public List<string> ListaArquivos()
        {
            //retorna lista local
            return new List<string>();
        }

        public void Dispose(){
            
        }
       
    }
}