using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase5.src
{
    public class AlumnoAdapter : Student
    {
        private IAlumno _alumnoBase;

        public AlumnoAdapter(IAlumno alumno)
        {
            _alumnoBase = alumno;
        }

        public int getScore() => _alumnoBase.getCalificacion();

        public void setScore(int score) => _alumnoBase.setCalificacion(score);

        public string getName() => _alumnoBase.getNombre();

        public int yourAnswerIs(int question) => _alumnoBase.ResponderPregunta(question);

        public string showResult() => _alumnoBase.MostrarCalificacion();

        public bool equals(Student student)
        {
            return student is AlumnoAdapter other && _alumnoBase.sosIgual(other._alumnoBase);
        }

        public bool lessThan(Student student)
        {
            return student is AlumnoAdapter other && _alumnoBase.sosMenor(other._alumnoBase);
        }

        public bool greaterThan(Student student)
        {
            return student is AlumnoAdapter other && _alumnoBase.sosMayor(other._alumnoBase);
        }
    }

}