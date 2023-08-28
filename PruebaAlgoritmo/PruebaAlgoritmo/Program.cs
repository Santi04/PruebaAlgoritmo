public class algortimo
{

    static void Main(string[] args)
    {

        //declaración variables
        int num1, num2, division;

        Console.WriteLine("Ingrese el número 1: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el número 2: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        //proceso

        if (num1 > num2)
        {
            Console.WriteLine("El número mayor es: " + num1);
            division = (num1 / num2);

        }
        else
        {

            Console.WriteLine("El número mayor es: " + num2);
            division = (num2 / num1);

        }
        //datos de salida
        Console.WriteLine("El resultado de la división es: " + division);

    }

}