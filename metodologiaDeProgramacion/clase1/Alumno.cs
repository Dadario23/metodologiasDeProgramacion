using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase1
{
   public class Alumno : Persona
{
    private int legajo;
    private float promedio;
    private static bool compararPorPromedio = false;

    public Alumno(string nombre, int dni, int legajo, float promedio) 
        : base(nombre, dni)
    {
        this.legajo = legajo;
        this.promedio = promedio;
    }

    public int getLegajo() => legajo;
    public float getPromedio() => promedio;

    // Método estático para cambiar criterio (corregimos el nombre)
    public static void SetCompararPorPromedio(bool porPromedio)
    {
        compararPorPromedio = porPromedio;
    }

    // Método estático para obtener criterio (añadido)
    public static bool GetCompararPorPromedio()
    {
        return compararPorPromedio;
    }

    // Métodos override correctamente
    public override bool sosIgual(Comparable c)
    {
        Alumno otro = (Alumno)c;
        return compararPorPromedio ? 
            this.promedio == otro.promedio : 
            this.legajo == otro.legajo;
    }

    public override bool sosMenor(Comparable c)
    {
        Alumno otro = (Alumno)c;
        return compararPorPromedio ? 
            this.promedio < otro.promedio : 
            this.legajo < otro.legajo;
    }

    public override bool sosMayor(Comparable c)
    {
        Alumno otro = (Alumno)c;
        return compararPorPromedio ? 
            this.promedio > otro.promedio : 
            this.legajo > otro.legajo;
    }
}
}