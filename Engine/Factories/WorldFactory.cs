using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;
using System.Linq;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(-2, -1, "Farmer's Field", "It's a field yo", "/Engine;component/Images/Locations/Home.png");

            newWorld.AddLocation(-1, -1, "Farmer's House", "It looks like some farmer's house", "/Engine;component/Images/Locations/Home.png");

            newWorld.AddLocation(0, -1, "Home", "This is your house", "/Engine;component/Images/Locations/Home.png");

            newWorld.AddLocation(-1, 0, "Trading Shop", "It's a trading shop", "/Engine;component/Images/Locations/Home.png");

            newWorld.AddLocation(0, 0, "Town Square", "It's the town square", "/Engine;component/Images/Locations/Home.png");

            newWorld.AddLocation(1, 0, "Town Gate", "It's a gate bro", "/Engine;component/Images/Locations/Home.png");

            newWorld.AddLocation(2, 0, "Spider Forest", "Oooh scary", "/Engine;component/Images/Locations/Home.png");

            newWorld.AddLocation(0, 1, "Herbalist Hut", "It's a crappy house with plants", "/Engine;component/Images/Locations/Home.png");

            newWorld.LocationAt(0, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));

            newWorld.AddLocation(0, 2, "Herbalist Garden", "So this is where the plants came from", "/Engine;component/Images/Locations/Home.png");

            return newWorld;
        }
    }
}
