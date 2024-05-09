using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJercio_Deporte
{
    public class jugador : Persona
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }
        public jugador(int dni, string nombre): this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public jugador (int dni, string nombre, int totalGoles, int totalPartidos)
           : this(dni, nombre) //llamo al ctor publico que recibe dos parametros
        {
            this.partidosJugados = totalPartidos;
            this.totalGoles = totalGoles;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetNombre(string nombre)
        { 
            return this.nombre; 
        }
        public void SetDni(int dni)
        {
            this.dni = dni;
        }
        public int GetDni(int dni)
        {
            return this.dni;
        }
        public int GetPartidosJugados(int partidosJugados)
        {
            return partidosJugados;
        }
        public float GetPromedioGoles(float promediogoles)
        {
            return (float)this.totalGoles / this.partidosJugados;
        }
        public int GetTotalGoles(int totalGoles)
        {
            return this.totalGoles;
        }
         public string MostrarDatos()
        {
            StringBuilder sb = new();
            sb.AppendLine("--FICHA JUGADOR--");
            sb.AppendLine($"Nombre : {this.nombre}");
            sb.AppendLine($"DNI : {this.dni}");
            sb.AppendLine($"Partidos Jugados : {this.partidosJugados}");
            sb.AppendLine($"Total Goles : {this.totalGoles}");
            sb.AppendLine($"Promedio Goles : {GetPromedioGoles(this.promedioGoles)}");
            return sb.ToString();
        }
        public static bool operator ==(jugador j1,jugador j2)
        {
            return j1.dni == j2.dni;
        }
        public static bool operator !=(jugador j1, jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
