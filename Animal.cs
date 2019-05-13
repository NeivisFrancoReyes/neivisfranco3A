using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3AHerencia.clases
{
    public abstract class Animal
    {

        public abstract  string hacerRuido();

        public virtual  void comer()
        {

        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private int peso;

        public int Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        private int edad;

        public Animal(string nombre, int peso, int edad)
        {
            Nombre = nombre;
            Peso = peso;
            Edad = edad;
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }



    }
}
