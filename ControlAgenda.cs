using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class ControlAgenda
    {
        private Agenda _agenda;

        public ControlAgenda(Agenda agenda)
        {
            _agenda = agenda;
        }

        public void VerContactos()
        {
            Limpiar();
            MenuMostrar();

#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            string opcion = Console.ReadLine();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Contactos en orden ascendente");
                    _agenda.MostrarOrdenados();
                    break;
                case "2":
                    Console.WriteLine("Contactos en orden descendente");
                    _agenda.MostrarOrdenadosDesc();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;

            }

            PresionaParaContinuar();
        }

        public void AgregarContacto()
        {
            Limpiar();
            Console.WriteLine("Nuevo Contacto");
            Contacto contacto = new Contacto();

            Console.Write("Nombre: ");
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
            contacto.Nombre = Console.ReadLine().Trim();
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.

            Console.Write("Teléfono: ");
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
            contacto.Telefono = Console.ReadLine().Trim();
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.

            Console.Write("Email: ");
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
            contacto.Email = Console.ReadLine().Trim();
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.

            _agenda.AgregarContacto(contacto);

            Console.WriteLine("Contacto agregado correctamente");
            PresionaParaContinuar();
        }

        public void BorrarUltimoContacto()
        {
            Limpiar();
            _agenda.BorrarUltimoContacto();
            Console.WriteLine("Contacto borrado exitosamente.");
            PresionaParaContinuar();
        }

        public void BuscarPorNombre()
        {
            Limpiar();
            Console.WriteLine("Buscar Contacto");
            Console.Write("Nombre: ");
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            string nombre = Console.ReadLine();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL

#pragma warning disable CS8604 // Posible argumento de referencia nulo
            Contacto contacto = _agenda.BuscarPorNombre(nombre);
#pragma warning restore CS8604 // Posible argumento de referencia nulo

            if (contacto != null)
            {
                Console.WriteLine("Datos: \n" + contacto);
            }
            else
            { 
                Console.WriteLine("Contacto no encontrado");
            }

            PresionaParaContinuar();
        }

        public static void AcercaDe() 
        {
            Limpiar();
            Console.WriteLine("Nombre: Ramiro Schenone");
            PresionaParaContinuar();
        }

        public void MenuMostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. Mostrar orden ascendente");
            sb.AppendLine("2. Mostrar orden descendente");
            sb.AppendLine("3. Volver al menu principal");
            sb.AppendLine("Seleccione una opcion: ");

            Console.WriteLine(sb.ToString());
        }

        private static void PresionaParaContinuar()
        { 
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
        private static void Limpiar()
        {
            Console.Clear();
        }
    }
}
