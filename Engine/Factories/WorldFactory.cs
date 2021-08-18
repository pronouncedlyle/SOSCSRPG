using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(-2, -1, "Farmer's Field", "It's a field yo", "/Engine;component/Images/Locations/Home.png");

            newWorld.AddLocation(-1, -1, "Farmer's House", "It looks like some farmer's house", "/Engine;component/Images/Locations/Home.png");

            newWorld.AddLocation(0, -1, "Home", "This is your house", "/Engine;component/Images/Locations/Home.png");

            return newWorld;
        }
    }
}
