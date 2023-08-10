using Newtonsoft.Json;

namespace tiendaProducots
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public int StockMin { get; set; }
        public int StockMax { get; set; }
        public double PrecioVenta { get; set; }
        public double PrecioCompra { get; set; }
        public int IdCategoria { get; set; }


        public Producto(){
            if(!File.Exists(convertJson.Filename)){
                File.WriteAllText(convertJson.Filename, "");
            }
        }

        public void AgregarProducto(Dictionary<int,Categoria> Categorias,Dictionary<int,Producto> Prodcutos,Producto nuevoProducto ){
            
            Console.Clear();
            if(Categorias.Count>0){

                Console.WriteLine("Escribe El Id De la Categoria a la que Pertenece este Producto");
                int id = int.Parse(Console.ReadLine());

                if(Categorias.ContainsKey(id)){
                    
                    IdCategoria = id;

                    Console.WriteLine("Escribe el Id Del Producto");
                    IdProducto = int.Parse(Console.ReadLine());

                    Console.WriteLine("Escribe el Nombre del Producto");
                    Nombre = Console.ReadLine();

                    Console.WriteLine("Escribe el Stock Actual del Producto");
                    Stock = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Escribe el Stock Minimo para este Producto");
                    StockMin = int.Parse(Console.ReadLine());

                    Console.WriteLine("Escribe el Stock Maximo para este Producto");
                    StockMax = int.Parse(Console.ReadLine());

                    Console.WriteLine("Escribe el Precio de Compra del Producto");
                    PrecioCompra = double.Parse(Console.ReadLine());

                    Console.WriteLine("Escribe el Precio de Venta del Producto");
                    PrecioVenta = double.Parse(Console.ReadLine());

                    Prodcutos.Add(IdProducto,nuevoProducto);
                    convertJson.Productos.Add(IdProducto,nuevoProducto);

                    string json = JsonConvert.SerializeObject(convertJson.Productos, Formatting.Indented);
                    File.WriteAllText(convertJson.Filename, json);

                    Console.Clear();
                    Console.WriteLine($"Se ha registrado Correctamente el Producto {Nombre}");
                    Console.ReadKey();


                }   
                else{
                    Console.Clear();
                    Console.WriteLine("\nCodigo de Categoria no Existente");
                    Console.ReadKey();
                }

                

                
            }
            else{
                Console.Clear();
                Console.WriteLine("\nRegistra Alguna Categoria Para Asociar al Producto");
                Console.ReadKey();
            }
            

        }

        public void ListarProductos(Dictionary<int,Producto> Productos){

            Console.Clear();
            Console.WriteLine("---------------LISTADO DE PRODUCTOS---------------\n");
            Console.WriteLine("{0,5}{1,28}{2,28}", "Id Producto","Nombre Producto","Stock Producto");
            foreach(var producto in Productos.Values){
                Console.WriteLine("{0,5} {1,30} {2,28}", producto.IdProducto,producto.Nombre, producto.Stock );
            }
            Console.ReadKey();
        }


        public void TotalInventario(Dictionary<int,Producto> Productos){
            Console.Clear();
            double Total = 0.0;
            Console.WriteLine("---------------------------------------------VALOR DEL INVENTARIO---------------------------------------------\n");
            Console.WriteLine("{0,5}{1,28}{2,28}{3,28}{4,28}", "Id Producto","Nombre Producto","Stock","Valor/U","SubTotal");
            foreach(var producto in Productos.Values){
                Total += (producto.Stock*producto.PrecioCompra);
                Console.WriteLine("{0,5}{1,28}{2,28}{3,28}{4,28}", producto.IdProducto,producto.Nombre, producto.Stock,producto.PrecioCompra,(producto.Stock*producto.PrecioCompra) );
            }
            Console.WriteLine("{0,65}", $"\n\nTotal : {Total}");
            Console.ReadKey();
        }


    }
}