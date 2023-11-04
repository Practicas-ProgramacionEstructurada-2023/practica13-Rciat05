using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Poblado de nombres
          string [] nombres = {"Juan", "Manuel", "Kevin", "Maria", "Zulma", "Kenia"};

          double[] notas_primercomputo = new double[6];

          notas_primercomputo[0] = 7.5;
          notas_primercomputo[1] = 9.5;
          notas_primercomputo[2] = 6.5;
          notas_primercomputo[3] = 10;
          notas_primercomputo[4] = 5.9;
          notas_primercomputo[5] = 8.9;


          string PrimeraPosicion = nombres[0];
          string SegundaPosicion = nombres[1];
          string TerceraPosicion = nombres[2];
          string CuartaPosicion = nombres[3];
          string QuintaPosicion = nombres[4];
          string SextaPosicion = nombres[5];


          double NotasPrimeraPosicion = notas_primercomputo[0]; //7.5
          double NotasSegundaPosicion = notas_primercomputo[1]; //9.5
          double NotasTerceraPosicion = notas_primercomputo[2]; //6.5
          double NotasCuartaPosicion = notas_primercomputo[3]; //10
          double NotasQuintaPosicion = notas_primercomputo[4]; //5.9
          double NotasSextaPosicion = notas_primercomputo[5]; //8.9


          Console.WriteLine("\n-----Mostrando los 6 alumnos de forma ascendente-----");
          Array.Sort(nombres);
          foreach (string Nombre in nombres)
          {
            Console.WriteLine(Nombre);
          }

          Console.WriteLine("\n---Mostrando los 6 alumnos de forma descendente----");
          Array.Reverse(nombres);
          foreach (string Nombre in nombres)
          {
            Console.WriteLine(Nombre);
          }  

          Console.WriteLine("\n-----Mostrando los 6 notas de forma ascendente-----");
          Array.Sort(notas_primercomputo);
          foreach (double Notas1 in notas_primercomputo)
          {
            Console.WriteLine(Notas1);
          }
          
          Console.WriteLine("\n-----Mostrando los 6 notas de forma descendente-----");
          Array.Reverse(notas_primercomputo);
          foreach (double Notas1 in notas_primercomputo)
          {
            Console.WriteLine(Notas1);
          }
          

          Console.WriteLine("\n----Mostrando el Resultado de los 6 alumnos con sus notas del primer computo-----");
          Console.WriteLine(PrimeraPosicion + "tiene la siguiente nota: " + NotasPrimeraPosicion);
          Console.WriteLine(SegundaPosicion + "tiene la siguiente nota: " + NotasSegundaPosicion);
          Console.WriteLine(TerceraPosicion + "tiene la siguiente nota: " + NotasTerceraPosicion);
          Console.WriteLine(CuartaPosicion + "tiene la siguiente nota: " + NotasCuartaPosicion);
          Console.WriteLine(QuintaPosicion + "tiene la siguiente nota: " + NotasQuintaPosicion);
          Console.WriteLine(SextaPosicion + "tiene la siguiente nota: " + NotasSextaPosicion);
        }
    }
}