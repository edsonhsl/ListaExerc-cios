namespace MyApp
{
    public class NotificacaoEMAIL : Notificacao
    {

        public NotificacaoEMAIL(string destinatario, string mensagem, string dataEnvio) 
        : base(destinatario, mensagem, dataEnvio)
        {
            
        }

        public override string Enviar()
        {   
            return "Enviando e-mail para...";
        }

        public override void FormatarMensagem()
        {

        }

        public override void EstatisticaDeEnvio()
        {
            
        }

    }
}