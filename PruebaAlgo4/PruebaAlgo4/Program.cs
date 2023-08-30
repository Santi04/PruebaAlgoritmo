//Escribir un programa que convierta un valor dado en grados Fahrenheit a grados Celsius.

public class conversorgrados
{
    static void Main(string[] args)
    {
        //delcaración var
        double celcius, farenheit;

        //entrada
        Console.WriteLine("Ingrese grados °F que desea convertir a °C: ");
        farenheit = Convert.ToDouble(Console.ReadLine());

        //proceso

        celcius = (((farenheit - 32)*5)/9);


        //datos de salida
        Console.WriteLine(farenheit + "°F son: " + celcius + "°C");
    }


}
