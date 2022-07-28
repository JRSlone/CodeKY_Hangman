using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKY_Hangman
{

    public class Words
    {

        public List<String> WordDictionary { get; set; }

        public Words(List<String> allWords)
        {
            WordDictionary = allWords;
        }

        public string GetWord()
        {
            int rand1 = RandomNumber.rand.Next(0, WordDictionary.Count());
            return WordDictionary[rand1];

            
        }
            
    }
    
}
