using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion2.Modelos
{
    internal class Estudiante
    {

        public Estudiante() { }

        public string Nombre { get; set; }

        public string Carrera { get; set; }

        public int Nota { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Nombre} \nCarrera: {Carrera} \nNota: {Nota} \nCualitativo: {EvaluarNota()}";
        }

        public string EvaluarNota()
        {
            if (Nota >= 70 && Nota <= 89)
            {
                return "Aprobado";
            }
            else if (Nota >= 90 && Nota <= 100)
            {
                return "Felicidades, sos castroso";
            }
            else if (Nota >= 0 && Nota <= 69) 
            {
                return "Reprobado";
            }
            return "Nota no valida";
        }

    }
}
