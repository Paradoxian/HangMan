using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HangmanWindows
{

    public class HangmanWords
    {
        public List<string> Words;
        private string inputFileLine;


        public HangmanWords(string FileLocation)
        { 
        
            Words = new List<string>();
            StreamReader inputFile = new StreamReader(FileLocation);
            try
            {
                while ((inputFileLine = inputFile.ReadLine()) != null)
                {
                    Words.Add(inputFileLine);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static char[] WinningWord { get; set; }
        public static string PlayWord { get; set; }
        public string SelectAWord()
        {
            int maxIndex = Words.Count;
            int selectedIndex;
            int wordLength;

            Random RandomWordIndex = new Random();
            selectedIndex = RandomWordIndex.Next(0, maxIndex);
            PlayWord = Words.ElementAt(selectedIndex).ToUpper();
            wordLength = PlayWord.Count();
            WinningWord = PlayWord.ToUpper().ToCharArray();

            for (int i = 0; i < wordLength; i++)
            {
                WinningWord[i] = '_';
            }
            return PlayWord;
        }  
        
        
        
        
    }
}
