using System.Runtime.CompilerServices;

namespace ClassLibrary1
{
    public class Persona
    {
        private long dni;
        private string nombre;
        public Persona (long dni , string nombre)
        {
            this.dni = dni ;
            this.nombre = nombre ;
        }
        public void SetDni(long dni)
        {
            this.dni = dni;
        }
        public long GetDni()
        {
            return this.dni;
        }
        public void SetNombre(string nombre)
        { 
            this.nombre = nombre;
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public String MostrarDatos()
        {
            return $" DNI : {GetDni} Nombre : {GetNombre} ";
        }
    }
}
