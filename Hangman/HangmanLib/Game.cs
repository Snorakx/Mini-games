using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;




namespace HangmanLib
{
    public class Game
    {
        public string Word { get;}
        public int Length { get;}
        public int Stage { get; set; }
        public int Points { get; set; }

        public char[] Alphabet = new char[] {'A','Ą', 'B', 'C','Ć', 'D', 'E','Ę',
            'F', 'G', 'H', 'I', 'J', 'K', 'L','Ł', 'M', 'N','Ń',
            'O','Ó', 'P', 'Q', 'R', 'S','Ś', 'T', 'U', 'V', 'W',
            'X', 'Y', 'Z','Ź', 'Ż'};

        public Game(string word)
        {
            if (word.Length <= 1)
                throw new ArgumentException();
            Word = word;
            Length = Word.Length; 
            Stage = 1;
            Points = 0;
        }
        /// <summary>
        /// Funkcja CheckLetter sprawdza czy w wylosowanym słowie znajduje się litera, którą wpisał gracza
        /// /// </summary>
        /// <param name="letter">Litera</param>
        /// <returns></returns>
        public int[] CheckLetter(char letter)
        {
            int[] temp = new int[Length];

            for(int i = 0; i<Length; i++)
            {
                if (Word.ToUpper()[i] == letter)
                {
                    temp[i] = 1;
                }
                else
                {
                    temp[i] = 0;
                }
            }
            return temp;
        }
        /// <summary>
        /// Funkcja Guess sprawdza czy wylosowane słowo jest takie same jak słowo wpisane przez gracza 
        /// </summary>
        /// <param name="guessedWord">Słowo wpisane przez gracza</param>
        /// <returns></returns>
        public bool Guess(string guessedWord)
        {
            if (guessedWord == Word.ToUpper())
                return true;
            return false;
        }
        /// <summary>
        /// Funkcja sprawdza czy gracz przekroczył liczbę 10 prób
        /// </summary>
        /// <returns>Jeśli gracz przekroczył liczbę prób zwracana jest wartość true, jeśli nie false</returns>
        public bool IsGameOver()
        {
            if (Stage <= 10)
                return false;
            return true;
        }
    }
}
