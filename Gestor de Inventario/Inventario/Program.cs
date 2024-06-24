
Dictionary<string, int> inventario = new Dictionary<string, int>();

while (true)
{

    Console.WriteLine("\n1. Agregar Producto");
    Console.WriteLine("2. Eliminar Producto");
    Console.WriteLine("3. Actualizar Cantidad");
    Console.WriteLine("4. Mostrar Inventario");
    Console.WriteLine("5. Salir");
    Console.Write("\nElige una Opcion: ");


    int opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {

        case 1:
            Console.WriteLine("Ingresa el nombre del nuevo producto: ");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa la cantidad : ");
            int cantida = int.Parse(Console.ReadLine());


            if (inventario.ContainsKey(Nombre))
            {
                Console.WriteLine($"El producto´{Nombre}´ Se agrego Correctamente");
            }
            else
            {
                inventario.Add(Nombre, cantida);
                Console.WriteLine($"\nEl producto´{Nombre}´fue agregado a la Opcion 4");
            }
            break;



        case 2:
            Console.WriteLine("Ingrese el nombre del producto que desea eliminar: ");
            string elimina = Console.ReadLine();
            inventario.Remove(elimina);
        


            if (inventario.ContainsKey(elimina))
            {
                inventario.Remove(elimina);
                Console.WriteLine($"el producto ´{elimina}´ se elimino ");

            }
            else
            {
                Console.WriteLine($"el producto '{elimina}' Se elimino Correctamente");
            };

            break;


        case 3:
            Console.Write("Ingrese el Nombre del Producto que desea Actualizar: ");
            string actualizar = Console.ReadLine();
            Console.Write("Ingrese la Nueva Cantidad: ");
            if (inventario.ContainsKey(actualizar))
            {
 
                if (!int.TryParse(Console.ReadLine(), out int nuevaCantidad) || nuevaCantidad < 0)

                  Console.WriteLine($"Cantidad actual de '{actualizar}': {inventario[actualizar]}.");
                inventario[actualizar] = nuevaCantidad;
                Console.WriteLine($"El Producto '{actualizar}'  se actualizo a '{nuevaCantidad}'.");
            } 
            else
            {
                Console.WriteLine($"El producto '{actualizar}' no existe en el inventario.");
            }
            break;


        case 4:
            Console.WriteLine("Los Productos que hay dentro del Invenrario son: ");
            foreach (var ivt in inventario)
            {
                Console.WriteLine($"{ivt.Key}: {ivt.Value}");
            }
            break;




        case 5:
            Console.WriteLine("Fin del Programa");

            return;


        default:
            Console.WriteLine("Opcion invalida");
            break;
    }
  
}

