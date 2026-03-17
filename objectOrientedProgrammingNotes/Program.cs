using System;
using System.Data.Common;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices.Marshalling;


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


        // THESE PILLARS ARE THE TERMS THAT YOU WILL NEED TO KNOW IN A JOB INTERVIEW BUT YOU WON'T BE USING THOSE WORDS IN DAY TO DAY OFFICE CONVERSATIONS

        //THROW A JOB FLIER INTO AI AND ASK THE BOT TO QUIZ YOU ON THE TERMS IN THE FLIER AS WELL AS THESE ONES, GOOD REFRESHER TO GET READY


        Car car = new Car("Hotwheels", "speedster");
        Console.WriteLine(car.Make);

        Character character = new Character();
        character.SetLevel(1);

        Console.WriteLine(character.Level); 

        List<Animal> animals = new List<Animal>();
        Animals.Add(dog);
        Animals.Add(cat);
        
        foreach (var animal in animals)
        {
         animal.Eat();
         animal.MakeSound();   
        }


    
        
        //if level cap must be level 50, there would not be anything to stop that right now
        // so lets fix it.

        // using an _underscore before a variable usually means its _private
        
        Animal animal = new Animal();
        animal.MakeSound();

        Cat cat = new Cat();
        cat.Name = "garfield";
        cat.Eat();

        Console.WriteLine(cat.Name);

        Dog dog = new Dog();
        dog.Name = "Banna caffa latta";
        dog.Eat();
        dog.MakeSound();

        //sweet i just tested this for a research assignment, 
        //when you type prop and hit Tab it populates a new a object/variable with get sets for you to work with 
        
        //public int MyProperty { get; set; }


        /*
        VideoGame Example
        Character - hero, villain, mosnter
        names, id, health, strength, food, spells, luck, intelligence

        hero
        exp to next level
        reputation - hero
        rival

        villain
        monolog
        backstory

        monster
        aggro distance
        aggro level (aggro goes down with gold boots equipped)
        exp granted (on kill of monster)

        

        Real World example

        if i want to give an attribute or a method to everybody you just give it once to the employee and everyone gets it        
        Employee
        id, name, birthday, startdate, ssn, salary, manager 

        Manager  : Employee //has all his superpowers and more
        List<Employees> manage, task (approve time off), vacation days, discount

        Hr: Employee
        List all employees, urgent tasks, training schedule


        */

    }
}

            //i think you might hide access behind an If that tests a guid
        //lol we talked about extreme vs too not extreme, and then 
        // the ide didnt wnat to let mr jesnen do private classes, 
        // just public but i guess we can do private variables
