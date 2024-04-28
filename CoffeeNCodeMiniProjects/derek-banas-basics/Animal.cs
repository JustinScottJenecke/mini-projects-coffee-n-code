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
        public Animal(string name, string sound)
        {
            
            this.name = name;
            this.sound = sound;
            numAnimals++;
        }
    }
}
