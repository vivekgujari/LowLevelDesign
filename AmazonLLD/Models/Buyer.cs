namespace AmazonLLD.Models
{
    public enum MembershipType { DEFAULT, PRIME}
    public class Buyer : Customer
    {
        #region Public properties
        public string Id { get; set; }
        public MembershipType MembershipType { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        #endregion

        #region Public Methods
        public void AddProduct(Product product)
        { 
        }

        public void UpdateProduct(Product product) { }

        public void DeleteProduct(Product product) { }

        #endregion
    }
}
