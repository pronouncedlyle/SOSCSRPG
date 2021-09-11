using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;
using System.Linq;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static List<GameItem> _standardGameItems;

        //first time an item is used it runs this
        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>();

            _standardGameItems.Add(new Weapon(1001, "Pointy Stick", 1, 1, 2));
            _standardGameItems.Add(new Weapon(1002, "Rusty Sword", 5, 1, 3));
            _standardGameItems.Add(new GameItem(9001, "Snake fang", 1));
            _standardGameItems.Add(new GameItem(9002, "Snakeskin", 2));
            _standardGameItems.Add(new GameItem(9003, "Rat tail", 1));
            _standardGameItems.Add(new GameItem(9004, "Rat fur", 2));
            _standardGameItems.Add(new GameItem(9005, "Spider fang", 1));
            _standardGameItems.Add(new GameItem(9006, "Spider silk", 2));
        }

        //pass in item ID (from the list above) to create the item 
        //looks through _standardGameItems list to find "FirstOrDefault" (using LINQ) item matching the itemTypeID you passed in
        public static GameItem CreateGameItem(int itemTypeID)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);

            if(standardItem != null)
            {
                return standardItem.Clone();
            }

            return null;
        }
    }
}
