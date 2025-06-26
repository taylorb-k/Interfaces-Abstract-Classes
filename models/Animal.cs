using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Models
{
    public abstract class Animal
    {
        private string name;
        private string colour;
        private int age;

        // Constructor
        public Animal(string name, string colour, int age)
        {
            this.name = name;
            this.colour = colour;
            this.age = age;
        }

        // Getters
        public string GetName()
        {
            return name;
        }

        public string GetColour()
        {
            return colour;
        }

        public int GetAge()
        {
            return age;
        }

        // Setters
        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetColour(string colour)
        {
            this.colour = colour;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        // Abstract method
        public abstract void Eat();
    }
}
