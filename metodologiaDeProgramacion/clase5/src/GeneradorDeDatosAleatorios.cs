using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase5.src
{
    public class GeneradorDeDatosAleatorios
    {
        private Random random = new Random();
        
        public int NumeroAleatorio(int max) => random.Next(max);
        
        public string StringAleatorio(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}