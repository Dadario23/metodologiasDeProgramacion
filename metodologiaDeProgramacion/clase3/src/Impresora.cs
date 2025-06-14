using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase3.src
{
    public class Impresora : IObservador
    {
        public void Actualizar(Comparable valor)
        {
            Console.WriteLine($"[Observer] Nuevo elemento agregado: {valor}");
        }
    }
}