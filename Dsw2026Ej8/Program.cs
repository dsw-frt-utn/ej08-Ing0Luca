namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prueba problema1....




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




            //prueba problema4....

            // 1. Instanciamos la clase del problema
            Problema4 promedioService = new Problema4();

            // 2. CASO 1: Mezcla de notas válidas, nulas y fuera de rango
            // Debería tomar solo el 8 y el 10. Promedio: 9.
            double caso1 = promedioService.CalcularPromedio(8, null, 10);
            Console.WriteLine($"Caso 1 (8, null, 10) -> Esperado: 9 | Resultado: {caso1}");

            // 3. CASO 2: Notas fuera de rango (deben ignorarse)
            // Debería tomar solo el 7. Promedio: 7.
            double caso2 = promedioService.CalcularPromedio(7, -5, 20);
            Console.WriteLine($"Caso 2 (7, -5, 20) -> Esperado: 7 | Resultado: {caso2}");

            // 4. CASO 3: Todas las notas nulas
            // Debería retornar 0.
            double caso3 = promedioService.CalcularPromedio(null, null, null);
            Console.WriteLine($"Caso 3 (null, null, null) -> Esperado: 0 | Resultado: {caso3}");





            //prueba problema5....


            Problema5 p5 = new Problema5();

            // Caso Minorista: 1000 debería dar 1000
            Sale ventaMinorista = new RetailSale { Amount = 1000 };
            Console.WriteLine($"Venta Minorista: {p5.ObtenerImporteFinal(ventaMinorista)}");

            // Caso Mayorista: 1000 debería dar 900 (10% de descuento)
            Sale ventaMayorista = new WholesaleSale { Amount = 1000 };
            Console.WriteLine($"Venta Mayorista: {p5.ObtenerImporteFinal(ventaMayorista)}");



            //prueba problema6.....

            Problema6 p6 = new Problema6();

            // Ejemplo del enunciado: "ab 123 x " => "AB-123-X"

            string resultado1 = p6.NormalizarCodigoProducto("ab 123 x ");
            Console.WriteLine($"Resultado: '{resultado1}'");

            // Prueba con null
            string resultado2 = p6.NormalizarCodigoProducto(null);
            Console.WriteLine($"Resultado Null: {resultado2}");
        }


    }
}
