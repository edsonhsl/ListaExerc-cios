using System;
using Microsoft.Extensions.Logging;

namespace MyApp
{
    public class GerenciarConexao : IDisposable
    {
        public IDisposable bancoDeDados { get; set; }
        
        public GerenciarConexao()
        {
            
        }

        public void Dispose()
        {
            bancoDeDados.Dispose();

            using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
            ILogger logger = factory.CreateLogger("Log");
            logger.LogInformation("Descrição Log {'Dispose()' chamado}.");
        }

    }
}