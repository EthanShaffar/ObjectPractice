using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPractice
{
    class Animal
    {
        public string Name { get; set; }
        public int Legs { get; set; }
        public string TailLength { get; set; }

        public void Animal(string name, int legs, string tailLength)
        {
            this.Name = name;
            this.Legs = legs;
            this.TailLength = tailLength;
        }
        
    }
}
