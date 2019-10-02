namespace ocp.Interfaces
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T p);
    }
}