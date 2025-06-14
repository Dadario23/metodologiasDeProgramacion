using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase5.src
{
    public abstract class FabricaDeComparables
{
    // Constantes para identificar las opciones
    public const int OPCION_ALUMNO = 1;
    public const int OPCION_ALUMNO_MUY_ESTUDIOSO = 2;

    protected GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
    protected LectorDeDatos lector = new LectorDeDatos();

    public static Comparable CrearAleatorio(int opcion)
    {
        return CrearFabrica(opcion).CrearAleatorio();
    }

    public static Comparable CrearPorTeclado(int opcion)
    {
        return CrearFabrica(opcion).CrearPorTeclado();
    }

    
    private static FabricaDeComparables CrearFabrica(int opcion)
    {
        return opcion switch
        {
            OPCION_ALUMNO => new FabricaDeAlumnos(),
            OPCION_ALUMNO_MUY_ESTUDIOSO => new FabricaDeAlumnosMuyEstudiosos(),
            _ => throw new ArgumentException("Opción no válida")
        };
    }

    protected abstract Comparable CrearAleatorio();
    protected abstract Comparable CrearPorTeclado();
}

}