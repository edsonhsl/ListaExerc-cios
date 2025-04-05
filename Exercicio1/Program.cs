// See https://aka.ms/new-console-template for more information
namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            DocumentoTexto documentoTexto = new DocumentoTexto("Título Texto", "Autor Texto", "02/02/2002");
            //documentoTexto.Imprimir();            

            DocumentoHTML documentoHTML = new DocumentoHTML("Título HTML", "Autor HTML", "03/03/2003");
            //documentoHTML.Imprimir();

            DocumentoPDF documentoPDF = new DocumentoPDF("Título PDF", "Autor PDF", "04/04/2004");
            //documentoPDF.Imprimir();

            List<Documento> documentos = new List<Documento>();
            documentos.Add(documentoTexto);
            documentos.Add(documentoHTML);
            documentos.Add(documentoPDF);

            ProcessadorDocumento processadorDocumento = new ProcessadorDocumento();
            processadorDocumento.ProcessadorLote(documentos);

            Console.WriteLine(documentoTexto.ConteudoFormatado());
            Console.WriteLine(documentoHTML.ConteudoFormatado());
            Console.WriteLine(documentoPDF.ConteudoFormatado());
        }
    }
}

