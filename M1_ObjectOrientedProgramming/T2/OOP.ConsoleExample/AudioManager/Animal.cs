using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
namespace AudioManager
{
    //The internal class modifier defines that this class is available to elements of the same project.
    //el modificador de clase internal, define que esa clase esta disponible a elementos del mismo proyecto
    public class Animal
    {
        public virtual void AnimalSound() {
            Console.WriteLine("I'm an Animal");
            Console.WriteLine("And I'm happy :D");
        }
    }
}
