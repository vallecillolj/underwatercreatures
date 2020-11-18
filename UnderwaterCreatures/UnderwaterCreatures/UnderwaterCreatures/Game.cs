using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderwaterCreatures
{
    class Game
    {

        // Class Attributes

        //TODO: List of Items to store default items
        List<string> DefaultItems = new List<string>();
        //TODO: List of Creatures to store deafult creatures

        //TODO Create default creatures and add to List
        //TODO Create default Items and Food (2 each minimum) and add to List

        //Hint: Creating a lists or arrays of the base class will allow you to store derived objects
        //i.e. List<Item> or Item[] these would store objects of Item AND objects of Food

        public void Start()
        {
            //TODO: Call Show method
            //TODO: Call the Choose method
            //TODO: With the chosen creature, communicate or talk
            //TODO: Use Random to pass a random item from the food/item list to critter's Eat method
        }

        public void Show()
        {
            //TODO: Show all creatures in the world
            //use a foreach loop to call their Communicate methods
        }

        public void ChooseCreature()
        {
            //TODO: Search the list / array of creature instances for a specific creature
            
        }

        public void AddItem()
        {
            //TODO: Create an item and add to the default list
            //Hint: Player will need to chose from predefined types so think through what types you want
        }

        public void CreateCreature()
        {
            //TODO: Create Custom Creature
            //Let player choose Name, type, age
        }


    }
}
