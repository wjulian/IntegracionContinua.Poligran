using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace IntegracionContinua.Poligran.Back.Controllers
{
    [EnableCors("_myAllowSpecificOrigins")]
    [ApiController]
    [Route("[controller]")]
    public class LibrosController : Controller
    {
     
        private readonly ILogger<LibrosController> _logger;

        public LibrosController(ILogger<LibrosController> logger)
        {
            _logger = logger;
        }
        // Simulación de una lista de libros
    private List<Libro> libros = new List<Libro>
    {
        new Libro { Id = 1, Titulo = "El señor de los anillos", Autor = "J. R. R. Tolkien", AnioPublicacion = 1937, Imagen = "https://images.cdn1.buscalibre.com/fit-in/360x360/66/1a/661a3760157941a94cb8db3f5a9d5060.jpg"},
        new Libro { Id = 2, Titulo = "Cien años de soledad", Autor = "Gabriel García Márquez", AnioPublicacion = 1967, Imagen = "https://images.cdn3.buscalibre.com/fit-in/360x360/61/8d/618d227e8967274cd9589a549adff52d.jpg   "},
        new Libro { Id = 3, Titulo = "Orgullo y prejuicio", Autor = "Jane Austen", AnioPublicacion = 1813, Imagen = "https://images.cdn3.buscalibre.com/fit-in/360x360/4d/91/4d91039f3484cc01792b288d94d0c0e4.jpg" }
    };

        [HttpGet]
        public IEnumerable<Libro> Get()
        {
            return libros;
        }
    }
}
