// See https://aka.ms/new-console-template for more information
namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            NotificacaoEMAIL notificacaoEMAIL = new NotificacaoEMAIL("Destinatário 1", "Mensagem 1", "02/02/2002");
            Console.WriteLine(notificacaoEMAIL.Enviar());

            NotificacaoSMS notificacaoSMS = new NotificacaoSMS("Destinatário 2", "Mensagem 2", "03/03/2003");
            Console.WriteLine(notificacaoSMS.Enviar());

            NotificacaoPUSH notificacaoPUSH = new NotificacaoPUSH("Destinatário 3", "Mensagem 3", "04/04/2004");
            Console.WriteLine(notificacaoPUSH.Enviar());

        }
    }
}
