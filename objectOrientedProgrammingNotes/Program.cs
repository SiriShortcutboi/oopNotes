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
        Car car = new Car("Hotwheels", "speedster");
        Console.WriteLine(car.Make);

        //if level cap must be level 50, there would not be anything to stop that right now
        // so lets fix it.

        // using an _underscore before a variable usually means its _private
    }
}

            //i think you might hide access behind an if that tests a guid
        //lol we talked about extreme vs too not extreme, and then 
        // the ide didnt wnat to let mr jesnen do private classes, 
        // just public but i guess we can do private variables
