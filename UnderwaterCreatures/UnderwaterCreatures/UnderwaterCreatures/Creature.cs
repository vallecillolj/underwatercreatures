using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderwaterCreatures
{
    class Creature
    {
        protected double Age;
        protected string Type;
        protected string Name;
        protected bool Alive = true;


        // 4 Methods

        // Constructor
        public Creature()
        {

        }

        public Creature(double a, string t, string n)
        {
            Age = a;
            Type = t;
            Name = n;
        }

        // Eat

        public void Eat(Item i)
        {
            /*
             * TODO: method should accept an item as an argument (added already), 
             *  and a response should be written to the screen
             *  If the item is food the critter can eat it
             *  If the item is not food, the critter will not eat it
             *  */
            
        }

        // Communicate
        public virtual void Communicate()
        {
           //Define in derived class only
        }


        // Move

        public virtual void Move()
        {
            //Define in derived class only
        }

    }
}
