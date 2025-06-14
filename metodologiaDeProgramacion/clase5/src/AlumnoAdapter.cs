using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase5.src
{
    public class AlumnoAdapter : Student
    {
        private Alumno _alumnoBase;  

    public AlumnoAdapter(Alumno alumno)
    {
        _alumnoBase = alumno;  
    }
    public int getScore() => _alumnoBase.Calificación;

    public void setScore(int score)
    {
        _alumnoBase.Calificación = score;  
    }

        public string getName() => _alumnoBase.getNombre();
        
        public int yourAnswerIs(int question) => _alumnoBase.ResponderPregunta(question);
        
        

        public string showResult() => _alumnoBase.MostrarCalificación();
        
        public bool equals(Student student) 
            => _alumnoBase.sosIgual(((AlumnoAdapter)student)._alumnoBase);
        
        public bool lessThan(Student student) 
            => _alumnoBase.sosMenor(((AlumnoAdapter)student)._alumnoBase);
        
        public bool greaterThan(Student student) 
            => _alumnoBase.sosMayor(((AlumnoAdapter)student)._alumnoBase);

  }
}