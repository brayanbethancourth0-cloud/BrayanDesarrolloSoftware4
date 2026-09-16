namespace Programa1_IF
{

    class programa1
    {
        static void Main()
        {


            double parcial1, parcial2, asistencia, promedio = 0, calificacinfinal, bonificacion;
            int nivel;

            Console.WriteLine($"Ingrese la nota de su parcial 1: ");
            parcial1 = double.Parse(Console.ReadLine());
            if (parcial1 < 0 || parcial1 > 100)//validacion de datos invalidos
            {
                Console.WriteLine($"Error! Las notas deben estar en el rango permitido(1-100)");
                return;
            }
            Console.WriteLine($"Ingrese la nota de su parcial 2: ");
            parcial2 = double.Parse(Console.ReadLine());//validacion de datos invalidos
            if (parcial2 < 0 || parcial2 > 100)
            {
                Console.WriteLine($"Error! Las notas deben estar en el rango permitido(1-100)");
                return;
            }

            Console.WriteLine($"Ingrese su porcentaje de asistencia: ");
            asistencia = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el nivel de curso(1,2 o 3):  ");
            nivel = int.Parse(Console.ReadLine());

            //calculos
            promedio = (parcial1 + parcial2) / 2;
            bonificacion = asistencia * 0.05;
            calificacinfinal = promedio + bonificacion;


            //validacion estudiante reprobado
            if (asistencia < 70 || promedio < 60)
            {
                Console.WriteLine("Reprobado, no ha cumplido cn¿on los requisios para aprobar!");
            }
            //validacio estudiante de excelencia
            if (parcial1 > 90 && parcial2 > 90)
            {
                Console.WriteLine("Estudiante candidato a excelencia educativa!");
            }
            //validaion estudiante de mencion honorifica
            if (promedio >= 70 && promedio <= 89)
            {
                Console.WriteLine("Estudiante de mención honorifica!");
            }

            //Salidas
            Console.WriteLine($"Calificación Final: {calificacinfinal:F2}");
            Console.WriteLine($"Nivel de curso: {nivel}");
        }
    }
}



