using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase5.src
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

    public virtual int ResponderPregunta(int pregunta)
    {
        Random rnd = new Random();
        return rnd.Next(1, 4); 
    }
    public virtual int Calificación { get; set; }  
    public virtual string MostrarCalificación() => $"{getNombre()}    {Calificación}";
    public virtual int getLegajo() => legajo;
    public virtual float getPromedio() => promedio;

    public static void SetCompararPorPromedio(bool porPromedio)
    {
        compararPorPromedio = porPromedio;
    }

    public static bool GetCompararPorPromedio()
    {
        return compararPorPromedio;
    }

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