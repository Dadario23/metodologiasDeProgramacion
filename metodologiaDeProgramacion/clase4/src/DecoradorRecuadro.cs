using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase4.src
{
    public class DecoradorRecuadro : DecoradorAlumno
    {
        public DecoradorRecuadro(IAlumnoDecorado comp) : base(comp) { }

        public override string MostrarCalificacion()
        {
            string contenido = componente.MostrarCalificacion();
            string marco = new string('*', contenido.Length + 4);
            return $"{marco}\n* {contenido} *\n{marco}";
        }
    }

}