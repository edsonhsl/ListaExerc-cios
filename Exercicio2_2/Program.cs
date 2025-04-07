// See https://aka.ms/new-console-template for more information
namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ServicoNotificacao ServicoNotificacao = new ServicoNotificacao();

            ServicoNotificacao.Enviar("Destinatário", "Assunto...", "Corpo");
            ServicoNotificacao.Enviar("Número", "Mensagem");

            //Para diferenciar um método do outro (sobrecarga de métodos), usa-se diferentes argumentos.
        }
    }    
}


