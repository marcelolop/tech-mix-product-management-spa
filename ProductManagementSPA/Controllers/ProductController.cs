using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using IPBLL;
using IPDAL;
using ProductManagementSPA.Models;

namespace ProductManagementSPA.Controllers
{
    /// <summary>
    /// This controller is responsible for handling the product related requests.
    /// </summary>
    public class ProductController : Controller
    {
        // GET: Product
        /// <summary>
        /// This method is responsible for rendering the product view. Is decorated with Authorize attribute to ensure that only authenticated users can access this view.
        /// </summary>
        /// <returns> The view of the product page.</returns>
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// This method is responsible for returning the list of products in JSON format.
        /// </summary>
        /// <returns> The list of products in JSON format.</returns>
        [HttpGet]
        public JsonResult GetProducts()
        {
            ProductService productService = new ProductService();
            var products = productService.GetProducts();

            List<ProductVM> productVMs = new List<ProductVM>();

            productVMs = Mapper.Map<List<Product>, List<ProductVM>>(products);

            return Json(productVMs, JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// This method is responsible for returning the product by its id in JSON format.
        /// </summary>
        /// <param name="id"> The id of the product.</param>
        /// <returns> The product in JSON format.</returns>
        [HttpGet]
        public JsonResult GetProductById(int id)
        {
            ProductService productService = new ProductService();
            var product = productService.GetProductById(id);
            return Json(product, JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// This method is responsible for adding a product to the database.
        /// </summary>
        /// <param name="product"> The product to be added.</param>
        /// <returns> A JSON result indicating the success of the operation.</returns>
        [HttpPost]
        public JsonResult AddProduct(Product product)
        {
            ProductService productService = new ProductService();
            if (productService.AddProduct(product))
            {
                return Json(true,JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.DenyGet);
            }
            
        }


        /// <summary>
        /// This method is responsible for updating a product in the database.
        /// </summary>
        /// <param name="product"> The product to be updated.</param>
        /// <returns> A JSON result indicating the success of the operation.</returns>
        [HttpPost]
        public JsonResult UpdateProduct(Product product)
        {
            ProductService productService = new ProductService();
            if (productService.UpdateProduct(product))
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.DenyGet);
            }
        }

        /// <summary>
        /// This method is responsible for deleting a product from the database.
        /// </summary>
        /// <param name="id"> The id of the product to be deleted.</param>
        /// <returns> A JSON result indicating the success of the operation.</returns>
        [HttpPost]
        public JsonResult DeleteProduct(int id)
        {
            ProductService productService = new ProductService();
            if (productService.DeleteProduct(id))
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.DenyGet);
            }
        }
    }
}