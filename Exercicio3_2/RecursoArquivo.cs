using Microsoft.Extensions.Logging;

namespace MyApp
{
    public class RecursoArquivo : RecursoBase, IDisposable
    {
        
        public IDisposable gerenciarRecursoArquivo {get; set;} 

        public RecursoArquivo()
        {
            gerenciarRecursoArquivo = new RecursoArquivo();

        }

        public void Dispose()
        {
            gerenciarRecursoArquivo.Dispose();

            using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
            ILogger logger = factory.CreateLogger("Log");
            logger.LogInformation("Descrição Log {'Dispose()' chamado}.");
        }
    }
}