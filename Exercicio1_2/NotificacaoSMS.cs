namespace MyApp
{
    public class NotificacaoSMS : Notificacao
    {
        public NotificacaoSMS(string destinatario, string mensagem, string dataEnvio) 
        : base(destinatario, mensagem, dataEnvio)
        {

        }

        public override string Enviar()
        {
            return "Enviando SMS para...";
        }

        public override void FormatarMensagem()
        {
             
        }

        public override void EstatisticaDeEnvio()
        {
            
        }
    }
}