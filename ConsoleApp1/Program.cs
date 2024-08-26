using Sesion2.Modelos;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante est = new Estudiante();
            String nombre, carrera;
            int nota;

            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Carrera: ");
            carrera = Console.ReadLine();
            Console.Write("Nota: ");
            nota = int.Parse(Console.ReadLine());


            est.Nombre = nombre;
            est.Carrera = carrera;
            est.Nota = nota;

            Console.WriteLine(est.ToString());

        }
    }
}
