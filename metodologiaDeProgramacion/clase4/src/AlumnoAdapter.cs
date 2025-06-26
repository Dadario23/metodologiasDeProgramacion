using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase4.src
{
    public class AlumnoAdapter : Student
    {
        private IAlumnoDecorado alumno;

        public AlumnoAdapter(IAlumnoDecorado alumno)
        {
            this.alumno = alumno;
        }

        public string getName()
        {
            return alumno.GetNombre();
        }

        public int yourAnswerIs(int question)
        {
            return alumno.ResponderPregunta(question);
        }

        public void setScore(int score)
        {
            alumno.SetCalificacion(score);
        }

        public string showResult()
        {
            return alumno.MostrarCalificacion();
        }

        public bool equals(Student s)
        {
            return this.getScore() == s.getScore();
        }

        public bool lessThan(Student s)
        {
            return this.getScore() < s.getScore();
        }

        public bool greaterThan(Student s)
        {
            return this.getScore() > s.getScore();
        }

        public int getScore()
        {
            return alumno.GetCalificacion();
        }
    }



}