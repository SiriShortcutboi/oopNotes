 using System;
using System.Collections.Generic;


namespace ConsoleApp4
{
    internal class Dog : Animal
    {
        //cat may have things that dog does not like getlivesCount
        internal override void MakeSound()
        {
            Console.WriteLine(name + "Ruff ruff");
        }
    }

}