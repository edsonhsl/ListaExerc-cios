namespace MyApp
{
    public class RegistroBase
    {

        public string registro { get; set; }
        public int numeroRegistro { get; set; }
        public RegistroBase(string registro, int numeroRegistro)
        {
            this.registro = registro;
            this.numeroRegistro = numeroRegistro;
        }

        public virtual void Salvar()
        {
            
        }
    }
}