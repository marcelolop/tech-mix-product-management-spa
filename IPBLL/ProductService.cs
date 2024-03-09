using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPDAL;

namespace IPBLL
{   
    /// <summary>
    /// This class is used to perform business logic on the Product class
    /// </summary>
    public class ProductService
    {
        /// <summary>
        /// This method is used to get all the products
        /// </summary>
        /// <returns> List of products</returns>
        public List<Product> GetProducts()
        {
            ProductRepository productRepository = new ProductRepository();
            return productRepository.GetProductsRepo();
        }

        /// <summary>
        /// This method is used to get a product by its id
        /// </summary>
        /// <param name="id"> The id of the product</param>
        /// <returns> The product object</returns>
        public Product GetProductById(int id)
        {
            ProductRepository productRepository = new ProductRepository();
            return productRepository.GetProductByIdRepo(id);
        }

        /// <summary>
        /// This method is used to add a product to the database
        /// </summary>
        /// <param name="product"> The product object</param>
        /// <returns> True if the product is added successfully, false otherwise</returns>
        public bool AddProduct(Product product)
        {
            ProductRepository productRepository = new ProductRepository();
            return productRepository.AddProductRepo(product);
        }

        /// <summary>
        /// This method is used to update a product in the database
        /// </summary>
        /// <param name="product"> The product object</param>
        /// <returns> True if the product is updated successfully, false otherwise</returns>
        public bool UpdateProduct(Product product)
        {
            ProductRepository productRepository = new ProductRepository();
            return productRepository.UpdateProductRepo(product);
        }

        /// <summary>
        /// This method is used to delete a product from the database
        /// </summary>
        /// <param name="id"> The id of the product</param>
        /// <returns> True if the product is deleted successfully, false otherwise</returns>
        public bool DeleteProduct(int id)
        {
            ProductRepository productRepository = new ProductRepository();
            return productRepository.DeleteProductRepo(id);
        }
          
    }
}
