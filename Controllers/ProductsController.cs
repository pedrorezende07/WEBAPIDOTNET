using APICatalogo.Context;
using APICatalogo.Migrations;
using APICatalogo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICatalogo.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {

            var response = _context.Products.ToList();

            if (response is null)
            {
                return NotFound("Produtos nao encontrados.");
            }

            return response;
        }

        [HttpGet("{id}", Name = "GetProductId")]
        public ActionResult<Product> GetProduct(int id)
        {
            var response = _context.Products.FirstOrDefault(x => x.Id == id);

            if (response is null)
            {
                return NotFound($"Produto com id: {id} não encontrado");
            }
            return response;
        }

        [HttpPost]
        public ActionResult AddProduct([FromBody]Product product) 
        {
            if (product is null)
            {
                return BadRequest("Categoria nao pode ser vazia");
            }

            _context.Products.Add(product);
            _context.SaveChanges();

            return new CreatedAtRouteResult("GetProductId", new { id = product.Id }, product);
        }



        [HttpPut("{id}")]
        public ActionResult UpdateProduct(int id, [FromBody] Product product)
        {
            if (id != product.Id)
            {
                return BadRequest("Id do produto URL diferente do produto");
            }

            _context.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return Ok(product);
        }



        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            var response = _context.Products.FirstOrDefault(p => p.Id == id);

            if (response is null)
            {
                return NotFound($"Categoria {id} não encontrada.");
            }

            _context.Products.Remove(response);
            _context.SaveChanges();

            return Ok(response);
        }
    }
}
