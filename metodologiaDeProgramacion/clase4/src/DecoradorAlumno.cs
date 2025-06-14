using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.clase4
{
    public abstract class DecoradorAlumno : Alumno
    {
        protected Alumno _alumno;
    public DecoradorAlumno(Alumno alumno) : base("", 0, 0, 0)  
    {
        _alumno = alumno;
    }

    public override string getNombre() => _alumno.getNombre();
    public override int getDni() => _alumno.getDni();
    public override int getLegajo() => _alumno.getLegajo();
    public override float getPromedio() => _alumno.getPromedio();
    public override int Calificación 
    {
        get => _alumno.Calificación;
        set => _alumno.Calificación = value;
    }
    }
}