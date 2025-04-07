namespace MyApp
{
    public abstract class RepositorioBase<T>
    {
        public RepositorioBase()
        {

        }

        protected string armazenarDados;
        
        public abstract void Validar(T entidade);
    }

}