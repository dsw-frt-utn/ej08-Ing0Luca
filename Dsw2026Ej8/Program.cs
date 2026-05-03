namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prueba problema2...

            var ej2 = new Problema2();
            // Prueba con cantidad positiva
            Console.WriteLine(ej2.CrearResumenVenta(500, "Monitor", 2, 150));
            // Resultado esperado: 500-Monitor-300

            // Prueba con cantidad negativa (debe dar total 0)
            Console.WriteLine(ej2.CrearResumenVenta(501, "Mouse", -5, 20));
            // Resultado esperado: 501-Mouse-0
        }
    }
}
