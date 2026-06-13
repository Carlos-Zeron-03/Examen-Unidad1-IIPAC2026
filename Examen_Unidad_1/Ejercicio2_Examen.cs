namespace Examen_Unidad1_POO.Examen_Unidad_1
{
    public class Ejercicio2_Examen
    {
        public Ejercicio2_Examen()
        {
            decimal saldo = 7500m;
            string categoría;
            string mensaje;

            if (saldo < 1000)
            {
                categoría = "Básico";
                mensaje = "Abra un CDT para mejorar su categoría.";
            }
            else
            {
                if (saldo < 5000)
                {
                    categoría = "Plata";
                    mensaje = "Tiene acceso a tarjeta de débito sin comisión.";
                }
                else
                {
                    if (saldo < 20000)
                    {
                        categoría = "Oro";
                        mensaje = "¡Felicidades! Accede a tasas preferenciales.";
                    }
                    else
                    {
                        categoría = "Platino";
                        mensaje = "¡Cliente VIP! Accede a todos los beneficios del banco.";
                    }
               }
            }
            Console.WriteLine($"Saldo: L. {saldo:F2}");
            Console.WriteLine($"Categoría asignada: {categoría}");
            Console.WriteLine(mensaje);
        }   
    }
}