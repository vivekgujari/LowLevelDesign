using Microsoft.EntityFrameworkCore;

namespace AmazonLLD.DataAccess.Repository
{
    public class Repository<T> : IRepository where T : class
    {
        #region Private properties
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;
        #endregion

        #region Constructor
        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        #endregion

        #region Public methods
        public T? Get(string id)
        {
            var entity = _dbSet.Find(id);
            if (entity == null) 
            {
                // logging
                return null;
            }
            else
                return entity;
        }

        public bool Add(T entity)
        { throw new NotImplementedException(); }
        public bool Delete(T entity) {  throw new NotImplementedException(); }
        public bool Update(T entity) {  return false; }

        #endregion
    }
}
