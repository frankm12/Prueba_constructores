using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_constructores
{
    internal class Program
    {
        // en esta practica estabamos viendo la diferencia entre usar constructores parametrizados y no usarlos
        // en la cual decimos que nos ahorramos lineas de codigo y tambien obligamos a que sean rellenados los campos
        // para poder usar la clase
        static void Main(string[] args)
        {
            
            Persona persona = new Persona();
            persona.nombre = "Franklyn";
            persona.edad = 16;
            Console.WriteLine($" El nombre de la persona es {persona.nombre} y su edad es {persona.edad}");

            Persona persona2 = new Persona();
            persona2.nombre = "Railyng";
            persona2.edad = 14;
            Console.WriteLine($" El nombre de la persona es {persona2.nombre} y su edad es {persona2.edad}");

            Persona persona3 = new Persona();
            persona3.nombre = "John";
            persona3.edad = 15;
            Console.WriteLine($" El nombre de la persona es {persona3.nombre} y su edad es {persona3.edad}");
            //Cuando instancio aqui estoy haciendo un objeto llamado animal tipo animal
            Animales animales = new Animales("Perro","Pitbull");
            Console.WriteLine($" El animal es un/una {animales.Animal} y su raza es {animales.Raza}");

        }
    }
    public class Persona
    {
        public string nombre {  get; set; }
        public int edad {  get; set; }
    }
    public class Animales
    {
        public string Animal;
        public string Raza;
        //Aqui hice el constructor con parametros para despues igualar mis variables a las propiedades de mi clase
        public Animales(string animal, string raza)
        {
            Animal = animal;
            Raza = raza;
        }
    }
}
