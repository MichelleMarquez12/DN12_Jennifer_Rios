using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioManager;
//Permite hacer uso del contenido de AudioManager
//Allows you to use AudioManager content


//first c# project usage tutorial
namespace OOP.ConsoleExample
{
    //The internal class modifier defines that this class is available to elements of the same project.
    //el modificador de clase internal, define que esa clase esta disponible a elementos del mismo proyecto
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
                //console.writeLine class for printing text 
                Console.WriteLine("Welcome, know the sounds of these animals!");
                Console.WriteLine("\ncat\tcow\tdog\telephant\tlion\tpig");
                Console.WriteLine("\nEnter the animal you want to listen to and then press enter: ");
                String animalType = Console.ReadLine().ToLower();
                Animal animal = null;

                switch (animalType)
                {
                    case "cat":
                        animal = new Cat();
                        break;

                    case "cow":
                        animal = new Cow();
                        break;

                    case "dog":
                        animal = new Dog();
                        break;

                    case "elephant":
                        animal = new Elephant();
                        break;

                    case "lion":
                        animal = new Lion();
                        break;

                    case "pig":
                        animal = new Pig();
                        break;

                    default:
                        Console.WriteLine("Animal not found!");
                        System.Threading.Thread.Sleep(2000);
                        break;
                }

                if (animal != null)
                {
                    animal.AnimalSound();
                }
            }
            
            /*
            //Instancia de la clase Animal
            //Instance of Animal class
            //Animal animal = new Animal();

            //Llamada al metodo de la clase animal
            //Call to the animal class method
            //animal.AnimalSound();
            //Console.WriteLine("\n");

            //Instancia de la clase padre que hereda 
            Cat cat = new Cat();
            cat.AnimalSound();
            Console.WriteLine("\n");

            Cow cow = new Cow();
            cow.AnimalSound();
            Console.WriteLine("\n");

            Dog dog = new Dog();
            dog.AnimalSound();
            Console.WriteLine("\n");

            Elephant elephant = new Elephant();
            elephant.AnimalSound();
            Console.WriteLine("\n");

            Lion lion = new Lion();
            lion.AnimalSound();
            Console.WriteLine("\n");

            Pig pig = new Pig();
            pig.AnimalSound();*/

            //ReadKey allows the program to close once the user presses a key
            //Console.ReadKey();
        }
    }
}
