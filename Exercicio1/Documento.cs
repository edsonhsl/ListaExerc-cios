namespace MyApp
{
    public class Documento
    {
        public string titulo {get; set;}
        public string autor {get; set;}
        public string dataPublicacao {get; set;} 

        public Documento(string titulo, string autor, string dataPublicacao)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.dataPublicacao = dataPublicacao;
        }

        public virtual void Imprimir()
        {
            
        }

        public virtual string ConteudoFormatado()
        {
            return "";
        }
      
    }
}