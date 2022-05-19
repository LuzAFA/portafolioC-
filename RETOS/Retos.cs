namespace portafolioC_
{
    internal class Retos
    {
        /* RETO 1
        ¡La abuela tiene horno nuevo! y ha planeado hacer una deliciosa torta de vainilla
        con relleno de crema y fresas.
        La receta dice que debe precalentar el horno a 350 °F (grados Fahrenheit),
        pero su horno muestra la temperatura en °C (grados Centígrados).
        Ayúdale a la abuela a colocar la temperatura correcta.
        Crea un programa en java que convierta grados Fahrenheit (°F) a Centígrados (°C)
        teniendo en cuenta lo siguiente:

        °C=(°F - 32)/1.8

        */
        public static void reto1()
        {
            double gFahrenheit,
                gCentigrados;

            Console.WriteLine("Digite la cantidad de grados Fahrenheit a convertir");
            gFahrenheit = double.Parse(Console.ReadLine());

            gCentigrados = (gFahrenheit - 32) / 1.8;
            Console.WriteLine(
                $"{gFahrenheit} grados Fahrenheit son equivalentes a {gCentigrados} grados Centígrados"
            );
        }

        /* RETO 2
        El centro de salud Famisalud, aplica vacunas a los bebes menores de un año y la dosis a aplicar
        depende del peso y la edad del bebé según la siguiente fórmula:
        dosisvacuna = ((pesobebe ] 10)/(mesesbebe x 10)) * 8
        Realice un programa en java que le permita a la enfermera, determinar con facilidad la
        dosis de la vacuna que se debe aplicar a un bebé.
        */

        public static void reto2()
        {
            double dosisvacuna,
                pesobebe,
                mesesbebe;

            Console.WriteLine("Digite el peso del bebe");
            pesobebe = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite la edad del bebe en meses");
            mesesbebe = double.Parse(Console.ReadLine());

            dosisvacuna = ((pesobebe + 10) / (mesesbebe * 10)) * 8;
            Console.WriteLine($"La dosis que se le debe administrar al bebe es  {dosisvacuna}");
        }

        /* RETO 3
        Se pretende construir un programa que simule el juego del carisellazo,
        teniendo en cuenta lo siguiente:

            Se juega contra la máquina
            Se debe simular el lanzamiento de una moneda
            El jugador puede elegir Cara o Sello antes que caiga la moneda
            El juego debe decirle si gana o pierde, gana cuando la moneda coincide con la elección del jugador.

        */

        public static void reto3()
        {
            Random random = new Random();
            int moneda = random.Next(0, 1); // 0 cara 1 sello
            int elecion;

            Console.WriteLine("Digite Su elecion, 1. cara o 2. sello ");
            elecion = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Realizando lanzamiento en 3... 2... 1... ");
            string res = moneda == 0 ? "Cara" : "Sello";
            Console.WriteLine($"La moneda ha caido en {res}");

            if (moneda == elecion)
                Console.WriteLine("Ganaste");
            else
                Console.WriteLine("Perdiste, mejor suerte la proxima");
        }

        /*RETO 4
        De acuerdo a la sintaxis vista, realice lo siguiente:

        Desarrolle un programa en C# que le permita generar la simulación del
        juego piedra, papel o tijera (juego contra la máquina)
        Determine y muestre en pantalla el resultado del juego, si gana alguien o hay empate.

        */
        public static void reto4()
        {
            Random random = new Random();
            int elecionMaquina = random.Next(0, 2);
            string resMaquina =
                elecionMaquina == 0
                    ? "piedra"
                    : elecionMaquina == 1
                        ? "papel"
                        : "tijera";

            Console.WriteLine(
                $"Digite Su elecion, 1. piedra, 2. papel o 3. tijera // {resMaquina}"
            );
            int elecionUsuario = int.Parse(Console.ReadLine()) - 1;
            string resUsuario =
                elecionUsuario == 0
                    ? "piedra"
                    : elecionUsuario == 1
                        ? "papel"
                        : "tijera";

            Console.WriteLine("1, 2, 3... Piedra papel o tijera... ");
            Console.WriteLine($"La maquina ha sacado {resMaquina}");

            if (elecionUsuario == elecionMaquina)
                Console.WriteLine($"usuario: {resUsuario} vs maquina: {resMaquina} ES EMPATE");
            else
                switch (elecionMaquina)
                {
                    case 0: //piedra
                        if (elecionUsuario == 2)
                        {
                            Console.WriteLine($"usuario: {resUsuario} vs maquina: {resMaquina}");
                            Console.WriteLine($"usuario PIERDE, La piedra aplasta la tijera");
                        }
                        else
                        {
                            Console.WriteLine($"usuario: {resUsuario} vs maquina: {resMaquina}");
                            Console.WriteLine($"usuario GANA, El papel envuelve a la piedra");
                        }
                        break;

                    case 1: // papel
                        if (elecionUsuario == 0)
                        {
                            Console.WriteLine($"usuario: {resUsuario} vs maquina: {resMaquina}");
                            Console.WriteLine($"usuario GANA, El papel envuelve a la piedra");
                        }
                        else
                        {
                            Console.WriteLine($"usuario: {resUsuario} vs maquina: {resMaquina}");
                            Console.WriteLine($"usuario PIERDE, El papes es cortado por la tijera");
                        }
                        break;
                    case 2: //tijera
                        if (elecionUsuario == 1)
                        {
                            Console.WriteLine($"usuario: {resUsuario} vs maquina: {resMaquina}");
                            Console.WriteLine($"usuario PIERDE, El papes es cortado por la tijera");
                        }
                        else
                        {
                            Console.WriteLine($"usuario: {resUsuario} vs maquina: {resMaquina}");
                            Console.WriteLine($"usuario PIERDE, La piedra aplasta la tijera");
                        }
                        break;
                }

            Console.WriteLine($"La moneda ha caido en {res}");

            if (moneda == elecion)
                Console.WriteLine("Ganaste");
            else
                Console.WriteLine("Perdiste, mejor suerte la proxima");
        }

        /* RETO 5
        En Supermercados Noé estamos de aniversario y te obsequiamos
        un descuento en el valor de tu compra, si esta es mayor a 50.000
        y dependiendo de tu suerte:

        Si sacas la bolita roja obtienes 10% en el valor de tu compra
        Si sacas la bolita azul obtienes un 30% en el valor de tu compra
        Si sacas la bolita amarilla obtienes un 50% en el valor de tu compra
        Si sacas la bolita blanca te llevas tu compra gratis

        Permítale a un cliente del supermercado Noé saber si su compra
        ha sido beneficiada con su promoción de aniversario,
        indique acorde a la bolita obtenida de forma aleatoria qué valor
        de descuento ha ganado y cual sería su valor final a pagar.

        */

        public static void reto5()
        {
            Console.WriteLine("Digite el valor la compra");
            float totalCompra = float.Parse(Console.ReadLine());

            float porcentajeDescuento = 0;

            Random random = new Random();
            int bola = random.Next(1, 5);

            float totalConDescuento = 0;

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

            Console.WriteLine($"El total que debes pagar de tu compra, es {totalConDescuento} pesos");
        }
    }

    /* RETO 6
    Al ejercicio de Supermercados Noé, agregar

❑ Posibilidad para registrar precio y cantidad de los productos adquiridos
por un cliente (sin importar la cantidad) en lugar de recibir el valor de la
compra.

❑ Implementar un acumulador que calcule el valor a pagar luego de

registrar los productos

❑ Mantenga la comprobación de si es beneficiado con el descuento por su

compra

❑ Mantenga la generación de la bolita aleatoriamente
❑ Mantenga el mensaje al usuario que le dice si obtuvo un descuento y

muestre cual es el valor final a pagar con el descuento aplicado

❑ Capture el valor con el que el cliente paga
❑ Calcule y muestre el cambio.
    */

    /* RETO 7
    Retome los conceptos de acumulador y contador vistos. Aplique las
estructuras algorítmicas vistas al juego del carisellazo:

❑ Definir un valor global para apostar
❑ Repetir el juego las veces que el jugador lo desee.
❑ Posibilidad para apostar una cantidad de dinero específica (ingresada

por el usuario) en cada jugada

❑ Cada vez que el jugador gane debe duplicar el valor apostado y

acumular el valor ganado al valor global.

❑ Cada vez que pierda debe restar al valor apostado del valor global
❑ Al final del juego debe decirle la cantidad de veces que jugó y el

dinero que acumuló.
    */

    /* RETO 8
    ❑ Construya un programa que solicite la cantidad de notas a evaluar
(libre) en un la materia de Programación con C# y el valor de cada
una de dichas notas de 0.0 a 5.0. Calcule el promedio de dichas de
notas para obtener la nota final y agregue las siguientes anotaciones
según corresponda:

✓ Si la nota es menor que 3.0 Reprobaste
✓ Si la nota está entre 3.0 y 4.0 Pasaste Raspando
✓ Si la nota es mayor que 4.0 Aprobaste con buenos resultados
    */

    /* RETO 9
    ❑ En una competencia de natación se desea implementar una

aplicación para almacenar el tiempo por cada competidor.

❑ Los competidores deben registrarse antes de iniciar la competencia

con sus nombres

❑ Al terminar la carrera se deben registrar los tiempos de cada

competidor.

❑ Muestre en pantalla cada nadador con su respectivo tiempo.
❑ Amplíe sus conceptos sobre colecciones en C# y determine de qué
forma podría determinar quien es el ganador (tenga en cuenta que
gana quien recorre en menos tiempo la pisicina)
    */

    /* RETO PLUS / MAQUINA EXPENDEDORA 
    */

}
