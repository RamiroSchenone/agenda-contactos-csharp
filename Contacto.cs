using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class Contacto : IComparable<Contacto>
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public Contacto()
        {
             
        }

        public Contacto(string nombre, string telefono, string email)
        {
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) { 
                return false;
            }

            Contacto other = obj as Contacto;

            if (other == null)
            {
                return false;
            }

            return string.Equals(Nombre, other.Nombre) && string.Equals(Telefono, other.Telefono);
        }

        public override int GetHashCode()
        {
            unchecked 
            { 
                int hashNombre = (Nombre == null ? 0 : Nombre.GetHashCode());
                int hashTelefono = (Telefono == null ? 0 : Telefono.GetHashCode());
                return (hashNombre * 397) ^ hashTelefono;
            }
        }

        public override string ToString()
        {
            return string.Format("Nombre: {0}\nTeléfono: {1}\nEmail: {2}\n", Nombre, Telefono, Email);
        }

        public int CompareTo(Contacto other)
        {
            return Nombre.CompareTo(other.Nombre);
        }
    }

}
