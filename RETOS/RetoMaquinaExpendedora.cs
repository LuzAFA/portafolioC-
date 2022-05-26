namespace portafolioC_
{
    internal class RetoMaquinaExpendedora
    {
        public static void RetoMaquinaExpendedora()
        {
            Console.WriteLine("Cuantas personas van a competir?");
            int cantidadCompetidores = int.Parse(Console.ReadLine());
            String[] nombres = new String[cantidadCompetidores];
            float[] tiempos = new float[cantidadCompetidores];
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($" Digite el nombre del competidor {i} ");
                nombres[i] = Console.ReadLine();
            }

            for (int i = 0; i < tiempos.Length; i++)
            {
                Console.WriteLine($" Digite el tiempo del competidor {i} ");
                tiempos[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("");
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($" Competidor {nombres[i]} con tiempo {tiempos[i]} ");
            }
            int PosicionGanador = 0;
            for (int i = 0; i < tiempos.Length - 1; i++)
            {
                if (tiempos[i] < tiempos[i + 1])
                {
                    PosicionGanador = i;
                }
                else
                {
                    PosicionGanador = i + 1;
                }
            }
            Console.WriteLine($" ..... EL GANADOR ES {nombres[PosicionGanador]} .....  ");
        }
    }
}
