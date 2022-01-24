using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace RTSLabs
{
    public class RTSLabs
    {
        public AboveBelowClass aboveBelow (int[] numbers, int comparisonValue)
        {
            var numBelow = 0;
            var numAbove = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < comparisonValue)
                    numBelow++;
                else if (numbers[i] > comparisonValue)
                    numAbove++;
            }

            var result = new AboveBelowClass();
            result.above = numAbove;
            result.below = numBelow;

            return result;
        }

        public string stringRotation (string str, int rotationAmount)
        {
            var arr = new char[str.Length];

            for (var i = 0; i < str.Length; i++)
            {
                arr[(i + rotationAmount) % str.Length] = str[i];
            }

            return new string(arr);
        }
    }

    public class AboveBelowClass
    {
        public int above { get; set; }
        public int below { get; set; }
    }
}
