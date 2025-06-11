using Calcu.Class;
using Consola.Class;
internal class Program
{
    //private static void Main(string[] argumentos)
    //{
    //    // declaraciones de variables
    //    double num1 = 0;
    //    double num2 = 0;
    //    string operacion = "";
    //    if (argumentos.Length > 2)
    //    {
    //        try
    //        {
    //            //convertimos el primer argumento a un numero entero
    //            num1 = Convert.ToDouble(argumentos[0]);

    //            //convertimos el tercer argumento a un numero entero
    //            num2 = Convert.ToDouble(argumentos[2]);

    //            // asignamos el segundo argumento a la variable operacion
    //            operacion = argumentos[1];
    //        }
    //        catch (FormatException e)
    //        {
    //            Console.WriteLine("Error: Formato de número no válido");
    //            return;
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine("Error: Argumentos insuficientes");
    //            return;
    //        }

    //        var calculadora = new CalculadoraCientifica();
    //        switch (operacion.ToLower())
    //        {
    //            case "+":
    //                calculadora.Sumar(num1, num2);
    //                break;
    //            case "-":
    //                calculadora.Restar(num1, num2);
    //                break;
    //            case "*":
    //                calculadora.Multiplicar(num1, num2);
    //                break;
    //            case "/":
    //                calculadora.Dividir(num1, num2);
    //                break;
    //            case "potencia":
    //                calculadora.Potencia(num1, num2);
    //                break;
    //            default:
    //                Console.WriteLine("Operación no válida");
    //                break;
    //        }
    //        calculadora.ImprimirResultado();
    //    }
    //    else if (argumentos.Length == 2)
    //    {
    //        try
    //        {
    //            //convertimos el primer argumento a un numero entero
    //            num1 = Convert.ToDouble(argumentos[0]);

    //            // asignamos el segundo argumento a la variable operacion
    //            operacion = argumentos[1];
    //        }
    //        catch (FormatException e)
    //        {
    //            Console.WriteLine("Error: Formato de número no válido");
    //            return;
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine("Error: Argumentos insuficientes");
    //            return;
    //        }

    //        var calculadora = new CalculadoraCientifica();
    //        switch (operacion.ToLower())
    //        {
    //            case "raiz":
    //                calculadora.RaizCuadrada(num1);
    //                break;
    //            default:
    //                Console.WriteLine("Operación no válida");
    //                break;
    //        }
    //        calculadora.ImprimirResultado();
    //    }
    //    else
    //    {
    //        Console.WriteLine("No se han pasado argumentos");
    //    }
    //}

    private static void Main(string[] argumentos)
    {
        Calculadora calcu1 = new Calculadora();
        Calculadora calcu2 = new CalculadoraCientifica();
        Calculadora calcu3 = new CalculadoraCientifica();
        Console.WriteLine("Numero de las instancias de la clase calculadora: " + Calculadora.instancias);
        Calculadora.Potencia(2, 8);
    }
}