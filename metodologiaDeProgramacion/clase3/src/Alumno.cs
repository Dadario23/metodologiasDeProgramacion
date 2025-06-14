using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase3.src  
{
    public class Alumno : Persona, IObservador, Comparable
{
    private int legajo;
    private float promedio;
    private static IComparacionAlumno estrategiaComparacion = new ComparacionExacta();

    
    public class ComparacionExacta : IComparacionAlumno
    {
        public bool SosIgual(Alumno a, Alumno b) => 
            a.getDni() == b.getDni() && 
            a.getLegajo() == b.getLegajo() &&
            Math.Abs(a.getPromedio() - b.getPromedio()) < 0.01f;

        public bool SosMenor(Alumno a, Alumno b) => 
            // Mantener lógica original para ordenamiento
            a.getPromedio() < b.getPromedio();

        public bool SosMayor(Alumno a, Alumno b) => 
            a.getPromedio() > b.getPromedio();
    }
    private static readonly Random rnd = new Random();

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
        estrategiaComparacion = estrategia ?? throw new ArgumentNullException(nameof(estrategia));
    }

   
    public override bool sosIgual(Comparable c)
    {
        if (c is Alumno otro)
        {
            
            return this.getDni() == otro.getDni() && 
                this.getLegajo() == otro.getLegajo() &&
                Math.Abs(this.getPromedio() - otro.getPromedio()) < 0.01f;
        }
        return false;
    }

    public override bool sosMenor(Comparable c)
    {
        return c is Alumno otro && estrategiaComparacion.SosMenor(this, otro);
    }

    public override bool sosMayor(Comparable c)
    {
        return c is Alumno otro && estrategiaComparacion.SosMayor(this, otro);
    }

    
    public void Actualizar(Comparable valor)
    {
        if (valor is Profesor)
        {
            if (rnd.Next(2) == 0) 
                PrestarAtencion();
            else
                Distraerse();
        }
    }

    public void PrestarAtencion()
    {
        Console.WriteLine($"{getNombre()} está prestando atención al profesor");
    }

    public void Distraerse()
    {
        string[] acciones = {
            "Mirando el celular",
            "Dibujando en el margen de la carpeta",
            "Tirando aviones de papel"
        };
        Console.WriteLine($"{getNombre()} está {acciones[rnd.Next(acciones.Length)]}");
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Legajo: {legajo}, Promedio: {promedio:0.0}";
    }
}
}