using Consola.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcu.Class
{
    // añadir ":Calculadora" es hacer que "Calculadora" le herede todos los metodos a CalculadoraCientifica.
    public class CalculadoraCientifica:Calculadora
    {
        public void Potencia(double num1, double num2)
        {
            resultado = Math.Pow(num1, num2);
            operacion = "Potencia";
        }


        public void RaizCuadrada(double num)
        {
            if (num >= 0)
            {
                resultado = Math.Sqrt(num);
                operacion = "Raíz Cuadrada";
            }
            else
            {
                Console.WriteLine("Error: No se puede calcular la raíz cuadrada de un número negativo");
            }
        }
    }
}
