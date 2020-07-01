using aplicacion.Clases;
using System;
using System.Collections.Generic;

namespace aplicacion
{
    class Program
    {
        static List<AutoMovil> automoviles = new List<AutoMovil>(); //creacion instancia para la arraylist

        static void Main(string[] args)  //Main
        {
            login();
            desplegarMenu();

        }

        private static void desplegarMenu() { //menu de opciones 

            bool salir = false;
            while (!salir) {  // mientras la opcion no sea salir ejecutara lo siguiente
                Console.WriteLine("\n");
                Console.WriteLine("Elija una opción : ");
                Console.WriteLine("1.- Agregar vehiculo ");
                Console.WriteLine("2.- Ver lista de vehiculos ");
                Console.WriteLine("3.- Finalizar ");

                string opcion = Console.ReadLine();

                switch (opcion) {
                    case "1":
                        agregarVehiculo();
                        break;
                    case "2":
                        listarVehiculos();
                        break;
                    case "3":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("\n");
                        Console.WriteLine("Error, no existe la opción ingresada.");
                        break;
                }
            }
        }

        private static void agregarVehiculo() {  //metodo para agregar vehiculos y sus datos
            AutoMovil automovil = new AutoMovil();
            Console.WriteLine("\n");
            Console.WriteLine("Ingrese un automovil.");
            Console.WriteLine("Ingrese año.");
            automovil.año = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese marca.");
            automovil.marca = Console.ReadLine();

            Console.WriteLine("Ingrese kilometraje.");
            automovil.kilometraje = Int32.Parse(Console.ReadLine());

            automovil.estanque = new Estanque();
            Console.WriteLine("Ingrese capacidad estanque.");
            automovil.estanque.capacidad = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese litros en el estanque.");
            automovil.estanque.litros = Int32.Parse(Console.ReadLine());

            automovil.mezclador = new Mezclador();
            Console.WriteLine("Ingrese tipo mezclador (carburador o inyector).");
            automovil.mezclador.tipo = Console.ReadLine();

            automovil.motor = new Motor();
            Console.WriteLine("Ingrese id del motor.");
            automovil.motor.id = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese tipo del motor (dos_tiempos o cuatro_tiempos.");
            automovil.motor.tipo = Console.ReadLine();

            Console.WriteLine("Ingrese cilindrada del motor.");
            automovil.motor.cilindrada = Int32.Parse(Console.ReadLine());

            automoviles.Add(automovil);
        }

        private static void listarVehiculos() {  //arreglo lista de vehiculos
            Console.WriteLine("\n");
            Console.WriteLine("Mostrar lista de vehiculos.");

           foreach(AutoMovil automovil in automoviles) {
                Console.WriteLine("Año: "+ automovil.año);
                Console.WriteLine("Marca: " + automovil.marca);
                Console.WriteLine("kilometraje: " + automovil.kilometraje);
                Console.WriteLine("Capacidad de estante: " + automovil.estanque.capacidad);
                Console.WriteLine("Litros en el estanque: " + automovil.estanque.litros);
                Console.WriteLine("Tipo de mezclador: " + automovil.mezclador.tipo);
                Console.WriteLine("Id del motor: " + automovil.motor.id);
                Console.WriteLine("Tipo de motor: " + automovil.motor.tipo);
                Console.WriteLine("Cilindrada del motor: " + automovil.motor.cilindrada);
                Console.WriteLine("\n");

            }
        }

        private static void login() // logica para el metodo login
        {
            bool isLoggedIn = false;
            while (!isLoggedIn) {  //mientras (!) no este logueado
                string userName = null;
                Console.WriteLine("Ingrese nombre de usuario : ");
                userName = Console.ReadLine();

                string passWord = null;
                Console.WriteLine("Ingrese su contraseña : ");
                passWord = Console.ReadLine();

                if (userName == "admin" && passWord == "abc123") {
                    isLoggedIn = true;
                    Console.WriteLine("\n");
                    Console.WriteLine("Ingreso Exitoso");
                    Console.WriteLine("\n");
                } else {
                    Console.WriteLine("usuario o contraseña incorrectos");
                }
            }
        }
    }
}
