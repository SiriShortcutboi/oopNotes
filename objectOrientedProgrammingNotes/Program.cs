using System;


public class Program
{
	public static void Main()
	{
        //Encapsulation is definitely an interview question, you protect stuff through it
        //OOP - Object Oriented Programming - 1410
        //Pillar 1: Encapsulation by controlling access
        //public and private are used to control exposure
        


        //public is the least secure, can be seen anywhere!!!
        //internal is only avaialble to the Project folder which is inside the solution
        //protected - only that class can use them, or one that inherits from the class
        // all animals can eat and breathe, but wolves bite and walk
        //private is the most secure _ only that class can see/use them
        
        //Pillar 2: Inheritance - parent/base class - relationships, tool
        //D.R.Y. - Don't Repeat Yourself - reusable code
        //if you find yourself copy pasting, that code should really be a method
        // I am reusing or extending behavior, INHERITANCE IS

        //Pillar 3: Abstraction - blueprint/rule, - the concept
        //Every animal should make a sound
        //I'm defining what need to be done
        //Abstraction is almsost always implemented using inheritance, tightly connected but not viewed as the same.
        
        //Pillar 4: Polymorphism - use objects interchangeably 

        //class - blueprint
        //object - is the actualy thing built from it, we are giving shape to it

    /*     //if we say
        Cat cat = new Cat();
        object kitty = new Cat(); //we don't actually know squat about this object anymore
        PoliMethod(cat);                //this allows for some polymorphism
        PoliMethod(dog); */

        Cat cat = new Cat();
        Dog dog = new Dog();
        object dog3 = new Dog();
        object cat3 = new Cat();
        Wolf wolf = new Wolf(); // 

        PoliMethod(cat);           
        PoliMethod(dog); 
        PoliMethod(wolf);

        List<Animal> animals = new List<Animal>();
        animals.Add(dog); 
        animals.Add(cat); 
        animals.Add(wolf);
    }

    internal static void PoliMethod(Animal animal) //the name is consistent, but what object can be tossed in here can vary.
    {
        
        animal.MakeSound;
    }
        // THESE PILLARS ARE THE TERMS THAT YOU WILL NEED TO KNOW IN A JOB INTERVIEW BUT YOU WON'T BE USING THOSE WORDS IN DAY TO DAY OFFICE CONVERSATIONS

        //THROW A JOB FLIER INTO AI AND ASK THE BOT TO QUIZ YOU ON THE TERMS IN THE FLIER AS WELL AS THESE ONES, GOOD REFRESHER TO GET READY



}

            //i think you might hide access behind: an If that tests a guid
        //lol we talked about extreme vs too not extreme, and then 
        // the ide didnt wnat to let mr jesnen do private classes, 
        // just public but i guess we can do private variables
