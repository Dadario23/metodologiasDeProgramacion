using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase5.src
{
    public class AlumnoProxy : Comparable
{
    private string nombre;
    private int dni;
    private int legajo;
    private int promedio;
    private bool esEstudioso;

    private Alumno? alumnoReal = null;

    public AlumnoProxy(string nombre, int dni, int legajo, int promedio, bool esEstudioso)
    {
        this.nombre = nombre;
        this.dni = dni;
        this.legajo = legajo;
        this.promedio = promedio;
        this.esEstudioso = esEstudioso;
    }

    private Alumno ObtenerAlumnoReal()
    {
        if (alumnoReal == null)
        {
            Console.WriteLine("Creando instancia real del alumno...");
            alumnoReal = esEstudioso
                ? new AlumnoMuyEstudioso(nombre, dni, legajo, promedio)
                : new Alumno(nombre, dni, legajo, promedio);
        }

        return alumnoReal;
    }

    public int ResponderPregunta(int pregunta)
{
    return ObtenerAlumnoReal().ResponderPregunta(pregunta);
}


    public bool sosIgual(Comparable c)
    {
        return ObtenerAlumnoReal().sosIgual(c);
    }

    public bool sosMenor(Comparable c)
    {
        return ObtenerAlumnoReal().sosMenor(c);
    }

    public bool sosMayor(Comparable c)
    {
        return ObtenerAlumnoReal().sosMayor(c);
    }

    public override string ToString()
    {
        return $"{nombre} (Proxy)";
    }
}

}