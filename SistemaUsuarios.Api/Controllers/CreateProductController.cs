using Delivery.Item.Api.Models;
using Delivery.Item.SqlData.Entities;
using Delivery.Item.SqlData.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Delivery.Item.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
        public class RegisterController : ControllerBase
        {
            [HttpPost]
            [ProducesResponseType(typeof(CreateProductModel), 200)]
            public IActionResult CreateProduct(CreateProductModel model)
            {
                try
                {
                    var productRepository = new ProductRepository();
                    var product = new Product();

                    product.Id = Guid.NewGuid();
                    product.Description = model.Description;
                    product.Stock = model.Stock;
                    product.Price = model.Price;

                    productRepository.Create(product);                 

                    return StatusCode(201, new { mensagem = $"Produto {product.Description}, cadastrado com sucesso." });
                }
                catch (Exception e)
                {
                    return StatusCode(500, new { mensagem = e.Message });
                }
            }
        }
    }