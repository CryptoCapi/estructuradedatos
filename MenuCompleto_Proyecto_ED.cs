
using System;

namespace ProyectoFinal_ED
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("MENÚ DE PROGRAMAS - DIEGO MANCERA");
                Console.WriteLine("1. Suma de dos números");
                Console.WriteLine("2. Dígitos en orden inverso");
                Console.WriteLine("3. Verificar número primo");
                Console.WriteLine("4. Verificar si un número es potencia de otro");
                Console.WriteLine("5. Distancia entre dos puntos");
                Console.WriteLine("6. Factorial de un número");
                Console.WriteLine("7. Verificar triángulo válido");
                Console.WriteLine("8. Verificar superposición de rectángulos");
                Console.WriteLine("9. Cara opuesta de un dado");
                Console.WriteLine("10. Par o impar");
                Console.WriteLine("11. Tabla de multiplicar");
                Console.WriteLine("12. Número más cercano divisible");
                Console.WriteLine("13. Invertir cifra");
                Console.WriteLine("14. Suma de dígitos de un número");
                Console.WriteLine("0. Salir");
                Console.Write("Selecciona una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingresa el primer número: ");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.Write("Ingresa el segundo número: ");
                        int n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado: {n1 + n2}");
                        break;

                    case 2:
                        Console.Write("Ingresa un número: ");
                        int numInv = int.Parse(Console.ReadLine());
                        string invStr = numInv.ToString();
                        char[] arr = invStr.ToCharArray();
                        Array.Reverse(arr);
                        Console.WriteLine($"Invertido: {new string(arr)}");
                        break;

                    case 3:
                        Console.Write("Ingresa un número: ");
                        int primo = int.Parse(Console.ReadLine());
                        bool esPrimo = true;
                        for (int i = 2; i < primo; i++)
                            if (primo % i == 0) esPrimo = false;
                        Console.WriteLine(esPrimo ? "Es primo" : "No es primo");
                        break;

                    case 4:
                        Console.Write("Ingresa base: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.Write("Ingresa potencia: ");
                        int p = int.Parse(Console.ReadLine());
                        double pow = Math.Pow(b, Math.Log(p, b));
                        Console.WriteLine(Math.Abs(pow - p) < 0.001 ? "Es potencia" : "No es potencia");
                        break;

                    case 5:
                        Console.Write("x1: "); double x1 = double.Parse(Console.ReadLine());
                        Console.Write("y1: "); double y1 = double.Parse(Console.ReadLine());
                        Console.Write("x2: "); double x2 = double.Parse(Console.ReadLine());
                        Console.Write("y2: "); double y2 = double.Parse(Console.ReadLine());
                        double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                        Console.WriteLine($"Distancia: {d}");
                        break;

                    case 6:
                        Console.Write("Ingresa un número: ");
                        int fact = int.Parse(Console.ReadLine());
                        long r = 1;
                        for (int i = 1; i <= fact; i++) r *= i;
                        Console.WriteLine($"Factorial: {r}");
                        break;

                    case 7:
                        Console.Write("Lado A: "); int a = int.Parse(Console.ReadLine());
                        Console.Write("Lado B: "); int b1 = int.Parse(Console.ReadLine());
                        Console.Write("Lado C: "); int c = int.Parse(Console.ReadLine());
                        if (a + b1 > c && a + c > b1 && b1 + c > a)
                            Console.WriteLine("Triángulo válido");
                        else Console.WriteLine("No es triángulo válido");
                        break;

                    case 8:
                        Console.Write("Rect1 x, y, ancho, alto: ");
                        int x = int.Parse(Console.ReadLine());
                        int y = int.Parse(Console.ReadLine());
                        int w = int.Parse(Console.ReadLine());
                        int h = int.Parse(Console.ReadLine());
                        Console.Write("Rect2 x, y, ancho, alto: ");
                        int x2r = int.Parse(Console.ReadLine());
                        int y2r = int.Parse(Console.ReadLine());
                        int w2 = int.Parse(Console.ReadLine());
                        int h2 = int.Parse(Console.ReadLine());
                        bool superponen = !(x + w < x2r || x2r + w2 < x || y + h < y2r || y2r + h2 < y);
                        Console.WriteLine(superponen ? "Se superponen" : "No se superponen");
                        break;

                    case 9:
                        Console.Write("Cara del dado (1-6): ");
                        int cara = int.Parse(Console.ReadLine());
                        if (cara >= 1 && cara <= 6)
                            Console.WriteLine($"Cara opuesta: {7 - cara}");
                        else Console.WriteLine("Cara inválida");
                        break;

                    case 10:
                        Console.Write("Ingresa un número: ");
                        int numPar = int.Parse(Console.ReadLine());
                        Console.WriteLine(numPar % 2 == 0 ? "Par" : "Impar");
                        break;

                    case 11:
                        Console.Write("Número base: ");
                        int baseT = int.Parse(Console.ReadLine());
                        Console.Write("Hasta qué número: ");
                        int hasta = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= hasta; i++)
                            Console.WriteLine($"{baseT} x {i} = {baseT * i}");
                        break;

                    case 12:
                        Console.Write("Ingresa n: ");
                        int n = int.Parse(Console.ReadLine());
                        Console.Write("Ingresa m: ");
                        int m = int.Parse(Console.ReadLine());
                        int temp = n;
                        while (temp % m != 0) temp--;
                        Console.WriteLine($"Más cercano divisible: {temp}");
                        break;

                    case 13:
                        Console.Write("Ingresa una palabra o cifra: ");
                        string texto = Console.ReadLine();
                        char[] rev = texto.ToCharArray();
                        Array.Reverse(rev);
                        Console.WriteLine($"Invertido: {new string(rev)}");
                        break;

                    case 14:
                        Console.Write("Ingresa un número: ");
                        int numero = int.Parse(Console.ReadLine());
                        int suma = 0;
                        while (numero > 0)
                        {
                            suma += numero % 10;
                            numero /= 10;
                        }
                        Console.WriteLine($"Suma de dígitos: {suma}");
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                Console.WriteLine("\nPresiona una tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 0);
        }
    }
}
