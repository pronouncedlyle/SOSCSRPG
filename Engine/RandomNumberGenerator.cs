﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace Engine
{
    public static class RandomNumberGenerator
    {
        private static readonly Random _simpleGenerator = new Random();
        public static int NumberBetween(int minimumValue, int maximumValue)
        {
            return _simpleGenerator.Next(minimumValue, maximumValue + 1);
        }
    }

}




 // cool complex / more random way to do this:
//{
//    private static readonly RNGCryptoServiceProvider _generator = new RNGCryptoServiceProvider();

//    public static int NumberBetween(int minimumValue, int maximumValue)
//    {
//        byte[] randomNumber = new byte[1];

//        _generator.GetBytes(randomNumber);

//        double asciiValueOfRandomCharacter = Convert.ToDouble(randomNumber[0]);

//        //We are using Math.Max, and subtracting 0.00000000001,
//        //to ensure "multiplier will always be between 0.0 and .99999999999
//        //otherwise it's possible for it to be "1", which causes problems in rounding
//        double multiplier = Math.Max(0, (asciiValueOfRandomCharacter / 255d) - 0.00000000001d);

//        //need to add one to the range, to allow for rounding done with Math.Floor
//        int range = maximumValue - minimumValue + 1;

//        double randomValueInRange = Math.Floor(multiplier * range);

//        return (int)(minimumValue + randomValueInRange);
//    }
//}
