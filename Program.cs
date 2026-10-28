IProductoRepository repo = new ProductoRepository();

// 1. Mostrar todos los productos
Console.WriteLine("=== TODOS LOS PRODUCTOS ===");

foreach (Producto p in repo.ObtenerTodos())
{
    Console.WriteLine($"{p.Id} - {p.Nombre} - ${p.Precio} - {p.Categoria} - Activo: {p.Activo}");
}

// 2. Buscar un producto por ID
Console.WriteLine("\n=== BUSCAR POR ID ===");

Producto? producto = repo.ObtenerPorId(2);

if (producto != null)
{
    Console.WriteLine($"Encontrado: {producto.Nombre} - ${producto.Precio}");
}
else
{
    Console.WriteLine("Producto no encontrado.");
}

// 3. Buscar por categoría
Console.WriteLine("\n=== BUSCAR POR CATEGORIA ===");

List<Producto> encontrados = repo.BuscarPorCategoria("Informatica");

foreach (Producto p in encontrados)
{
    Console.WriteLine($"{p.Nombre} - ${p.Precio}");
}

// 4. Agregar un producto nuevo
Console.WriteLine("\n=== AGREGAR PRODUCTO ===");

Producto nuevo = new Producto
{
    Id = 4,
    Nombre = "Monitor",
    Precio = 150000m,
    Categoria = "Informatica",
    Activo = true
};

repo.Agregar(nuevo);

Console.WriteLine("Producto agregado: " + nuevo.Nombre);

// Mostrar la lista actualizada
Console.WriteLine("\n=== LISTA ACTUALIZADA ===");

foreach (Producto p in repo.ObtenerTodos())
{
    Console.WriteLine($"{p.Id} - {p.Nombre} - ${p.Precio}");
}