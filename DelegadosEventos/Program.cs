using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosEventos
{
    class Program
    {
        void Accion1(int num1, int num2, int num3, int num4) { }

        static string Funcion1()
        {
            return "Hola";
        }

        static string Funcion1(string dato1, int dato2, bool dato3)
        {
            return "Hola";
        }


        static void Main(string[] args)
        {
            //List<int> numeros = new List<int>
            //{
            //    40,
            //    50,
            //    70,
            //    80,
            //    125,
            //    25

            //};

            // EJEMPLOS DEL USO DE LOS DELEGADOS "ACTION"  y "FUNC" aplicados a metodos del sistema

            // Media de todos los numeros
            //var promedio = numeros.Average(x => x);

            //// El numero mas pequeño de todos los numeros

            //var minimo = numeros.Min(x => x);

            //// El numero maximo entre todos estos numeros

            //var maximo = numeros.Max(x => x);

            //// Cuenta la cantidad de numeros que se enecuentran entre 50 y 100

            //var cuenta = numeros.Count(x => x > 50 && x < 100);

            //// Se estan sumando los numeros pares

            //var suma = numeros.Sum(x => x % 2 == 0 ? x : 0);



            //Console.WriteLine("Teniendo en cuenta la lista de numeros anterior " + " este sera el promedio " +  promedio
            //    + " este sera el maximo " + maximo + " este sera el minimo " + minimo);

            //Console.ReadLine();


            //SistemaLuces luces = new SistemaLuces();

            //// Los predicados Action los utilizaremos en el caso de que no queramos devolver ningun valor

            //Action action = new Action(luces.ApagarLuces);

            //Action<int, int, int, int> action2
            //    = new Action<int, int, int, int>(Accion1);

            //// Puede recibir o no parametros pero siempre tendra que recibir un valor
            //Func<string> funcion = new Func<string>(Funcion1);

            //Func<string, int, bool> funcion2 = new Func <string, int, bool>(Funcion1);


            ////CentralHub hub = new CentralHub();


            ////SistemaLuces luces = new SistemaLuces();

            ////SistemaAlarmas alarmas = new SistemaAlarmas();

            ////SistemaElectrodomesticos electrodomesticos = new SistemaElectrodomesticos();

            ////hub.Add(luces.ApagarLuces);
            ////hub.Add(alarmas.EncenderAlarmas);
            ////hub.Add(electrodomesticos.ApagarElectrodomesticos);




            //////hub.IniciarProtocoloCierre();

            //////Console.ReadLine();

            ////List<string> nombres = new List<string>
            ////{
            ////    "Hector", 
            ////    "Santiago",
            ////    "Ricardo"
            ////};

            //// El tipo de delegado "Predicate" nos hace de nexo entre el metodo estatico "Contiene" y el metodo Find que utilizara lo que le arroje el predicado.

            //Predicate solo devolvera un booleano y recibe algun tipo de generico

            //Predicate<string> predicado = new Predicate<string>(Contiene);

            //var resultado = nombres.Find(predicado);
            //var exista = nombres.Exists(x => x.StartsWith("S"));

        }

        // Este metodo es un "METODO ADAPTADOR" un metodo que convierte o adapta un metodo para darle una 
        // firma diferente


        static void ApagarLuces() 
        {
            SistemaLuces luces = new SistemaLuces();
            luces.ApagarLuces(5);
        }
     

        static bool Contiene(string nombre) 
        {
            return nombre.Contains("H");
        }
    }
}
