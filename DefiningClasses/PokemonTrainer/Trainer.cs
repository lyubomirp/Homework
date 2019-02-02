using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    class Trainer
    {
        private string name;
        private int badges;

        public Trainer (string name) : this(name, 0)
        {

        }

        public Trainer(string name, int badges)
        {
            this.name = name;
            this.badges = badges;
        }

        public int Badges
        {
            get
            {
                return badges;
            }
            set
            {
                this.badges = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}
