using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase4.src
{
    public abstract class DecoradorAlumno : IAlumnoDecorado
    {
        protected IAlumnoDecorado componente;

        public DecoradorAlumno(IAlumnoDecorado comp)
        {
            componente = comp;
        }

        public virtual int GetLegajo() => componente.GetLegajo();

        public virtual bool SosIgual(IComparable comparable)
        {
            return componente.SosIgual(comparable);
        }

        public virtual bool SosMenor(IComparable comparable)
        {
            return componente.SosMenor(comparable);
        }

        public virtual bool SosMayor(IComparable comparable)
        {
            return componente.SosMayor(comparable);
        }

        public virtual string MostrarCalificacion() => componente.MostrarCalificacion();
        public virtual int ResponderPregunta(int pregunta) => componente.ResponderPregunta(pregunta);
        public virtual string GetNombre() => componente.GetNombre();
        public virtual int GetCalificacion() => componente.GetCalificacion();
        public virtual int CompareTo(object? obj)
        {
            if (obj == null) return 1;
            
            if (componente is IComparable comparable)
                return comparable.CompareTo(obj is IAlumnoDecorado decorado ? decorado : obj);
            
            throw new ArgumentException("El objeto no es comparable");
        }


        public virtual void SetCalificacion(int nota)
        {
            componente.SetCalificacion(nota);
        }

    }

}