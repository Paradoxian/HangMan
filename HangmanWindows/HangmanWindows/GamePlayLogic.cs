using System.Linq;

namespace HangmanWindows
{
    public class GamePlayLogic
    {
        
        private const int Lives = 6;
        public int spentLives = 0;
        public bool gameActive = true;
        public bool IsWinner;

        public void CheckUserGuess (char UserInput, string Word)
        {
            string HangManWord = Word;
            char input = UserInput;

            if (HangManWord.Contains(UserInput))
            {
                UpdateWinningWord(UserInput);
            }else if (!(HangManWord.Contains(UserInput)))
            {
                spentLives++;
                
                
            }
        }

        public void GameIsOver()
        {
            if (Lives <= spentLives)
            {
                gameActive = false;
                IsWinner = false;
            }else if ((WordCompare(HangmanWords.PlayWord,HangmanWords.WinningWord)))
            {
                gameActive = false;
                IsWinner = true;
            }
            else
            {
                gameActive = true;
            }
           
        }
        public void UpdateWinningWord(char guessedLetter)
        {
            for (int i = 0; i < HangmanWords.PlayWord.Length; i++)
            {
                if (HangmanWords.PlayWord[i].Equals(guessedLetter))
                {
                    HangmanWords.WinningWord[i] = guessedLetter;
                }
            }
        }

        public bool WordCompare(string word, char[] guessedword)
        {
            for (int i = 0; i < HangmanWords.PlayWord.Length; i++)
            {
                if (!(word[i].Equals(guessedword[i])))
                {
                    return false;
                }

            }
            return true;
        }

    }
}
