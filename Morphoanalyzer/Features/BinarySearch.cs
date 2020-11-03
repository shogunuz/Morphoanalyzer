using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerationN.Features
{
    public class BinarySearch
    {
        public string Search(string[] array, string variable)
        {
            string key = string.Empty;
            int startIndex = 0, finishIndex = array.Length;
            int midIndex = 0;
            while (startIndex <= finishIndex)
            {
                midIndex = (startIndex + finishIndex) / 2;
                if (array[midIndex].CompareTo(variable) == 0)
                {
                    key = array[midIndex];
                    break;
                }
                else if (array[midIndex].CompareTo(variable) < 0)
                {
                    startIndex = midIndex + 1;
                }
                else
                {
                    finishIndex = midIndex - 1;
                }
            }

            return key;
        }
    }
}
