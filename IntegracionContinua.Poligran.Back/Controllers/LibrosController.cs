using Microsoft.AspNetCore.Mvc;

namespace IntegracionContinua.Poligran.Back.Controllers
{
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
        new Libro { Id = 1, Titulo = "El señor de los anillos", Autor = "J. R. R. Tolkien", AnioPublicacion = 1937 },
        new Libro { Id = 2, Titulo = "Cien años de soledad", Autor = "Gabriel García Márquez", AnioPublicacion = 1967 },
        new Libro { Id = 3, Titulo = "Orgullo y prejuicio", Autor = "Jane Austen", AnioPublicacion = 1813 }
    };

        [HttpGet]
        public IEnumerable<Libro> Get()
        {
            return libros;
        }
    }
}
