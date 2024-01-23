using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Permite hacer uso del contenido de AudioManager
//Allows you to use AudioManager content
using AudioManager;

//first c# project usage tutorial
namespace OOP.ConsoleExample
{
    //The internal class modifier defines that this class is available to elements of the same project.
    //el modificador de clase internal, define que esa clase esta disponible a elementos del mismo proyecto
    class Program
    {
        static void Main(string[] args)
        {
            //console.writeLine class for printing text 
            Console.WriteLine("Hello Wordl!");

            //Instancia de la clase Animal
            //Instance of Animal class
            Animal animal = new Animal();

            //Llamada al metodo de la clase animal
            //Call to the animal class method
            animal.AnimalSound();

            //ReadKey allows the program to close once the user presses a key
            Console.ReadKey();
        }
    }
}
