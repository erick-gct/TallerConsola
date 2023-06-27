using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerConsola.Models;

namespace TallerConsola
{
     class Program
    {

        static void Main(string[] args)
        {
            //agregarCliente();
           consultarCliente();
            //consultarCliente();
            //modificarCliente();
           // eliminarCliente();
            consultarClientesFunciones();
        }

        public static void agregarCliente()
        {
            Console.Write("Método agregar cliente");
            ClienteContext context = new ClienteContext();
            Cliente cl = new Cliente();
            cl.nombre = "San Luis";
            cl.apellido = "Ballena";
            cl.telefono = 0939341245;
            cl.fecha_nacimiento = (DateTime.ParseExact("2000-04-30 10:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)); ;
            cl.direccion = "Samanes 8 Mz 305 V 25";
            cl.estado = true;
            Cliente cl2 = new Cliente();
            cl2.nombre = "Marcelo";
            cl2.apellido = "Ronaldo";
            cl2.telefono = 0939561245;
            cl2.fecha_nacimiento = (DateTime.ParseExact("2000-04-22 10:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)); ;
            cl2.direccion = "Samanes 6 Mz 305 V 25";
            cl2.estado = true;
            Cliente cl3 = new Cliente();
            cl3.nombre = "Tilin";
            cl3.apellido = "Potaxio";
            cl3.telefono = 0931341245;
            cl3.fecha_nacimiento = (DateTime.ParseExact("2000-04-26 10:30:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)); ;
            cl3.direccion = "Samanes 2 Mz 305 V 25";
            cl3.estado = true;


            context.Cliente.Add(cl);
            context.Cliente.Add(cl2);
            context.Cliente.Add(cl3);

            context.SaveChanges();

            Console.WriteLine("Código Cliente: " + cl.Id + " Nombre:" + cl.nombre);
        }

        public static void consultarCliente()
        {
            Console.WriteLine("Metodo consultar Cliente");
            ClienteContext context = new ClienteContext();
            List<Cliente> listClientes = context.Cliente.ToList();

            foreach (var item in listClientes)
            {
                Console.WriteLine("Codigo Cliente: " + item.Id+ " Nombre: " + item.nombre);
            }

        }

        public static void consultarClientes()
        {
            Console.WriteLine("Metodo consultar cliente por Id");
            ClienteContext context = new ClienteContext();
            Cliente cl = new Cliente();
            cl = context.Cliente.Find(1);

            Console.WriteLine("Codigo: " + cl.Id+ " Nombre: " + cl.nombre);

        }

        public static void modificarCliente()
        {
            Console.WriteLine("Metodo modificar Cliente");
            ClienteContext context = new ClienteContext();
            Cliente cl = new Cliente();
            cl = context.Cliente.Find(1);

            cl.nombre= "Gabriel";
            context.SaveChanges();
            Console.WriteLine("Codigo del Cliente: " + cl.Id + " Nombresito: " + cl.nombre);

        }

        public static void eliminarCliente()
        {
            Console.WriteLine("Metodo eliminar Cliente");
            ClienteContext context = new ClienteContext();
            Cliente cl = new Cliente();
            cl = context.Cliente.Find(5);
            context.Remove(cl);
            context.SaveChanges();
            Console.WriteLine("Codigo: " + cl.Id + " Nombre: " + cl.nombre);

        }

        public static void consultarClientesFunciones()
        {
            Console.WriteLine("Metodo consultar clientes con el uso de funciones");
            ClienteContext context = new ClienteContext();
            List<Cliente> listClientes;

            Console.WriteLine("Cantidad de registros: " + context.Cliente.Count());
            Cliente cl = context.Cliente.First();

            Console.WriteLine("Primer elemento de la tabla:" + cl.Id + "-" + cl.nombre);

           

            listClientes = context.Cliente.Where(s => s.nombre.StartsWith("G")).ToList();

          


            foreach (var item in listClientes)
            {
                Console.WriteLine("Codigo: " + item.Id + " Nombre: " + item.nombre);
            }


        }


    }
}
