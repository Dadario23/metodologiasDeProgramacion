using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase4.src
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

    public virtual string GetNombre()
    {
      return nombre;
    }

    public virtual int GetDNI()
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
    
    public virtual int CompareTo(object? obj)
    {
        if (obj == null) return 1;
        
        if (obj is Persona otra)
        {
            return dni.CompareTo(otra.dni);
        }
        
        throw new ArgumentException("El objeto no es Persona");
    }
  }
}