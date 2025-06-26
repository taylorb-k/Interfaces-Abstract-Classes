using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp7.Interfaces;
using ConsoleApp7.Models;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Dog object
            Dog myDog = new Dog();

            Console.WriteLine("Enter a dog name:");
            myDog.SetName(Console.ReadLine());

            Console.WriteLine("Enter dog colour:");
            myDog.SetColour(Console.ReadLine());

            Console.WriteLine("Enter dog height (in cm):");
            myDog.SetHeight(double.Parse(Console.ReadLine()));

            Console.WriteLine("Enter dog age:");
            myDog.SetAge(int.Parse(Console.ReadLine()));

            // Display Dog properties and behavior
            Console.WriteLine("\nDog Information:");
            Console.WriteLine($"Name: {myDog.GetName()}");
            Console.WriteLine($"Colour: {myDog.GetColour()}");
            Console.WriteLine($"Height: {myDog.GetHeight()} cm");
            Console.WriteLine($"Age: {myDog.GetAge()}");
            myDog.Eat();
            Console.WriteLine($"The dog says: {myDog.Cry()}");

            // Create a Cat object
            Cat myCat = new Cat();

            Console.WriteLine("\nEnter a cat name:");
            myCat.SetName(Console.ReadLine());

            Console.WriteLine("Enter cat colour:");
            myCat.SetColour(Console.ReadLine());

            Console.WriteLine("Enter cat height (in cm):");
            myCat.SetHeight(double.Parse(Console.ReadLine()));

            Console.WriteLine("Enter cat age:");
            myCat.SetAge(int.Parse(Console.ReadLine()));

            // Display Cat properties and behavior
            Console.WriteLine("\nCat Information:");
            Console.WriteLine($"Name: {myCat.GetName()}");
            Console.WriteLine($"Colour: {myCat.GetColour()}");
            Console.WriteLine($"Height: {myCat.GetHeight()} cm");
            Console.WriteLine($"Age: {myCat.GetAge()}");
            myCat.Eat();
            Console.WriteLine($"The cat says: {myCat.Cry()}");

            // Create a list of animals and add objects
            List<IAnimal> animals = new List<IAnimal>
        {
            myDog,
            myCat,
            new Dog("Rex", "Brown", 50, 5),
            new Cat("Whiskers", "White", 30, 3)
        };

            // Print the names of all animals
            Console.WriteLine("\nList of all animals:");
            foreach (var animal in animals)
            {
                Console.WriteLine($"Name: {animal.GetName()}, Type: {animal.GetType().Name}, Sound: {animal.Cry()}");
            }

            Console.ReadKey();
        }
    }
}
