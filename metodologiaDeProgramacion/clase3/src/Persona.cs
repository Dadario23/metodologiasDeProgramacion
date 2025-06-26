using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace clase3.src
{
    public abstract class Persona : IComparable
    {
        private string nombre;
        private int dni;

        public Persona(string nombre, int dni)
        {
            this.nombre = nombre;
            this.dni = dni;

        }

        public string GetNombre()
        {
            return nombre;
        }

        public int GetDNI()
        {
            return dni;
        }

        public virtual bool SosIgual(IComparable c)
        {
            Persona otra = (Persona)c;
            return dni == otra.dni;
        }

        public virtual bool SosMenor(IComparable c)
        {
            Persona otra = (Persona)c;
            return dni < otra.dni;
        }

        public virtual bool SosMayor(IComparable c)
        {
            Persona otra = (Persona)c;
            return dni > otra.dni;
        }

        public override string ToString()
        {
            return $"{nombre} (DNI: {dni})";
        }
    }
}