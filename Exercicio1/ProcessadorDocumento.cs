namespace MyApp
{
    public class ProcessadorDocumento
    {
        public ProcessadorDocumento()
        {

        }
        
        public void ProcessadorLote(List<Documento> documentos)
        {
            foreach(Documento elemento in documentos)
            {
                elemento.Imprimir();
            }
        }
    }
}