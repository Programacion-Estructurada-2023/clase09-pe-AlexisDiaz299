using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
           
            //Ejercicio 9 Programa para evaluar calificacion
            Console.WriteLine("\n****************Programa evaluar calificacion****************");
            Console.Write("\nIngresar la nota obtenida:");
            double nota = Convert.ToDouble(Console.ReadLine());

            //Si la nota es mayor o igual a 9.5
            if (nota >=9.5)
            { 
              Console.WriteLine("La calificacion obtenida es Excelente");  
            }
           
           //Si la nota es mayor o igual a 8.5
            else if (nota >=8.5)
            {
              Console.WriteLine("La calificicacion obtenida es Muy Buena");   
            }
            
           //Si la nota es mayor o igual a 7.0
            else if (nota >=7.0)
            { 
              Console.WriteLine("La calficacion obtenida es Buena");
            }

           //Si la nota obtenida es deficiente
            else
            {
              Console.WriteLine("L calificacion obtenida es Deficiente");
            } 

            Console.ReadKey();

        }
    }
}