using Examen.Clases;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Asignatura asignatura = new Asignatura();

            Console.Write("Ingrese el nombre del alumno: ");
            string nombreAlumno = Console.ReadLine();

            Console.Write("Ingrese el número de cuenta: ");
            string numeroCuenta = Console.ReadLine();

            Console.Write("Ingrese el email: ");
            string email = Console.ReadLine();

            asignatura.SetDatosAlumno(nombreAlumno, numeroCuenta, email);

            Console.Write("Ingrese el nombre de la asignatura: ");
            string nombreAsignatura = Console.ReadLine();

            Console.Write("Ingrese el horario: ");
            string horario = Console.ReadLine();

            Console.Write("Ingrese el nombre del docente: ");
            string nombreDocente = Console.ReadLine();

            asignatura.SetDatosAsignatura(nombreAsignatura, horario, nombreDocente);

            Console.Write("Ingrese la nota del primer parcial (0-30): ");
            asignatura.N1 = ValidarNota(0, 30);

            Console.Write("Ingrese la nota del segundo parcial (0-30): ");
            asignatura.N2 = ValidarNota(0, 30);

            Console.Write("Ingrese la nota del tercer parcial (0-40): ");
            asignatura.N3 = ValidarNota(0, 40);

            asignatura.Imprimir();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static int ValidarNota(int min, int max)
    {
        int nota;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out nota) && nota >= min && nota <= max)
            {
                break;
            }
            else
            {
                Console.WriteLine($"Nota inválida. Ingrese una nota entre {min} y {max}: ");
            }
        }
        return nota;
    }
}
