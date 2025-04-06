namespace MyApp
{
    public class RegistroSobrescrito : RegistroBase
    {
        public RegistroSobrescrito(string registro, int numeroRegistro) : base(registro, numeroRegistro)
        {

        }

        public override void Salvar()
        {
            StreamWriter escrever = new StreamWriter("C:\\Users\\Edson\\Documents\\UNIP\\DocumetosListaExercicio1\\DocumentosExercicio1_3\\documento.txt");
            escrever.WriteLine($"Registro: {registro};");
            escrever.WriteLine($"Número Registro: {numeroRegistro}");
            escrever.Close();
        }

    }
}