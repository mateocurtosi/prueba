using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJercio_Deporte
{
    public class Equipo
    {
        short cantidadDeJugadores;
        List<jugador> jugadores;
        string nombre;

        private Equipo()
        {
            this.jugadores = new List<jugador>();
        }
        public Equipo(short cantidadDeJugadores, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;
        }
        public static bool operator +(Equipo e, jugador j)
        {

            if (e.jugadores.Count < e.cantidadDeJugadores)
            {
                foreach (jugador item in e.jugadores)
                {
                    //utilizo sobrecarga de == de la clase Jugador
                    if (item == j)
                        return false;
                }
                e.jugadores.Add(j);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
