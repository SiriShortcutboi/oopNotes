 using System;
using System.Collections.Generic;


namespace ConsoleApp4
{
 //child class, or better term Inherited Class
    internal class Cat : Animal
    {
        public int LivesGet{ get; set; }
        internal override void MakeSound()
        {
            Console.WriteLine(name + "meows");
        }
    }

}