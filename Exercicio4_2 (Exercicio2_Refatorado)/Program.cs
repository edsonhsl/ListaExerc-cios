// See https://aka.ms/new-console-template for more information

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ArmazenamentoLocal armazenamentoLocal = new ArmazenamentoLocal();  
            armazenamentoLocal.Salvar("Arquivo1", "Mensagem qualquer");
        }
    }
}
