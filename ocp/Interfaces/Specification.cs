namespace ocp.Interfaces
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(Product p);
    }
}