using System;
using System.Collections.Generic;

//SAFIU WAHEED
// 206454
//COMPUTER SCIENCE

namespace LetterCounter
{
    class CountLetter
    {

        static public int Counter(string test_string, string search_word)
        {
            //splitting the test_string into character 
            char[] split_test_string = test_string.ToCharArray();

            //initializing dictionary to pack the splitted character
            Dictionary<string, int> word_count = new Dictionary<string, int>();

            //packing the character and occurence to the dictionary
            foreach (var item in split_test_string)
            {
                if (word_count.ContainsKey(item.ToString()))
                    word_count[item.ToString()] += 1;
                else word_count.Add(item.ToString(), 1);
            }
           
            return word_count[search_word];
        }
        static void Main(string[] args)
        {
            string test_string = "abracadabra";
            string search_word = "a";

            int occurence = Counter(test_string, search_word);
            Console.Write("The number of {0} in {1} is {2}", search_word, test_string, occurence);
        }
    }
}
