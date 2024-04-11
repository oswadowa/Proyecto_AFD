using System;

namespace PRUEBACONSOLA_AUTOMATA4
{
    public class Automata
    {
        private enum Estado { q0, q1, q2, q3 }
        private Estado estadoActual;

        public Automata()
        {
            estadoActual = Estado.q0;
        }

        public bool EsValida(string cadena)
        {
            foreach (char simbolo in cadena)
            {
                estadoActual = Transicion(estadoActual, simbolo);
                if (estadoActual == Estado.q0)
                {
                    return false;
                }
            }

            return estadoActual == Estado.q3;
        }

        public string ObtenerRecorrido(string cadena)
        {
            string recorrido = "";
            Estado estadoTemporal = estadoActual; // Guardamos el estado actual en una variable temporal

            foreach (char simbolo in cadena)
            {
                recorrido += $"{estadoTemporal} , {simbolo} , ";
                estadoTemporal = Transicion(estadoTemporal, simbolo);
                recorrido += $"{estadoTemporal}\n";
            }

            return recorrido;
        }

        private Estado Transicion(Estado estadoActual, char simbolo)
        {
            switch (estadoActual)
            {
                case Estado.q0:
                    return simbolo == 'a' ? Estado.q2 : Estado.q1;
                case Estado.q1:
                    return simbolo == 'a' ? Estado.q1 : Estado.q3;
                case Estado.q2:
                    return simbolo == 'a' ? Estado.q3 : Estado.q2;
                case Estado.q3:
                    return simbolo == 'c' ? Estado.q0 : Estado.q3;
                default:
                    throw new Exception("Estado no válido");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Automata automata = new Automata();

            Console.WriteLine("Ingrese una cadena:");
            string cadena = Console.ReadLine();

            Automata automataCopia = new Automata(); // Creamos una copia del autómata

            if (automataCopia.EsValida(cadena))
            {
                Console.WriteLine("La cadena es válida");
                Console.WriteLine("Recorrido:");
                Console.WriteLine(automata.ObtenerRecorrido(cadena)); // Utilizamos la copia para obtener el recorrido
            }
            else
            {
                Console.WriteLine("La cadena no es válida");
            }

            Console.ReadKey();
        }
    }
}

