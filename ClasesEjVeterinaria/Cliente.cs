using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEjVeterinaria
{
    public class Cliente
    {
        private string domicilio;
        private string nombre;
        private string apellido;
        private string telefono;
        private int cantidadMascotas;
        private Mascota[] mascotas;
        
        public Cliente(string domicilio, string nombre, string apellido, string telefono, int cantidadMascotas) 
        {
            this.domicilio = domicilio;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.cantidadMascotas = cantidadMascotas;
            mascotas = new Mascota[cantidadMascotas];
        }
        public void SetDomicilio(string domicilio)
        {
            this.domicilio = domicilio;
        }
        public string GetDomicilio()
        {
            return this.domicilio;
        }
        public void SetNombre(string nuevoNombre)
        {
            this.nombre = $"{this.domicilio} {nuevoNombre}";
        }
        public string GetNombre() 
        { 
            return this.nombre; 
        }
        public void SetApellido(string nuevoAppelido)
        {
            this.apellido = nuevoAppelido;
        }
        public string GetApellido()
        {
            return this.apellido; 
        }
        public void SetTelefono(string nuevoTelefono)
        {
            this.telefono = nuevoTelefono;
        }
        public string GetTelefono()
        {
            return this.telefono;
        }
        public void SetCantidadMascotas(int nuevaCantidadMascotas)
        {
            this.cantidadMascotas = nuevaCantidadMascotas;
        }
        public int GetCantidadMascotas()
        {
            return this.cantidadMascotas;
        }
        
        public void AgregarMascota(Mascota mascota)
        {
            for (int i = 0; i < mascotas.Length; i++)
            {
                if (mascotas[i] == null)
                {
                    mascotas[i] = mascota;
                    break; 
                }
            }
        }
        public Mascota[] ArmadorMascotas()
        {
            return mascotas;
        }
        public string FichaCliente()
        {
            StringBuilder sb = new();
            sb.AppendLine("--FICHA CLIENTE--");
            sb.AppendLine($"Domicilio : {this.domicilio}");
            sb.AppendLine($"Nombre : {this.nombre}");
            sb.AppendLine($"Apellido : {this.apellido}");
            sb.AppendLine($"Telefono : {this.telefono}");
            sb.AppendLine($"Cantidad Mascota/s : {this.cantidadMascotas}");
            foreach (Mascota mascota in mascotas)
            {
                if (mascota != null)
                {
                 sb.AppendLine($"Nombre Mascota : {mascota.GetNombre()}");
                }
            }
            return sb.ToString();
        }
    }
}

