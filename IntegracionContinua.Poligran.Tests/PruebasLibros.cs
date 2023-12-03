using IntegracionContinua.Poligran.Back.Controllers;

namespace IntegracionContinua.Poligran.Tests;

public class PruebasLibros
{
    [Fact]
    public void ObtieneTresLibros()
    {
        var controlador = new LibrosController();
        var libros = controlador.Get();

        Assert.True(libros.Count().Equals(3), "La cantidad de libros es correcta");
    }
}