using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    class Pokemon
    {
        private string name;
        private string element;
        private int health;

        public Pokemon (string name, string element, int health)
        {
            this.name = name;
            this.element = element;
            this.health = health;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Element
        {
            get
            {
                return element;
            }
        }
        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                this.health = value;
            }
        }
    }
}
