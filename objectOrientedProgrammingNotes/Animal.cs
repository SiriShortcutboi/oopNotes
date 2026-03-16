using System;
using Systme.Collections.Generic;
using System.Text;

namespace ConsoleApp4 //an Animal is never real, its always what is the animal
//an abstract class is kinda like an Airport, you never go to the airport 
//except for the purpose of using it to go somewhere else. 
{
    //base class, Parent Class
    internal abstract class Animal
    {
        public Guid ID {get; set;}
        //adopted date
        //food used

        internal void Eat()
        {
            Console.WriteLine(Name + "is eating");
        }
        //virtual /abstract
        //virtual is sometimes real
        //abstract is never a real THING

        /*
        internal abstract void MakeSound()
        {
            Console.WriteLine("Purrrr");
        } //asbtracts create Rules, all animals must make a sound */

        internal virtual void MakeSound()
        {
            
        }
    }


}