using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
 * Author: N. Abdurakhmonova, 
 * Assistant: D.Mengliev
 * Year: 2020
 * Description: This class implements binary search for strings.
 * Описание: этот класс реализует двоичный поиск строк.
 */


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
