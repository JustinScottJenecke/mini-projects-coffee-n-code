using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasEasy
{
    public class Animal
    {
        public string name;
        public string sound;
        static int numAnimals = 0;

        public Animal()
        {
            this.name = "no name";
            this.sound = "no sound";
            numAnimals++;
        }
        public Animal(string name = "no name", string sound = "no sound")
        {
            this.name = name;
            this.sound = sound;
            numAnimals++;
        }

        public void MakeSound() 
        {
            Console.WriteLine("{0} says {1}", this.name, this.sound);
        }

        public static int getNumAnimals() 
        {
            return numAnimals;
        }
    }
}
