using System;

namespace portafolioC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int num1, num2, res;
            Console.WriteLine("Digite el primer numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el segundo numero");
            num2 = int.Parse(Console.ReadLine());

            res = num1 + num2;
            Console.WriteLine($"El primer numero es {num1}" );
            Console.WriteLine($"El segundo numero es {num2}" );
            Console.WriteLine($"La suma de los numeros es: {num1} + {num2} = {res}" );*/ 

            int cantidad, cobro, pago;

            Console.WriteLine("Digite la cantidad de productos a vender");
            cantidad = int.Parse(Console.ReadLine());
            
            cobro = cantidad*10000;
            Console.WriteLine($"El valor de la venta es {cobro}");

            Console.WriteLine($"Ingrese el monto con el quie paga el cliente" );
            pago = int.Parse(Console.ReadLine());

            Console.WriteLine($"El cambio que debe entregar al cliente es: {pago - cobro}" );
        }
    }
}


