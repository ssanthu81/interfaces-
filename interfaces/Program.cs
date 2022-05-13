﻿using System;

namespace MyApplication
{
   
    interface IAnimal
    {
        void animalSound(); 
    }


    class Pig : IAnimal
    {
        public void animalSound()
        {
            
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();  
            myPig.animalSound();
        }
    }
}

