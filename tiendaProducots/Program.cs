
using tiendaProducots;

internal class Program
{
    private static void Main()
    {

        

        Dictionary<int,Categoria> Categorias = new();
        Dictionary<int,Producto> Productos = new();



        Menu inicio = new();
        int opcion;

        do {
            inicio.menuPrincipal();
            opcion = inicio.PedirOpcion();

            switch (opcion) {
                case 1: //---------------------------------------------------------------------------------------------
                        Producto nuevoProducto = new();
                        nuevoProducto.AgregarProducto(Categorias,Productos,nuevoProducto);
                        break;
                case 2:
                        Categoria nuevaCategoria = new();
                        nuevaCategoria.AgregarCategoria(Categorias,nuevaCategoria);
                        break;
                case 3:
                        Categoria nuevaCategoria2 = new();
                        nuevaCategoria2.ListarCategorias(Categorias);
                        break;
                case 4 :
                        Producto nuevoProducto2 = new();
                        nuevoProducto2.ListarProductos(Productos);
                        break;
                case 5 :
                        Producto nuevoProducto3 = new();
                        nuevoProducto3.TotalInventario(Productos);
                        break;
                case 6:
                        break;                

                default:
                        Console.WriteLine("Opcion Invalida");
                        break;
}} while (opcion != 6);


    

    }
}