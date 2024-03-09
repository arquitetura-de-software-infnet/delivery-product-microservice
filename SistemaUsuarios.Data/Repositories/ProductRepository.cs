using Delivery.Item.SqlData.Contexts;
using Delivery.Item.SqlData.Entities;
using Microsoft.EntityFrameworkCore;


namespace Delivery.Item.SqlData.Repositories
{
    public class ProductRepository
    {
        public void Create(Product product)
        {
            using (var sqlServerContext = new SqlServerContext())
            {
                sqlServerContext.Product.Add(product);
                sqlServerContext.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (var sqlServerContext = new SqlServerContext())
            {
 
                sqlServerContext.Entry(product).State = EntityState.Modified;
                sqlServerContext.SaveChanges();
            }
        }
        public void Delete(Product product)
        {
            using (var sqlServerContext = new SqlServerContext())
            {
                sqlServerContext.Remove(product);
                sqlServerContext.SaveChanges();
            }
        }

        public Product GetById(Guid id) 
        {
            using (var sqlServerContext = new SqlServerContext())
            {
                return sqlServerContext.Product.FirstOrDefault(u => u.Id.Equals(id));
            }
        }
    }
}
