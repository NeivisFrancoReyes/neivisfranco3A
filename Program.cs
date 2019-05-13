using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejemplo3AHerencia.clases;
using Ejemplo3AHerencia.interfaces;

namespace Ejemplo3AHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal generico = new Animal("Prueba",23,23);


            List<Iciclodevida> animales = new List<Iciclodevida>();

            List<Animal> listaAnimales = new List<Animal>();


            List<int> listaValoresEnteros = new List<int>();
            listaValoresEnteros.Add(5);
            listaValoresEnteros.Add(7);
            listaValoresEnteros.Add(20);

            foreach (int item in listaValoresEnteros)
            {
                Console.WriteLine(item);
            }

            Perro perro1 = new Perro("Firulais", 23, 22,"De la calle");
            Gato gato1 = new Gato("Garfield", 22, 11);

            animales.Add(perro1);
            animales.Add(gato1);

            listaAnimales.Add(gato1);
            listaAnimales.Add(perro1);

            foreach (Animal item in listaAnimales)
            {
                Console.WriteLine(item.hacerRuido());
            }
            int edadpromedio = 5;
            foreach (Iciclodevida item in animales)
            {
                item.EdadPromedioDeVida = edadpromedio += 5;
                item.nacer();

            }


            Console.ReadKey();
            
        }
    }
}
