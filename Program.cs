using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagram
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string str = "cars are very cool so are arcs looc my os";

            string[] words = str.Split(' ');
           
            int count = 0;

            List<KeyValuePair<string,string>> wordPair =   new List<KeyValuePair<string,string>>();

            for(int i = 0; i < words.Length; i++)
                for(int j = i + 1; j < words.Length; j++)
                    wordPair.Add(new KeyValuePair<string, string>(words[i],words[j]));
            
            foreach(var word in wordPair)
            {
                //Console.WriteLine(word.Key + ' ' + word.Value);
                if(AreAnagram(word.Key,word.Value))
                    count++;
            }
            
            Console.WriteLine(count);

        }

        public static bool AreAnagram(string word1, string word2){
            
            if(word1.Length!=word2.Length)
                return false;

            if(word1 == word2)
                return false;

            if(string.Concat(word1.OrderBy(c=>c)) == string.Concat(word2.OrderBy(c=>c)))
            {
                return true;
            }

            return false;
        }
    }
}
