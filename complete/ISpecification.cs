namespace complete
{
    public interface ISpecification<T>
    {
         bool IsSatisfied(T p);
    }
}