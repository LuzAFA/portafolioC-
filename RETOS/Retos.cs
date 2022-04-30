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
            
            gCentigrados = (gFahrenheit - 32)/1.8;
            Console.WriteLine($"{gFahrenheit} grados Fahrenheit son equivalentes a {gCentigrados} grados Centígrados");
        }


        /*
        dosis = (()/()) *8 
        */
        public static void reto2()
        {
             double gFahrenheit, gCentigrados;

            Console.WriteLine("Digite la cantidad de grados Fahrenheit a convertir");
            gFahrenheit = double.Parse(Console.ReadLine());
            
            gCentigrados = (gFahrenheit - 32)/1.8;
            Console.WriteLine($"{gFahrenheit} grados Fahrenheit son equivalentes a {gCentigrados} grados Centígrados");
        }

        
    }
}