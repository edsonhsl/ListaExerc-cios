namespace MyApp
{
    public class NotificacaoPUSH : Notificacao
    {
        public NotificacaoPUSH(string destinatario, string mensagem, string dataEnvio) 
        : base(destinatario, mensagem, dataEnvio)
        {

        }

        public override string Enviar()
        {
            return "Enviando PUSH para...";
        }

        public override void FormatarMensagem()
        {
            
        }

        public override void EstatisticaDeEnvio()
        {
            
        }
    }
}