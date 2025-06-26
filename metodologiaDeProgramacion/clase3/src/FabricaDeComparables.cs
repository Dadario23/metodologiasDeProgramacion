using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace clase3.src
{
    public abstract class FabricaDeComparables
    {
        protected GeneradorDeDatosAleatorios generador;
        protected LectorDeDatos lector;
        
        public FabricaDeComparables(GeneradorDeDatosAleatorios generador, LectorDeDatos lector)
        {
            this.generador = generador;
            this.lector = lector;
        }
        
        public abstract IComparable CrearAleatorio();
        public abstract IComparable CrearPorTeclado();
    }
}