namespace tiendaProducots
{
    public class Menu
    {
        public Menu(){

        }

        public void menuPrincipal(){
            Console.Clear();
            Console.WriteLine("\n ---------------------- Menu Principal -----------------");
            Console.WriteLine("\n1. Regitrar Producto");
            Console.WriteLine("2. Registrar Categoria");
            Console.WriteLine("3. Listar Categorias");
            Console.WriteLine("4. Listar Producots");
            Console.WriteLine("5. Costo Total del Inventario");
            Console.WriteLine("6. Salir");
        }

        public int PedirOpcion() {
            Console.Write("\nElige una opción:\t");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}