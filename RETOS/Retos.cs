using System;

namespace portafolioC_
{
    internal class Retos
    {
        /*
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
            double gFahrenheit, gCentigrados;

            Console.WriteLine("Digite la cantidad de grados Fahrenheit a convertir");
            gFahrenheit = double.Parse(Console.ReadLine());

            gCentigrados = (gFahrenheit - 32) / 1.8;
            Console.WriteLine($"{gFahrenheit} grados Fahrenheit son equivalentes a {gCentigrados} grados Centígrados");
        }


        /*
        El centro de salud Famisalud, aplica vacunas a los bebes menores de un año y la dosis a aplicar 
        depende del peso y la edad del bebé según la siguiente fórmula: 
        dosisvacuna = ((pesobebe ] 10)/(mesesbebe x 10)) * 8 
        Realice un programa en java que le permita a la enfermera, determinar con facilidad la 
        dosis de la vacuna que se debe aplicar a un bebé.        
        */

        public static void reto2()
        {
            double dosisvacuna, pesobebe, mesesbebe;

            Console.WriteLine("Digite el peso del bebe");
            pesobebe = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite la edad del bebe en meses");
            mesesbebe = double.Parse(Console.ReadLine());

            dosisvacuna = ((pesobebe + 10) / (mesesbebe * 10)) * 8;
            Console.WriteLine($"La dosis que se le debe administrar al bebe es  {dosisvacuna}");
        }

        /*
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

        /*
        De acuerdo a la sintaxis vista, realice lo siguiente:

        Desarrolle un programa en C# que le permita generar la simulación del 
        juego piedra, papel o tijera (juego contra la máquina)
        Determine y muestre en pantalla el resultado del juego, si gana alguien o hay empate.

        */
        public static void reto4()
        {
            Random random = new Random();
            int elecionMaquina = random.Next(0, 2);
            string resMaquina = elecionMaquina == 0 ? "piedra" : elecionMaquina == 1 ? "papel" : "tijera";

            Console.WriteLine($"Digite Su elecion, 1. piedra, 2. papel o 3. tijera // {resMaquina}");
            int elecionUsuario = int.Parse(Console.ReadLine()) - 1;
            string resUsuario = elecionUsuario == 0 ? "piedra" : elecionUsuario == 1 ? "papel" : "tijera";

            Console.WriteLine("1, 2, 3... Piedra papel o tijera... ");
            Console.WriteLine($"La maquina ha sacado {resMaquina}");


            if (elecionUsuario == elecionMaquina)
                Console.WriteLine($"usuario: {resUsuario} vs maquina: {resMaquina} ES EMPATE");
            else
                switch (elecionMaquina)
                {
                    case 0://piedra 
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

        
    }
}