using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Interfaces
{
    public interface IAnimal
    {
        // Properties
        string Name { get; set; }
        string Colour { get; set; }
        double Height { get; set; }
        int Age { get; set; }

        // Methods
        string GetName();
        string GetColour();
        double GetHeight();
        int GetAge();

        void SetName(string name);
        void SetColour(string colour);
        void SetHeight(double height);
        void SetAge(int age);

        void Eat();
        string Cry();
    }
}
