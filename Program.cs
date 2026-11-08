using System;
using System.Security.Cryptography;

namespace Sistema_Empleados
{
    internal class Program
    {
        static void Main(string[]args)
        {
            //creacion de objetos
            Empleado empleado = new Empleado("Amilcar", 6767, 34567);

            Empleado empleado1 = new Empleado();

            Programador programador = new Programador("karina", 87, 4567, "Python");
            //hasta aqui terminamos los 3 objetos de las clases. 
            //Dos de empleado, uno con parametros y el otro sin parametros.


            //Aqui estamos usando los metodos para mostrar la informacion de las clases.
            Console.WriteLine("==== Primer Empleado ====");
            empleado.MostrarInformacion();

            Console.WriteLine("==== Segundo Empleado ====");
            empleado1.MostrarInformacion();

            Console.WriteLine($"Salario anual del empleado: ${empleado.CalcularSalarioAnual():F2}");

            Console.WriteLine("==== Tercer Empleado ====");
            programador.MostrarInformacion();

            programador.MostrarLenguaje();

        }
    }
}