//Dados los catetos de un triángulo rectángulo, calcular su hipotenusa
public class hipotenusa
{
    static void Main(string[] args)
    {
        //declaración variables
        double cateto1, cateto2, hipotenusa;

        //entrada
        Console.WriteLine("Ingrese el cateto #1: ");
        cateto1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el cateto #2: ");
        cateto2 = Convert.ToDouble(Console.ReadLine());

        //proceso
        hipotenusa = Math.Sqrt(cateto1 * cateto1 + cateto2 * cateto2);


        //salida
        Console.WriteLine("La hipotenusa es: " + hipotenusa);
    }

}
