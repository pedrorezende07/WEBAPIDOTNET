using APICatalogo.Context;
using APICatalogo.Migrations;
using APICatalogo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICatalogo.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly AppDbContext _context; //injecao de dependencia

        public CategoriesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Categorie>> GetCategories()
        {
            var response =_context.Categories.ToList();

            if (response is null) { 
            return NotFound("Categorias nao encontradas.");
            }

            return response;
        }

        [HttpGet("{id}", Name ="GetCategorieId")] //nomeada para no POST de categoria ser chamada
        public ActionResult<Categorie> GetCategorieId(int id)
        {
            var response = _context.Categories.FirstOrDefault(p => p.Id == id);

            if (response is null)
            {
                return NotFound($"Categoria {id} não encontrada.");
            }

            return response;

        }

        [HttpPost]
        public ActionResult AddCategorie([FromBody]Categorie categorie)
        {
            if(categorie is null)
            {
                return BadRequest("Categoria nao pode ser vazia");
            }

            _context.Categories.Add(categorie);
            _context.SaveChanges();

            return new CreatedAtRouteResult("GetCategorieId", new { id = categorie.Id }, categorie); //nomeada para chamar no Get o produto criado
        }

        [HttpPut("{id}")] 
        public ActionResult UpdateCategorie(int id, [FromBody]Categorie categorie)
        {
            if(id != categorie.Id)
            {
                return BadRequest("Id do produto URL diferente do produto");
            }

            _context.Entry(categorie).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return Ok(categorie);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCategorie(int id) 
        {
            var response = _context.Categories.FirstOrDefault(p => p.Id == id);

            if (response is null)
            {
                return NotFound($"Categoria {id} não encontrada.");
            }

            _context.Categories.Remove(response);
            _context.SaveChanges();

            return Ok(response);
        }

    }
}
