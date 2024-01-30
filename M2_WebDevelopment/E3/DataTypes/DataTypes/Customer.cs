using System;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataTypes
{
    //Crear una colección genérica de la clase Customer. 
    public class Customer
    {
        public string Name { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Customer> customers = new List<Customer>();

            //Llenarla con 10 datos de prueba
            customers.Add(new Customer { Name = "Michelle", RegistrationDate = DateTime.Now });
            customers.Add(new Customer { Name = "David", RegistrationDate = DateTime.Now });
            customers.Add(new Customer { Name = "Juan", RegistrationDate = DateTime.Now });
            customers.Add(new Customer { Name = "Dulce", RegistrationDate = DateTime.Now });
            customers.Add(new Customer { Name = "Melania", RegistrationDate = DateTime.Now });
            customers.Add(new Customer { Name = "Daniel", RegistrationDate = DateTime.Now });
            customers.Add(new Customer { Name = "Miguel", RegistrationDate = DateTime.Now });
            customers.Add(new Customer { Name = "Mario", RegistrationDate = DateTime.Now });
            customers.Add(new Customer { Name = "Esther", RegistrationDate = DateTime.Now });
            customers.Add(new Customer { Name = "Daniela", RegistrationDate = DateTime.Now });

            //Recorrerla e imprimir en pantalla el nombre del cliente y su fecha de registro con el bucle foreach.
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Bucle FOREACH\n");
                Console.WriteLine("Nombre: " + customer.Name + ", Fecha de registro: " + customer.RegistrationDate);
                Console.WriteLine("\n");
            }

            //Recorrerla e imprimir en pantalla el nombre del cliente y su fecha de registro con el bucle for. 
            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine("Bucle FOR \n");
                Console.WriteLine("Nombre: " + customers[i].Name + ", Fecha de registro: " + customers[i].RegistrationDate);
                Console.WriteLine("\n");
            }

            //Recorrerla e imprimir en pantalla el nombre del cliente y su fecha de registro con el bucle while.
            int c = 0;
            while (c < customers.Count)
            {
                Console.WriteLine("Bucle WHILE");
                Console.WriteLine("Nombre: " + customers[c].Name + ", Fecha de registro: " + customers[c].RegistrationDate);
                c++;
                Console.WriteLine("\n");
            }

            //Recorrerla e imprimir en pantalla el nombre del cliente y su fecha de registro con el bucle do while.
            int x = 0;
            do
            {
                Console.WriteLine("Bucle DO WHILE\n");
                Console.WriteLine("Nombre: " + customers[x].Name + ", Fecha de registro: " + customers[x].RegistrationDate);
                x++;
            } while (x < customers.Count);

            Console.ReadKey();
        }
    }
}
