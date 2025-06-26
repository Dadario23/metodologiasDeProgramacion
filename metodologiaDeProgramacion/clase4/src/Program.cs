using System;

namespace clase4.src
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DEMOSTRACIÓN PATRONES ADAPTER Y DECORATOR ===");
            Console.WriteLine("=== Sistema de Calificaciones de Alumnos ===\n");

            // 1. Creación de alumnos base
            Console.WriteLine("Creando alumnos regulares y estudiosos...");
            
            List<IAlumnoDecorado> alumnos = new List<IAlumnoDecorado>(); 
            
            // Crear 5 alumnos regulares
            for (int i = 1; i <= 5; i++)
            {
                var alumno = new Alumno($"AlumnoRegular{i}", 1000 + i, 30000000 + i);
                alumnos.Add(alumno);
                Console.WriteLine($"- Creado: {alumno.GetNombre()} (Legajo: {alumno.GetLegajo()})");
            }
            
            // Crear 5 alumnos estudiosos
            for (int i = 1; i <= 5; i++)
            {
                var alumno = new AlumnoMuyEstudioso($"AlumnoEstudioso{i}", 2000 + i, 40000000 + i);
                alumnos.Add(alumno);
                Console.WriteLine($"- Creado: {alumno.GetNombre()} (Legajo: {alumno.GetLegajo()})");
            }

            // 2. Tomar examen y calcular calificaciones reales
            Console.WriteLine("\nTomando examen a los alumnos...");
            foreach (var alumno in alumnos)
            {
                int sumaPuntos = 0;
                
                for (int pregunta = 1; pregunta <= 10; pregunta++)
                {
                    sumaPuntos += alumno.ResponderPregunta(pregunta);
                }
                
                int calificacion;
                if (alumno is AlumnoMuyEstudioso)
                {
                    calificacion = (int)Math.Round(sumaPuntos / 10.0);
                }
                else
                {
                    calificacion = (int)Math.Round(sumaPuntos / 3.0);
                }
                
                alumno.SetCalificacion(calificacion);
                Console.WriteLine($"- Examinado: {alumno.GetNombre()} | Nota: {calificacion}");
            }

            // 3. Aplicar decoradores base (sin orden ni recuadro todavía)
            Console.WriteLine("\nAplicando decoradores base...");
            for (int i = 0; i < alumnos.Count; i++)
            {
                alumnos[i] = new DecoradorLegajo(alumnos[i]);
                alumnos[i] = new DecoradorNotaEnLetras(alumnos[i]);
                alumnos[i] = new DecoradorEstado(alumnos[i]);
                Console.WriteLine($"- Decoradores base aplicados a {alumnos[i].GetNombre()}");
            }

            // 4. Ordenar por calificación descendente
            Console.WriteLine("\nOrdenando alumnos por calificación...");
            var alumnosOrdenados = alumnos
                .OrderByDescending(a => a.GetCalificacion())
                .ThenBy(a => a.GetNombre())
                .ToList();

            // 5. Aplicar decoradores finales (orden y recuadro)
            Console.WriteLine("\nAplicando decoradores finales...");
            List<IAlumnoDecorado> alumnosDecoradosFinales = new List<IAlumnoDecorado>();
            for (int i = 0; i < alumnosOrdenados.Count; i++)
            {
                var alumno = alumnosOrdenados[i];
                alumno = new DecoradorOrden(alumno, i + 1);
                alumno = new DecoradorRecuadro(alumno);
                alumnosDecoradosFinales.Add(alumno);
                Console.WriteLine($"- Decoradores finales aplicados a {alumno.GetNombre()}");
            }

            // 6. Mostrar resultados finales
            Console.WriteLine("\n=== Resultados Finales ===");
            Console.WriteLine("Mostrando calificaciones con todos los decoradores:");
            foreach (var alumno in alumnosDecoradosFinales)
            {
                Console.WriteLine(alumno.MostrarCalificacion());
            }

            // 7. Demostración del patrón Adapter
            Console.WriteLine("\n=== Interacción mediante Adapter (Student) ===");
            List<Student> alumnosAdaptados = new List<Student>();
            foreach (var alumno in alumnosDecoradosFinales)
            {
                var adaptado = new AlumnoAdapter(alumno);
                alumnosAdaptados.Add(adaptado);
                Console.WriteLine($"- {adaptado.getName()} -> Resultado: {adaptado.showResult()}");
            }


        }
    }
}
