using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase2
{
   public class Alumno : Persona
{
    private int legajo;
    private float promedio;
    private static IComparacionAlumno estrategiaComparacion = new CompararPorLegajo(); 

    public Alumno(string nombre, int dni, int legajo, float promedio) 
        : base(nombre, dni)
    {
        this.legajo = legajo;
        this.promedio = promedio;
    }

    public int getLegajo() => legajo;
    public float getPromedio() => promedio;

    
    public static void SetEstrategiaComparacion(IComparacionAlumno estrategia)
    {
        estrategiaComparacion = estrategia;
    }

    public override bool sosIgual(Comparable c)
    {
        return estrategiaComparacion.SosIgual(this, (Alumno)c);
    }

    public override bool sosMenor(Comparable c)
    {
        return estrategiaComparacion.SosMenor(this, (Alumno)c);
    }

    public override bool sosMayor(Comparable c)
    {
        return estrategiaComparacion.SosMayor(this, (Alumno)c);
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Legajo: {legajo}, Promedio: {promedio:0.0}";
    }
}
}