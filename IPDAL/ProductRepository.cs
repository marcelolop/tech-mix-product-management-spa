// Ignore Spelling: IPDAL

using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPDAL
{
    /// <summary>
    /// This class is used to perform database operations on the Product class
    /// </summary>
    public class ProductRepository
    {
        /// <summary>
        /// This method is used to get all the products from the database
        /// </summary>
        /// <returns> List of products</returns>
        public List<Product> GetProductsRepository()
        {
            ADVProductManagementEntities aDVProductManagementEntities = new ADVProductManagementEntities();
            return aDVProductManagementEntities.Products.ToList();
        }

        /// <summary>
        /// This method is used to get a product by its id from the database
        /// </summary>
        /// <param name="id"> The id of the product</param>
        /// <returns> The product object</returns>
        public Product GetProductByIdRepository(int id)
        {
            ADVProductManagementEntities aDVProductManagementEntities = new ADVProductManagementEntities();
            return aDVProductManagementEntities.Products.Where(prod => prod.ProductID == id).FirstOrDefault();
        }

        /// <summary>
        /// This method is used to add a product to the database
        /// </summary>
        /// <param name="product"> The product object</param>
        /// <returns></returns>
        public bool AddProductRepository(Product product)
        {
            ADVProductManagementEntities aDVProductManagementEntities = new ADVProductManagementEntities();
            aDVProductManagementEntities.Products.Add(product);
            aDVProductManagementEntities.SaveChanges();
            return true;
        }

        /// <summary>
        /// This method is used to update a product in the database
        /// </summary>
        /// <param name="product"> The product object</param>
        /// <returns> True if the product is updated successfully, false otherwise</returns>
        public bool UpdateProductRepository(Product product)
        {
            ADVProductManagementEntities aDVProductManagementEntities = new ADVProductManagementEntities();
            Product productToUpdate = aDVProductManagementEntities.Products.Where(p => p.ProductID == product.ProductID).FirstOrDefault();
           if (productToUpdate != null)
            {
                Mapper.Map(product, productToUpdate);
                aDVProductManagementEntities.SaveChanges();
                return true;
            }
            return false;
        }

        /// <summary>
        /// This method is used to delete a product from the database
        /// </summary>
        /// <param name="id"> The id of the product</param>
        /// <returns> True if the product is deleted successfully, false otherwise</returns>
        public bool DeleteProductRepository(int id)
        {
            ADVProductManagementEntities aDVProductManagementEntities = new ADVProductManagementEntities();
            Product productToDelete = aDVProductManagementEntities.Products.Where(p => p.ProductID == id).FirstOrDefault();
            if (productToDelete != null)
            {
                aDVProductManagementEntities.Products.Remove(productToDelete);
                aDVProductManagementEntities.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
