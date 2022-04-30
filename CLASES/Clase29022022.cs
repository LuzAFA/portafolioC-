using System;

namespace portafolioC_
{
    internal class Clase29042022
    {
        public static void presupuesto()
        {
            int presupuesto = 100000, limite = 3, gasto, total = 0;
            String debeContinuar = "";

            do
            {
                Ingresargasto:
                Console.WriteLine("Digite el valor del gasto ");
                gasto = int.Parse(Console.ReadLine());

                if (gasto > presupuesto)
                {

                        Console.WriteLine("Ya no puede registar mas gastos");


                    presupuesto -= gasto;
                    total += gasto;
                    limite--;
                    Console.WriteLine($" Su gasto fue: {gasto} y le quedan {presupuesto}");
                    if (limite == 0)
                    {
                        Console.WriteLine("Ya no puede registar mas gastos");
                        debeContinuar = "nop";
                    }
                    else
                    {
                        Console.WriteLine("Desea registrar otro gasto? Si o No ");
                        debeContinuar = (Console.ReadLine()).ToUpper();
                    }
                }
            } while (debeContinuar == "SI");

            Console.WriteLine($"El gasto total es de {total} y le quedo {presupuesto}");


        }
    }
}
