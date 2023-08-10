namespace tiendaProducots
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }

        public Categoria(){}

        public void AgregarCategoria(Dictionary<int,Categoria> Categorias, Categoria categoria){

            Console.Clear();
            Console.Write("\nIngresa el ID de la Categoria\t");
            IdCategoria = int.Parse(Console.ReadLine());

            Console.Write("\nIngresa La Descripcion De La Categoria\t");
            Descripcion = Console.ReadLine();

            Categorias.Add(IdCategoria,categoria);
        }

        public void ListarCategorias(Dictionary<int,Categoria> Categorias){

            Console.Clear();
            Console.WriteLine("---------------LISTADO DE CATEGORIAS---------------\n");
            Console.WriteLine("{0,5} {1,30}", "Id Categoria","Nombre Categoria\n");
            foreach(var categoria in Categorias.Values){
                Console.WriteLine("{0,5} {1,30}", categoria.IdCategoria,categoria.Descripcion );
            }
            Console.ReadKey();
        }
    }
}