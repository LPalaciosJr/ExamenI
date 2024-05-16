using Examen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Clases
{
    public class Asignatura : Alumno, IAsignatura
    {
        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }
        public string NombreAsignatura { get; private set; }
        public string Horario { get; private set; }
        public string NombreDocente { get; private set; }

        public void SetDatosAsignatura(string nombreAsignatura, string horario, string nombreDocente)
        {
            NombreAsignatura = nombreAsignatura;
            Horario = horario;
            NombreDocente = nombreDocente;
        }

        public double CalcularNotaFinal()
        {
            return N1 + N2 + N3;
        }

        public double CalcularNotaFinal(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        public string MensajeNotaFinal(double notaFinal)
        {
            if (notaFinal >= 0 && notaFinal <= 59)
                return "Reprobado";
            else if (notaFinal >= 60 && notaFinal <= 79)
                return "Bueno";
            else if (notaFinal >= 80 && notaFinal <= 89)
                return "Muy Bueno";
            else if (notaFinal >= 90 && notaFinal <= 100)
                return "Sobresaliente";
            else
                return "Nota inválida";
        }

        public void Imprimir()
        {
            double notaFinal = CalcularNotaFinal();
            double notaFinalConParametros = CalcularNotaFinal(N1, N2, N3);

            Console.WriteLine("****************************************");
            Console.WriteLine("\nDatos del Alumno:");
            Console.WriteLine($"Nombre: {NombreAlumno}");
            Console.WriteLine($"Número de Cuenta: {NumeroCuenta}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine("\nDatos de la Asignatura:");
            Console.WriteLine($"Nombre: {NombreAsignatura}");
            Console.WriteLine($"Horario: {Horario}");
            Console.WriteLine($"Docente: {NombreDocente}");
            Console.WriteLine("\nNotas:");
            Console.WriteLine($"Nota 1: {N1}");
            Console.WriteLine($"Nota 2: {N2}");
            Console.WriteLine($"Nota 3: {N3}");
            Console.WriteLine($"\nNota Final: {notaFinal} - {MensajeNotaFinal(notaFinal)}");
            Console.WriteLine($"Nota Final: {notaFinalConParametros} - {MensajeNotaFinal(notaFinalConParametros)}");
            Console.WriteLine("\n****************************************");
        }
    }

}
