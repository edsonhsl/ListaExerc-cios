using System.IO;

namespace MyApp
{
    public class DocumentoTexto : Documento
    {
        public DocumentoTexto(string titulo, string autor, string dataPublicacao) 
        : base(titulo, autor, dataPublicacao)
        {

        }
        public override void Imprimir()
        {
            StreamWriter escritor = new StreamWriter("C:\\Users\\Edson\\Documents\\UNIP\\DocumetosListaExercicio1\\documentoTXT.txt");
            escritor.WriteLine($"Título: {base.titulo}");
            escritor.WriteLine($"Autor: {base.autor}");
            escritor.WriteLine($"Data publicação: {base.dataPublicacao}");
            escritor.Close();
        }

        public override string ConteudoFormatado()
        {
            using StreamReader leitor = new("C:\\Users\\Edson\\Documents\\UNIP\\DocumetosListaExercicio1\\documentoTXT.txt");
            string texto = leitor.ReadToEnd();
            return texto;
        }

        public void ContarPalavras()
        {
            
        }
    }
}