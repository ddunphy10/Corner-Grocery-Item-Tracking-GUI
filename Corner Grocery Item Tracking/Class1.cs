using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Corner_Grocery_Item_Tracking
{
    class Class1
    {
        public static string[] LoadData()
        {
            string filePath = "D:\\Dayton\\Personal Projects\\C# Projects\\Corner Grocery Item Tracking\\TextFile.txt";
            // Check if the file exists before reading it
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                for(int i = 0; i < lines.Length; i++)
                {
                    lines[i] = lines[i].ToLower();
                }
                return lines;
            }
            else
            {
                string[] noLines = new string[] { "This file does not exist!" };
                return noLines;
            }
        }
        public static Dictionary<string, int> CountItems()
        {
            string[] items = LoadData();
            Dictionary<string, int> itemCounts = new Dictionary<string, int>();

            foreach (string item in items)
            {
                if (itemCounts.ContainsKey(item))
                {
                    // Increment the count if the item already exists in the dictionary
                    itemCounts[item]++;
                }
                else
                {
                    // Add the item to the dictionary with a count of 1
                    itemCounts[item] = 1;
                }
            }

            return itemCounts;
        }

        public static string DictionaryToString(Dictionary<string, int> dictionary)
        {
            string result = "";
            foreach (KeyValuePair<string, int> item in dictionary)
            {
                result += $"{item.Key}: {item.Value}\n";
            }
            return result.Trim();
        }

        public static string SaleCount(string item)
        {
            Dictionary<string, int> dict = CountItems();
            if (dict.ContainsKey(item))
            {
                int value = dict[item];
                return $"There were a total of {value.ToString()} {item} sold today.";
            }
            else
            {
                return "This item was not sold today.";
            }
        }

        public static int GetLongestStringLength(string[] array)
        {
            int maxLength = 0;

            foreach (string item in array)
            {
                int length = item.Length;
                if (length > maxLength)
                {
                    maxLength = length;
                }
            }

            return maxLength;
        }

        public static string DictionaryToHistString(Dictionary<string, int> dictionary)
        {
            int longestItem = GetLongestStringLength(LoadData());
            string result = "";
            foreach (KeyValuePair<string, int> item in dictionary)
            {
                int currWordLength = item.Key.Length; 
                result += $"{item.Key}:\n{SpacesNeeded(longestItem, currWordLength)}\n";
            }
            return result.Trim();
        }

        public static string SpacesNeeded(int longestWord, int currentWordLength)
        {
            
            int diffInLength = longestWord - currentWordLength;
            int startPrint = diffInLength + 3;

            //startPrint = startPrint - currentWordLength;
            string spaces = "*";
            for(int i = 0; i < startPrint; ++i)
            {
                spaces += "*";

            }
            return spaces;

        }
    }
}
