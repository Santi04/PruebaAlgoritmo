namespace Ejemplo_menu
{
    class Program
    {
        static void Main(string[] args)
        {

            bool salir = false;

            while (!salir)
            {

                try
                {

                    Console.WriteLine("1. Ingrese 1 para suma");
                    Console.WriteLine("2. Ingrese 2 para resta");
                    Console.WriteLine("3. Ingrese 3 para multiplicación");
                    Console.WriteLine("3. Ingrese 4 para división");
                    Console.WriteLine("4. Salir");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Has elegido la opción 1");
                            break;

                        case 2:
                            Console.WriteLine("Has elegido la opción 2");
                            break;

                        case 3:
                            Console.WriteLine("Has elegido la opción 3");
                            break;
                        case 4:
                            Console.WriteLine("Has elegido salir de la aplicación");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 4");
                            break;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.ReadLine();

        }
    }
}