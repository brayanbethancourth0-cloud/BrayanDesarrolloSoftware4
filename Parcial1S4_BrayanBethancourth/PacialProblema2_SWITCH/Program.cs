namespace ParcialProblema2_SWITCH
{
    class programa2()
    {
        static void Main()
        {


            int edad;
            double tarifa = 0, precio = 0, descuento = 0, total;
            //slicitud de el dato de entrada
            Console.WriteLine("Igrese su edad: ");
            Console.WriteLine("1 = Edad entre 1-20.");
            Console.WriteLine("2 = Edad entre 21 - 45. ");
            Console.WriteLine("3 = Edad entre 46 - 60.");
            Console.WriteLine("4 = Edad mayor  a 60.");
            edad = int.Parse(Console.ReadLine());

            //menu para validar el rango de edad y precio de entrada
            switch (edad)
            {
                case 1:
                    Console.WriteLine("Cliente con edad entre 1-20");
                    tarifa = 3.75;
                    descuento = 0.10;
                    break;
                case 2:
                    Console.WriteLine("Cliente con edad entre 21 - 45. ");
                    tarifa = 4.75;
                    descuento = 0.10;
                    break;
                case 3:
                    Console.WriteLine("Cliente con edad entre 46 - 60");
                    tarifa = 5.75;
                    descuento = 0.15;
                    break;
                case 4:
                    Console.WriteLine("Cliente con edad mayor  a 60");
                    tarifa = 6.75;
                    descuento = 0.15;
                    break;
                default:
                    Console.WriteLine("Rango de edad invalido!");
                    return;
            }

            //calculo de descueto y precio total
            precio = tarifa;
            descuento = precio * descuento;
            total = (precio - descuento) + 2.5;
            //salidas
            Console.WriteLine($"Total a pagar:{total:F2} ");

        }
    }
}