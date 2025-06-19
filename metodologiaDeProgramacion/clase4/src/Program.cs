using System;

namespace src.clase4
{
    class Program
    {
        static void Main(string[] args) 
        {

          // Prueba decoradores
            Alumno alumnoReal = new Alumno("Ana", 123, 456, 8.0f);
            Alumno decorado = new DecoradorLegajo(alumnoReal);
            Console.WriteLine(decorado.MostrarCalificación()); 

            Teacher teacher = new Teacher();
            Random rnd = new Random();

            // Crear 20 alumnos (10 normales + 10 estudiosos)
            for (int i = 0; i < 10; i++)
            {
                // 1 Crear alumno NORMAL (sin decoradores aún)
                Alumno alumnoBase = new Alumno($"Alumno{i}", 1000 + i, 2000 + i, rnd.Next(1, 10));
                
                // Decoradores anidados 
                Alumno alumnoDecorado = new DecoradorRecuadro(
                    new DecoradorEstado(
                        new DecoradorNotaLetras(
                            new DecoradorLegajo(alumnoBase)
                        )
                    )
                );

                // 2 Crear alumno ESTUDIOSO (sin decoradores aún)
                Alumno estudiosoBase = new AlumnoMuyEstudioso($"Estudioso{i}", 3000 + i, 4000 + i, rnd.Next(1, 10));
                
                Alumno estudiosoDecorado = new DecoradorRecuadro(
                    new DecoradorEstado(
                        new DecoradorNotaLetras(
                            new DecoradorLegajo(estudiosoBase)
                        )
                    )
                );

                
                teacher.goToClass(new AlumnoAdapter(alumnoDecorado));
                teacher.goToClass(new AlumnoAdapter(estudiosoDecorado));
            }

            teacher.teachingAClass();
        }
    }
}
