// See https://aka.ms/new-console-template for more information

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            RegistroSobrescrito registroSobrescrito = new RegistroSobrescrito("Registro Sobrescrito", 1);
            registroSobrescrito.Salvar();

            RegistroOculto registroOculto = new RegistroOculto("Registro Oculto", 2);
            registroOculto.Salvar();
            
            //Sinceramente, não pude perceber nenhuma diferença nos resultados.
        }
    }
}

