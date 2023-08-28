//Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor de los números ingresados

public class mayor
{
    static void Main(string[] args)
    {
        //declaración variables
        int n1, n2, n3, mayor;

        Console.WriteLine("Ingrese el número 1: ");
        n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el número 2: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el número 3: ");
        n3 = Convert.ToInt32(Console.ReadLine());

        //proceso
        if(n1 > n2 && n1 > n3) 
        {
            mayor = n1;
        //Console.WriteLine("El número mayor es: " + mayor);

        }else if(n2 > n1 && n2 > n3)
        {
            mayor = n2;
          //  Console.WriteLine("El número mayor es: " + mayor);
        }
        else
        {
            mayor = n3;
          //  Console.WriteLine("El número mayor es: " + mayor);
        }

        Console.WriteLine("El número mayor es: " + mayor);

    }
}
