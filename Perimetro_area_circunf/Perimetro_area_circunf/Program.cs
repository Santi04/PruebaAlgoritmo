/*Realizar un algoritmo C# donde me permita calcular el perímetro/circunferencia y área de las siguientes
figuras geométricas: cuadrado, rectángulo, triángulo y círculo.
Mostrar en pantalla los valores calculados por cada figura geométrica.*/

public class pitagoras
{
    static void Main(string[] args)
    {
        //declaración variables
        double ladoCuadrado, periCuadrado, areaCuadrado, baseRec, altRec, periRec, areaRec, lado1Triangulo, lado2Triangulo,
            lado3Triangulo, altTriangulo, periTriangulo, areaTriangulo, radioCir, periCir, areaCir;

        /*datos de entrada
         para el circulo se necesita radio
        para el cuadro 1 lado
        rectangulo base y altura
        triangulo 3 la
         */

        Console.WriteLine("Ingrese un lado del cuadrado: ");
        ladoCuadrado = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la base del rectangulo: ");
        baseRec = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la altura del rectangulo: ");
        altRec = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el lado 1 del triangulo: ");
        lado1Triangulo = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el lado 2 del triangulo: ");
        lado2Triangulo = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el lado 3 del triangulo: ");
        lado3Triangulo = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la altura del triangulo: ");
        altTriangulo = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el radio del circulo: ");
        radioCir = double.Parse(Console.ReadLine());

        //proceso
        periCuadrado = ladoCuadrado * 4;
        areaCuadrado = ladoCuadrado * 2;
        periRec = (baseRec * 2 + altRec * 2);
        areaRec = baseRec * altRec;
        areaTriangulo = (lado1Triangulo * altTriangulo) / 2;
        periTriangulo = lado1Triangulo + lado2Triangulo + lado3Triangulo;
        periCir = Math.PI * 2 * radioCir;
        areaCir = Math.PI * Math.Pow(radioCir, 2);

        //salida

        Console.WriteLine("El perimetro del cuadrado es: " + periCuadrado);
        Console.WriteLine("El area del cuadrado es: " + areaCuadrado);
        Console.WriteLine("El perimetro del rectangulo es: " + periRec);
        Console.WriteLine("El area del rectangulo es: " + areaRec);
        Console.WriteLine("El perimetro del triangulo es: " + periTriangulo);
        Console.WriteLine("El area del triangulo es: " + areaTriangulo);
        Console.WriteLine("El perimetro del circulo es: " + periCir);
        Console.WriteLine("El area del circulo es: " + areaCir);

    }

}
