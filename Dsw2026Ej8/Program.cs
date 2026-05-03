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


            

            // prueba problema3....

            // 1. Creamos una instancia de la clase donde está la lógica
            Problema3 ejecutor = new Problema3();

            // 2. Creamos un objeto de tipo Product con una descripción inicial
            Product miProducto = new Product();
            miProducto.Descripcion = "Producto Original";

            // 3. Definimos un valor entero inicial
            int miNumero = 100;

            // 4. Llamamos al método y guardamos el resultado string que devuelve
            string resultado = ejecutor.CompararCopias(miNumero, miProducto);

            // 5. Mostramos el resultado por consola
            Console.WriteLine("Resultado del método: " + resultado);

            // 6. Verificación extra para entender el concepto:
            Console.WriteLine("\n--- Verificación de Memoria ---");
            Console.WriteLine("Valor de miNumero: " + miNumero);
            // Debería seguir siendo 100 porque se pasó por VALOR

            Console.WriteLine("Descripción de miProducto: " + miProducto.Descripcion);
            // Debería ser 'Copia Modificada' porque se pasó por REFERENCIA
        }


    }
}
