namespace AmazonLLD.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private readonly ICustomerRepository _customerRepository;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            _customerRepository = new CustomerRepository(_context);
        }
        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
