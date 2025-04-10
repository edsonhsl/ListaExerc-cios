using Microsoft.Extensions.Logging;

namespace MyApp
{
    public class RecursoBancoDados : RecursoBase, IDisposable
    {
        
        public IDisposable gerenciarRecursoBancoDados { get; set; }
        
        public RecursoBancoDados()
        {
            
        }

        public void Dispose()
        {
            gerenciarRecursoBancoDados.Dispose();

            using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
            ILogger logger = factory.CreateLogger("Log");
            logger.LogInformation("Descrição Log {'Dispose()' chamado}.");
        }
    }
}