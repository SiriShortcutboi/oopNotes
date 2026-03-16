 using System;
using System.Collections.Generic;


namespace ConsoleApp4
{
    internal class Cat : Animal
    {
        public int LivesGet{ get; set; }
        internal override void MakeSound()
        {
            Console.WriteLine(name + "meows");
        }
    }

}