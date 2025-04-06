namespace MyApp
{
    public class RegistroOculto : RegistroBase
    {
        public RegistroOculto(string registro, int numeroRegistro) : base(registro, numeroRegistro)
        {
            
        }

        public new void Salvar()
        {
            StreamWriter escrever = new StreamWriter("C:\\Users\\Edson\\Documents\\UNIP\\DocumetosListaExercicio1\\DocumentosExercicio1_3\\documento2.txt");
            escrever.WriteLine($"Registro: {registro};");
            escrever.WriteLine($"Número Registro: {numeroRegistro}");
            escrever.Close();
        }
    }
}