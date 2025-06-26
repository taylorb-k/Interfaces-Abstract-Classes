using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp7.Interfaces;

namespace ConsoleApp7.Models
{
    public class Dog : IAnimal
    {
        // Properties
        public string Name { get; set; }
        public string Colour { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }

        // Constructor
        public Dog(string name = "", string colour = "", double height = 0, int age = 0)
        {
            Name = name;
            Colour = colour;
            Height = height;
            Age = age;
        }

        // Getter methods
        public string GetName()
        {
            return Name;
        }

        public string GetColour()
        {
            return Colour;
        }

        public double GetHeight()
        {
            return Height;
        }

        public int GetAge()
        {
            return Age;
        }

        // Setter methods
        public void SetName(string name)
        {
            Name = name;
        }

        public void SetColour(string colour)
        {
            Colour = colour;
        }

        public void SetHeight(double height)
        {
            Height = height;
        }

        public void SetAge(int age)
        {
            Age = age;
        }

        // Interface method implementations
        public void Eat()
        {
            Console.WriteLine("Dogs eat meat");
        }

        public string Cry()
        {
            return "Woof!";
        }
    }
}
