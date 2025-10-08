// Ejercicio 1 Jose Andres Jimenez
string[] Producto = new string[5];
float[] Precio = new float[5];
void IngresarProductos()
{
    {
        Console.WriteLine("Ingreso de productos: ");
        for (int i = 0; i < Producto.Length; i++)
        {
            Console.Write($"Ingrese el nombre del producto: {i + 1}: ");
            Producto[i] = Console.ReadLine();
        }
    }
}
void IngresarPrecio()
{
    Console.WriteLine("Ingreso de precios: ");
    for (int i = 0; i < Precio.Length; i++)
    {
        Console.Write($"Ingrese el precio del producto: {Producto[i]}: ");
        Precio[i] = float.Parse(Console.ReadLine());
    }
}
void ConsultarInven()
{
    for (int i = 0; i < Producto.Length; i++)
    {
        Console.WriteLine($" Inventario de productos/precios: Producto {i + 1}: {Producto[i]} -> Precio: {Precio[i]}");
    }
}
void Menu()
{
    int opcion;

    while (true)
    {
        Console.WriteLine("\n Menu de la soda/cafeteria solidarista");
        Console.WriteLine("Digite 1 para Ingresar el producto");
        Console.WriteLine("Digite 2 para Ingresar el precio");
        Console.WriteLine("Digite 3 para Consultar el inventario de productos/precios");
        Console.WriteLine("Digite 4 para salir");
        Console.Write("Ingrese una opcion: ");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                IngresarProductos();
                break;
            case 2:
                IngresarPrecio();
                break;
            case 3:
                ConsultarInven();
                break;
            case 4:
                Console.WriteLine("Gracias por usar el sistema.");
                return;
            default:
                Console.WriteLine("La opción ingresada no es válida.");
                break;
        }
    }
}

Console.WriteLine("Bienvenido a la soda/cafeteria solidarista!");
    Menu();

