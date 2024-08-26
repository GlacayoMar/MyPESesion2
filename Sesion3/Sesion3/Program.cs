using Sesion3.Modelos;

namespace Sesion3
{
    internal class Program
    {
        //Calcular la edad de una persona y decir si es mayor o menor
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            string nombre;
            DateTime fechanac;

            Console.WriteLine("Digite su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Digite su fecha de nacimiento: ");
            fechanac = DateTime.Parse(Console.ReadLine());

            persona.Nombre = nombre;
            persona.FechaNac = fechanac;

            Console.WriteLine(persona.EvaluarEdad());

        }
    }
}
