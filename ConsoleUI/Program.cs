using DemoLibrary.Models;
using System;
using PersonClassLibrary.Models;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonModel person = new PersonModel();

            PersonModel1 person = new();

            person.FirstName = "Mike";
            person.LastName = "Robards";

            Console.WriteLine($"Hello {person.FirstName} {person.LastName}! Successfully used class libraries!");


            

        }
    }
}
