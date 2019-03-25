namespace dip.Interfaces
{
    public interface IService<T> where T : class
    {
        bool Inserir(T entity);
    }
}
