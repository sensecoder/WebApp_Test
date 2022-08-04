namespace WebApp_Test.Models
{
    public interface IRepository<T>
    {
        IEnumerable<T> Items { get; }
        void DeleteById(int Id);
    }
}
