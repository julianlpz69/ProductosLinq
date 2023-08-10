namespace tiendaProducots
{
    public class convertJson
    {
        public static string fileName = "productos.json" ;
        public static Dictionary<int,Producto> productos = new();

        public static string Filename {get => fileName; set => fileName =value;} 
        public static Dictionary<int,Producto> Productos {get => productos; set => productos =value;}
    }
}