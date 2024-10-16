namespace AmazonLLD.DataAccess.Repository
{
    public interface IRepository <T> where T : class
    {
        T Get(string id);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(string id);
    }
}
