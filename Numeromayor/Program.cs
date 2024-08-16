using System;

namespace numeromayorymenor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este es un programa para saber que numero es mayor o menor\n ");
            int num1, num2, num3;

            Console.WriteLine("Diga el primer numero\n ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Diga el segundo numero\n ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Diga el tercer numero\n ");
            num3 = int.Parse(Console.ReadLine());

            int mayor = num1;
            int menor = num1;


            if (num2 > mayor)
                mayor = num2;

            if (num3 > mayor)
                mayor = num3;


            if (num2 < menor)
                menor = num2;
            if (num3 < menor)
                menor = num3;

            Console.WriteLine("El numero mayor es: " + mayor);
            Console.WriteLine("El numero menor es: " + menor);

        }
    }
}