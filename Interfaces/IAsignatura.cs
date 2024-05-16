using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Interfaces
{
    public interface IAsignatura
    {
        double CalcularNotaFinal();
        double CalcularNotaFinal(int n1, int n2, int n3);
        string MensajeNotaFinal(double notaFinal);
        void Imprimir();
    }
}
