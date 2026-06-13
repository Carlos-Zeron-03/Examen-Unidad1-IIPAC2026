namespace Examen_Unidad1_POO.Examen_Unidad_1
{
    public class Ejercicio3_Examen_Tabla_Multiplicar
    {
        public Ejercicio3_Examen_Tabla_Multiplicar()
        {
            Console.Write("Ingrese el número de tabla: ");
            string entradaTabla = Console.ReadLine();

            Console.Write("Ingrese el límite: ");
            string entradaLimite = Console.ReadLine();

            if (int.TryParse(entradaTabla, out int tabla) && int.TryParse(entradaLimite, out int limite))
            {
                if (tabla < 0)
                {
                    Console.WriteLine("El numero ingresado no es valido, tiene que ser un numero mayor a 0.");
                    return;
                }

                Console.WriteLine($"\nTabla de multiplicar del {tabla}");
                for (int i = 1; i <= limite; i++)
                {
                    Console.WriteLine($"{tabla} x {i} = {tabla * i}");
                }
            }
            else
            {
                Console.WriteLine("Entrada no valida.");
            }
        }
    }
}