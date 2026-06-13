namespace Examen_Unidad1_POO.Examen_Unidad_1
{
    public class Ejercicio1_Examen_Tipo_Variables
    {
        public Ejercicio1_Examen_Tipo_Variables()
        {
            string nombreProducto = "Fertilizante NPK";
            decimal precioPorKg = 35.75m;
            int cantidadKg = 12;
            decimal descuentoPorcentaje = 10m;
            decimal subtotal = precioPorKg * cantidadKg;
            decimal descuento = subtotal * descuentoPorcentaje / 100;
            decimal totalFinal = subtotal - descuento;

            Console.WriteLine("--------- Factura AgroCoprán ---------");
            Console.WriteLine($"Producto: {nombreProducto}");
            Console.WriteLine($"Precio/Kg: L. {precioPorKg}");
            Console.WriteLine($"Subtotal: L. {subtotal:F2}");
            Console.WriteLine($"Descuento: L. {descuento:F2}");
            Console.WriteLine($"Total: L. {totalFinal:F2}");
        }
    }
}