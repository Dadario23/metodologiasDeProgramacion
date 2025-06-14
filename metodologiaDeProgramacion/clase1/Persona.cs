using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase1
{
    public abstract class Persona : Comparable
    {
        private string nombre;        
        private int dni;

        public Persona (string nombre,int dni){
            this.nombre =nombre;
            this.dni = dni;

        }

        public string getNombre(){
            return nombre;
        }

        public int getDni(){
            return dni;
        }

    public virtual bool sosIgual(Comparable c)
    {
      Persona otra = (Persona)c;
      return dni == otra.dni;
    }

    public virtual bool sosMenor(Comparable c)
    {   
        Persona otra = (Persona)c;
        return dni < otra.dni;
    }

    public virtual bool sosMayor(Comparable c)
    {
      Persona otra = (Persona)c;
        return dni > otra.dni;
    }
  }
}