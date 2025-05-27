using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola.Class
{
    public class PruebaSintaxis
    {
        // Declaraciones de campos o propiedades
        private double saldoFactu;
        private string cliente;

        // Metodo que se llama igual que la clase y que no tiene tipo de retorno
        // es el constructor de la clase
        // se ejecuta al crear un objeto de la clase
        public PruebaSintaxis()
        {
            saldoFactu = 1000.0;
            cliente = "Juan Perez";

            //declaramos y asignamos variables de diferentes tipos
            string nom = "Martín";
            int edad = 18;
            string ciudad = "San Justo";
            double precio = 19.99;

            //declaramos una variable de tipo var (dinamica)
            var nombre = "Alejo";
            var edad2 = 18;


        }


        public void imprimirDeudaFactura()
        {
            Console.WriteLine(cliente + " tiene una deuda de: " + saldoFactu);
        }

        public void ImprimirSaludo(string nombre)
        {
            Console.WriteLine("Hola " + nombre);
        }
    }

}
