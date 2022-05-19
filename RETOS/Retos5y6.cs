namespace portafolioC_
{
    internal class Retos5y6
    {
        /* RETO 6
        Al ejercicio de Supermercados Noé, agregar
    
        ❑ Posibilidad para registrar precio y cantidad de los productos
        adquiridos por un cliente (sin importar la cantidad) en lugar
        de recibir el valor de la compra.
        ❑ Implementar un acumulador que calcule el valor a pagar luego de
        registrar los productos
        ❑ Mantenga la comprobación de si es beneficiado con el descuento
        por su compra
        ❑ Mantenga la generación de la bolita aleatoriamente
        ❑ Mantenga el mensaje al usuario que le dice si obtuvo un descuento y
        muestre cual es el valor final a pagar con el descuento aplicado
        ❑ Capture el valor con el que el cliente paga
        ❑ Calcule y muestre el cambio.
        */
        public static void reto6()
        {
            string continua = "";
            float totalConDescuento = 0; //totalCompra Descuento
            int totalCompra = 0;
            int cantidadProductos = 0;
            int valorUnitarioProducto = 0;
            float porcentajeDescuento = 0;

            Random random = new Random();
            int bola = random.Next(1, 5);
            float VAP = 0; // Valor A Pagar
            float Vueltas = 0;

            do
            {
                Console.WriteLine(
                    "Digite cuantos productos de una misma referencia desea ingresar"
                );
                cantidadProductos = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite el valor unitario del producto");
                valorUnitarioProducto = int.Parse(Console.ReadLine());

                totalCompra += cantidadProductos * valorUnitarioProducto;

                Console.WriteLine(
                    $"Ha ingresado {cantidadProductos} de productos de la misma referencia \npor un valor unitario de {valorUnitarioProducto} \npara un total de {cantidadProductos * valorUnitarioProducto}"
                );

                Console.WriteLine("Desea registrar un nuevo producto? producto? Si/No");
                continua = (Console.ReadLine()).ToUpper();
            } while (continua == "SI");

            Console.WriteLine($"USted ha hecho una compra por un total de ${totalCompra}");

            if (totalCompra >= 50000)
            {
                Console.WriteLine(
                    "Felicidades usted ha sido seleccionado para participar en nuestro sorteo!"
                );

                Console.WriteLine(
                    $"El total que debes pagar de tu compra, es {totalConDescuento} pesos"
                );
            }
            else
            {
                Console.WriteLine(
                    "Recuerda que por compras mayores a $50000 puedes participar en nuestor sorteo, animate, puedes ser un ganador!!!"
                );
            }

            Console.WriteLine("Con cuanto va a pagar?");
            VAP = float.Parse(Console.ReadLine());
            Vueltas = VAP - totalConDescuento;
            Console.WriteLine($"El dinero a devolver es ${Vueltas}");

            /////////////////////////////////////////////////////////////////////////\x


            if (totalCompra >= 50000)
            {
                Console.WriteLine(
                    "Felicidades, has sido seleccionado para participar por nuestro descuento"
                );

                if (bola == 1)
                    porcentajeDescuento = 0.1f;
                else if (bola == 2)

                    porcentajeDescuento = 0.3f;
                else if (bola == 3)
                    porcentajeDescuento = 0.5f;
                else
                    porcentajeDescuento = 1.0f;

                totalConDescuento = totalCompra - (totalCompra * porcentajeDescuento);

                string bolita =
                    bola == 1
                        ? "Roja"
                        : bola == 2
                            ? "Azul"
                            : bola == 3
                                ? "Amarila"
                                : "Blanca";

                Console.WriteLine(
                    $"Has sacado la bolita {bolita}!!! tu descuento será de el {porcentajeDescuento * 100}% de su compra"
                );
            }
            else
            {
                Console.WriteLine(
                    "Solo con compras mayores a 50000 puedes participar en nuestra rifa de descuentos"
                );
            }

            Console.WriteLine(
                $"El total que debes pagar de tu compra, es {totalConDescuento} pesos"
            );
        }
    }
}
