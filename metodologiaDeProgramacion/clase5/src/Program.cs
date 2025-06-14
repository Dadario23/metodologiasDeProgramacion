using System;
using clase5.src;
namespace src.clase5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Simulación de clase ===");

            Aula aula = new Aula();

            Coleccionable coleccion = new Cola();

            
            if (coleccion is not Ordenable ordenable)
            {
                Console.WriteLine("La colección no implementa Ordenable.");
                return;
            }

            
            OrdenEnAula1 ordenInicio = new OrdenInicio(aula);
            OrdenEnAula1 ordenAulaLlena = new OrdenAulaLlena(aula);
            OrdenEnAula2 ordenLlegaAlumno = new OrdenLlegaAlumno(aula);

            
            ordenable.setOrdenInicio(ordenInicio);
            ordenable.setOrdenLlegaAlumno(ordenLlegaAlumno);
            ordenable.setOrdenAulaLlena(ordenAulaLlena);

            
            Console.WriteLine("\n--- Llenando con 20 alumnos normales ---");
            LlenarColeccion(coleccion, FabricaDeComparables.OPCION_ALUMNO);

            
            Console.WriteLine("\n--- Llenando con 20 alumnos muy estudiosos ---");
            LlenarColeccion(coleccion, FabricaDeComparables.OPCION_ALUMNO_MUY_ESTUDIOSO);

            Console.WriteLine("\n=== Fin del programa ===");
        }

        static void LlenarColeccion(Coleccionable coleccion, int tipoElemento)
        {
            for (int i = 0; i < 20; i++)
            {
                Comparable elemento = FabricaDeComparables.CrearAleatorio(tipoElemento);
                Console.WriteLine($"Agregando: {elemento}");
                coleccion.agregar(elemento);
            }
        }
    }

}




