namespace MyApp
{
    public class Notificacao
    {

        public string destinatario {get;set;}
        public string mensagem {get;set;}
        public string dataEnvio{get;set;}
        public Notificacao(string destinatario, string mensagem, string dataEnvio)
        {
            this.destinatario=destinatario;
            this.mensagem=mensagem;
            this.dataEnvio=dataEnvio;   
        }

        public virtual string Enviar()
        {
            return "";
        }

        public virtual void FormatarMensagem()
        {
            
        }

        public virtual void EstatisticaDeEnvio()
        {
            
        }
    }
}