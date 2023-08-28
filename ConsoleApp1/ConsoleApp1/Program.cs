public class numPar
{
    static void Main(string[] args)
    {
        //declarar variables
        int num, cociente;

        Console.WriteLine("Ingrese un número; ");
        num = Convert.ToInt32(Console.ReadLine());
        cociente = num % 2;

        //proceso
        if (cociente == 0 )
        {
            Console.WriteLine("El número es par ");

        }
        else
        {

            Console.WriteLine("El número es impar ");
        }

    }

}
