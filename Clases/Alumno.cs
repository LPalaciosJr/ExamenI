using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Clases
{
    public class Alumno
    {
        public string NombreAlumno { get; private set; }
        public string NumeroCuenta { get; private set; }
        public string Email { get; private set; }

        public void SetDatosAlumno(string nombre, string numeroCuenta, string email)
        {
            NombreAlumno = nombre;
            NumeroCuenta = numeroCuenta;
            Email = email;
        }
    }
}
