namespace Examen_Unidad1_POO.Examen_Unidad_1
{
    public class Ejercicio4_Examen_Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public Ejercicio4_Examen_Producto (string nombre, decimal precio, int stock)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        public string ObtenerInfo()
        {
            return $"{Nombre} -- Precio: L. {Precio:F2} -- Stock: {Stock} unidades";
        }

        public decimal CalcularValorInventario()
        {
            return Precio * Stock;
        }

        public void AplicarDescuento(decimal porcentaje)
        {
            Precio -= Precio * porcentaje / 100;
        }
    }
}