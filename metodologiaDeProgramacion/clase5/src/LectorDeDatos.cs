using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase5.src
{
    public class LectorDeDatos
    {
        public int NumeroPorTeclado()
        {
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int numero))
            {
                return numero;
            }

            Console.WriteLine("Entrada inválida. Se usará 0 por defecto.");
            return 0;
        }

        public string StringPorTeclado()
        {
            string? input = Console.ReadLine();
            return input ?? string.Empty; 
        }
    }
}