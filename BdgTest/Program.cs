using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int numero = Convert.ToInt32(Console.ReadLine());           
            Console.WriteLine("La suma de los numeros primos de 1 a " + numero +" es: " + EsPrimoSuma(numero));
            if (EsPrimo(numero) == true)
            {
                Console.WriteLine("El numero: " + numero + " es primo");
            }
            else
            {
                Console.WriteLine("El numero: " + numero + " no es primo");
            }
            Console.ReadKey();
        }

        public static int EsPrimoSuma(int numero)
        {
            int[] numeros = new int[numero];
            int suma = 0;
            int cont = 1;

            Console.WriteLine("Los numeros primos son:");
            do
            {
                if (EsPrimo(cont) == true)
                {
                    Console.WriteLine(cont);
                    suma = cont + suma;
                }

                cont++;
            } while (cont <= numero);

            return suma;
        }

        public static bool EsPrimo(int numero)
        {
            int c = 0;

            for (int i = 1; i <= numero +1; i++)
            {
                if(numero % i == 0)
                {
                    c++;                 
                }                
            }

            if (c > 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
