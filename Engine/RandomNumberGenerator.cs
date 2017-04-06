using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class RandomNumberGenerator
    {
        private static readonly RNGCryptoServiceProvider _generator =
            new RNGCryptoServiceProvider();

        public static int NumberBetween(int minimumValue, int maximumValue)
        {
            byte[] randomNumber = new byte[1];

            _generator.GetBytes(randomNumber);

            double asciiValueOFRandomCharacter = Convert.ToDouble(randomNumber[0]);

            // To deal with rounding issues.
            double multiplier = Math.Max(0, (asciiValueOFRandomCharacter / 255) - 0.00000000001d);

            int range = maximumValue - minimumValue + 1;

            double randomValueInRange = Math.Floor(multiplier * range);

            return (int)(minimumValue + randomValueInRange);
        }
    }
}
