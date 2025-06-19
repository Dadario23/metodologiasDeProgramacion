using System;
using clase5.src;
namespace src.clase5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE GESTIÓN DE AULA ===");
            Console.WriteLine("Demostración integrada de patrones:\n");
            Console.WriteLine("1. Patrón Proxy - Creación diferida de alumnos");
            Console.WriteLine("2. Patrón Command - Gestión de órdenes del aula\n");

            // ========== CONFIGURACIÓN INICIAL ==========
            Console.WriteLine("\n[CONFIGURACIÓN INICIAL]");
            Aula aula = new Aula();
            Coleccionable coleccion = new Cola();

            // Configurar órdenes (Patrón Command)
            Console.WriteLine("\nConfigurando órdenes...");
            if (coleccion is Ordenable ordenable)
            {
                ordenable.setOrdenInicio(new OrdenInicio(aula));
                ordenable.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
                ordenable.setOrdenAulaLlena(new OrdenAulaLlena(aula));
                Console.WriteLine("✓ OrdenInicio - Se ejecutará al primer alumno");
                Console.WriteLine("✓ OrdenLlegaAlumno - Se ejecutará por cada alumno");
                Console.WriteLine("✓ OrdenAulaLlena - Se ejecutará al llegar a 40 alumnos");
            }

            // ========== DEMOSTRACIÓN EXPLÍCITA DEL PROXY ==========
            Console.WriteLine("\n[DEMOSTRACIÓN PATRÓN PROXY]");
            Console.WriteLine("Creando alumnos de prueba...");
            
            var proxyDemoNormal = new AlumnoProxy("ALUMNO_NORMAL", 1000, 500, 7.0f, false);
            var proxyDemoEstudioso = new AlumnoProxy("ALUMNO_ESTUDIOSO", 1001, 501, 9.0f, true);

            Console.WriteLine("\nEstado inicial de los proxies:");
            Console.WriteLine($"- {proxyDemoNormal} (Tipo: {proxyDemoNormal.GetType().Name})");
            Console.WriteLine($"- {proxyDemoEstudioso} (Tipo: {proxyDemoEstudioso.GetType().Name})");
            Console.WriteLine("  → Los objetos reales no se han creado aún (creación diferida)");

            Console.WriteLine("\nSimulando examen:");
            Console.WriteLine($"ALUMNO_NORMAL (Proxy) responde: {proxyDemoNormal.ResponderPregunta(1)}");
            Console.WriteLine($"ALUMNO_ESTUDIOSO (Proxy) responde: {proxyDemoEstudioso.ResponderPregunta(1)}");
            Console.WriteLine("  ✓ Se crearon las instancias reales solo al responder");

            // ========== SIMULACIÓN COMPLETA DEL AULA ==========
            Console.WriteLine("\n[SIMULACIÓN COMPLETA DEL AULA]");
            
            Console.WriteLine("\nAgregando 20 alumnos normales...");
            for (int i = 0; i < 20; i++)
            {
                coleccion.agregar(FabricaDeComparables.CrearAleatorio(FabricaDeComparables.OPCION_ALUMNO));
            }

            Console.WriteLine("\nAgregando 20 alumnos muy estudiosos...");
            for (int i = 0; i < 20; i++)
            {
                coleccion.agregar(FabricaDeComparables.CrearAleatorio(FabricaDeComparables.OPCION_ALUMNO_MUY_ESTUDIOSO));
            }

            // ========== RESULTADOS FINALES ==========
            Console.WriteLine("\n[RESULTADOS FINALES]");
            aula.claseLista();

            Console.WriteLine("\n=== SIMULACIÓN COMPLETADA CON ÉXITO ===");
        }
    }

}




