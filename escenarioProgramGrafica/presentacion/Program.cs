using escenarioProgramGrafica.presentacion;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace escenarioProgramGrafica
{
    class Program
    {

        static void Main(string[] args)
        {
            using (ventana game = new ventana(800, 600, "LearnOpenTK"))
            {
                //Run takes a double, which is how many frames per second it should strive to reach.
                //You can leave that out and it'll just update as fast as the hardware will allow it.
                game.Run(60.0);
            }
            //Stopwatch timeMeasure = new Stopwatch();
            //timeMeasure.Start();
            //////int operacion = 10 / 4;
            //for (int i=0; i<100; i++)
            //{
            //    TimeSpan a = new TimeSpan(0, 0, 0, 0, (int)timeMeasure.ElapsedMilliseconds);
            //    //Thread.Sleep(1000);
            //    Console.WriteLine($"Tiempo: {timeMeasure.Elapsed.TotalMilliseconds} ms" + " variable " + i);
            //    Console.WriteLine($"Tiempo: " + a.Seconds.ToString()+" segundos " +a.Milliseconds.ToString() +" milisegundos" + " variable " + i);

            //}
            //timeMeasure.Stop();
            ////Console.WriteLine($"Tiempo: {timeMeasure.Elapsed.TotalMilliseconds} ms");
            //Console.ReadKey();
        }
    }
}
