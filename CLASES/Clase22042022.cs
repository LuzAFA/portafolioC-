using System;

namespace portafolioC_
{
    internal class Clase22042022
    {
        public static void mayorDeDosNumeros()
        {

            //Realice un programa que verifique cual de dos números es mayor.

            int num1, num2;

            Console.WriteLine("Digite el primer numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el segundo numero");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"El número mayor es, numero 1");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"El número mayor es, numero 2");
            }
            else
            {
                Console.WriteLine($"Los numeros son iguales");
            }
        }

        public static void mayorDeDosNumerosYSuSigno()
        {

            //Realice un programa que verifique cual de dos números es mayor y diga si es positivo negativo o neutro.

            int num1, num2;

            Console.WriteLine("Digite el primer numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el segundo numero");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 == 0)
                {
                    Console.WriteLine($"El número mayor es {num1} y es NEUTRO");
                }
                else if (num1 < 0)
                {
                    Console.WriteLine($"El número mayor es {num1} y es NEGATIVO");
                }
                else
                {
                    Console.WriteLine($"El número mayor es {num1} y es POSITIVO");
                }

            }
            else if (num1 < num2)
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"El número mayor es {num2} y es NEUTRO");
                }
                else if (num2 < 0)
                {
                    Console.WriteLine($"El número mayor es {num2} y es NEGATIVO");
                }
                else
                {
                    Console.WriteLine($"El número mayor es {num2} y es POSITIVO");
                }
            }
            else if (num1 == num2)
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"El número mayor es {num2} y es NEUTRO");
                }
                else if (num2 < 0)
                {
                    Console.WriteLine($"El número mayor es {num2} y es NEGATIVO");
                }
                else
                {
                    Console.WriteLine($"El número mayor es {num2} y es POSITIVO");
                }
            }
        }

        public static void menuCalculadora()
        {

            int opcion, num1, num2;



            Console.WriteLine("Digite el primer numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el segundo numero");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Menu de opciones");
            Console.WriteLine("1. suma, 2. reesta, 3.multiplicacion, 4. division");
            Console.WriteLine("selecione una opcion del menu (escriba el numero sin puntos o espacios)");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"la suma es: {num1} + {num2} = {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"la resta es: {num1} - {num2} = {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"la multiplicacion es: {num1} + {num2} = {num1 * num2}");
                    break;
                case 4:
                    Console.WriteLine($"la division es: {num1} / {num2} = {num1 / num2}");
                    break;
                default:
                    Console.WriteLine($"SELECCIONE UNA OPCION VALIDA ");
                    break;
            }

        }

        public static void juegoCraps()
        {
            Random random = new Random();
            int dado1 = random.Next(1, 7);

            random = new Random();
            int dado2 = random.Next(1, 7);
            Console.WriteLine($"El lanzamiento es {dado1}, {dado2}");

            switch (dado1 + dado2)
            {
                case 2:
                    Console.WriteLine($"WIIIII!!!!!!!");
                    break;
                case 3:
                    Console.WriteLine($"WIIIII!!!!!!!");
                    break;
                case 7:
                    Console.WriteLine($"WIIIII!!!!!!!");
                    break;
                case 11:
                    Console.WriteLine($"WIIIII!!!!!!!");
                    break;
                case 12:
                    Console.WriteLine($"WIIIII!!!!!!!");
                    break;
                default:
                    Console.WriteLine($"owwww :( vuelve a intentarlo ");
                    break;
            }


        }
    }
}
