using System.Security.Cryptography.X509Certificates;

namespace Tp_MUNDIAL_2026
{
    internal class Program
    {
        public struct Jugador
        {
            //propiedades
            public string J { get; set; }
            public string A { get; set; }
            public double G { get; set; }
            public double DA { get; set; }
            public int N { get; set; }
            public string POS { get; set; }
            public string EQ { get; set; }


            //Constructor
            public Jugador(string jugador, string apellido, double goles, double disparos, int dorsal, string posicion, string equipo)
            {
                J = jugador;
                A = apellido;
                G = goles;
                DA = disparos;
                N = dorsal;
                POS = posicion;
                EQ = equipo;
            }
            //Metodo
            public double PromedioGol()
            {
                double PromedioGol = (G / DA) * 100;

                return PromedioGol;

            }
        }
        static void Main(string[] args)
        {


            Jugador[] Goleadores = new Jugador[]
            {
                new Jugador("Lionel ", "Messi", 10, 18, 10, "Wing Derecho", "Argentina"),
                new Jugador("Kylian ", "Mbappé", 8, 21, 10, "Striker", "Francia"),
                new Jugador("Harry ", "Kane", 6, 13, 9, "Striker", "Inglaterra"),
                new Jugador("Jude ", "Bellingham", 6, 16, 10, "Media punta", "Inglaterra"),
                new Jugador("Michael ", "Olise", 1, 5, 11, "Mediapunta", "Francia"),
                new Jugador("Enzo ", "Fernandez", 2, 4, 24, "Volante central", "Argentina"),
                new Jugador("Julian ", "Alvarez", 9, 30, 9, "Striker", "Argentina"),
                new Jugador("Lisandro ", "Martinez", 2, 5, 6, "Central", "Argentina"),
                new Jugador("Cristiano ", "Ronaldo", 2, 6, 7, "Striker", "Portugal"),
                new Jugador("Lamine ", "Yamal", 1, 4, 10, "Wing Derecho", "España"),
                new Jugador("Ousmane ", "Dembele", 5, 8, 7, "Wing Izquierdo", "Francia"),
                new Jugador("Mikel ", "Oyarzabal", 5, 11, 21, "Striker", "España"),
            };
            Console.WriteLine("Lista de goleadores:\n");
            foreach (Jugador jugadores in Goleadores)
            {
                Console.WriteLine(jugadores.J + jugadores.A + "\n\nGoles = " + jugadores.G + "\nDisparos al arco = " + jugadores.DA + "\nDorsal = " + jugadores.N + "\nPosicion = " + jugadores.POS + "\nSelección = " + jugadores.EQ + "\n");
            }
            Jugador jugador = PromedioDeGol(Goleadores);
            Console.WriteLine("El jugador con mayor promedio de gol es: " + jugador.J + jugador.A + " teniendo " + jugador.PromedioGol() + "% de efectividad frente a los tres palos.");
        }
        public static Jugador PromedioDeGol(Jugador[] jugadores)
        {
            Jugador Stricker = jugadores[0];
            Jugador JugadorAct = new Jugador();
            for (int j = 0; j < jugadores.Length; j++)
            {
                JugadorAct = jugadores[j];
                
                if (j > 0)
                {
                    if (JugadorAct.PromedioGol() > Stricker.PromedioGol())
                    {
                        Stricker = JugadorAct;
                    }
                }
            }
            return Stricker;
        }
    }
}
