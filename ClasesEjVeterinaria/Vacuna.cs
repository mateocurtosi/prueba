using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEjVeterinaria
{
    public class Vacuna
    {
        private string nombre;

        public Vacuna(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetNombre(string nuevoNombre)
        {
            this.nombre = nuevoNombre;
        }
        public string GetNombre()
        {
            return this.nombre;
        }
    }
}
