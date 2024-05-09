using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEjVeterinaria
{
    public class Mascota
    {
        private string especie;
        private string nombre;
        private string fechaNacimiento;
        private int cantidadVacunas;
        private Vacuna[] vacuna;
        public Mascota(string especie, string nombre, string fechaNacimiento,int cantidadVacunas)
        { 
            this.especie = especie;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.cantidadVacunas = cantidadVacunas;
            vacuna = new Vacuna[cantidadVacunas];
        }
        public void Setespecie(string nuevoEspecie)
        {
            this.especie = nuevoEspecie;
        }
        public string GetEspecie()
        { 
            return this.especie; 
        }
        public void Setnombre(string nuevoNombre)
        {
            this.nombre = nuevoNombre;
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public void SetFechaNacimiento(string nuevaFechaNacimiento)
        {
            this.fechaNacimiento = nuevaFechaNacimiento;
        }
        public string GetFechaNacimiento()
        {
            return this.fechaNacimiento;
        }
        public void SetCantidadVacunas(int nuevaCantidadVacunas)
        {
            this.cantidadVacunas = nuevaCantidadVacunas;
        }
        public int GetCantidadVacunas()
        {
            return this.cantidadVacunas;
        }

        public void AgregarVacuna(Vacuna nuevaVacuna)
        {
            for (int i = 0; i < vacuna.Length; i++)
            {
                if (vacuna[i] == null)
                {
                    vacuna[i] = nuevaVacuna;
                    break;
                }
            }
        }
        public Vacuna[] ArmadorVacunas()
        {
            return vacuna;
        }
        public string FichaMascota()
        {
            StringBuilder sb = new();
            sb.AppendLine("--FICHA MASCOTA--");
            sb.AppendLine($"Especie: {this.especie}");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Fecha de Nacimiento: {this.fechaNacimiento}");
            sb.AppendLine($"Cantidad de Vacunas: {this.cantidadVacunas}");
            foreach (Vacuna vacuna in vacuna)
            {
                if (vacuna != null)
                {
                    sb.AppendLine($"Nombre Vacuna : {vacuna.GetNombre()}");
                }
            }
            return sb.ToString();
        }
    }
}
