using System.Collections.Generic;
using System.Linq;

public class ProductoRepository : IProductoRepository
{
    private List<Producto> productos;

    public ProductoRepository()
    {
        productos = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Teclado", Precio = 25000m, Categoria = "Informatica", Activo = true },
            new Producto { Id = 2, Nombre = "Mouse", Precio = 12000m, Categoria = "Informatica", Activo = true },
            new Producto { Id = 3, Nombre = "Silla", Precio = 80000m, Categoria = "Muebles", Activo = true }
        };
    }

    public void Agregar(Producto producto)
    {
        productos.Add(producto);
    }

    public List<Producto> ObtenerTodos()
    {
        return productos.ToList();
    }

    public Producto? ObtenerPorId(int id)
    {
        return productos.FirstOrDefault(p => p.Id == id);
    }

    public List<Producto> BuscarPorCategoria(string categoria)
    {
        return productos
            .Where(p => p.Categoria.ToLower() == categoria.ToLower())
            .ToList();
    }
}