namespace MyApp
{
    public class ServicoNotificacao : IServicoEmail, IServiloSMS
    {
        public ServicoNotificacao()
        {

        }

        public void Enviar(string destinatario, string assunto, string corpo)
        {
            
        }

        public void Enviar(string numero, string mensagem)
        {

        }
    }
}