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
        
        public string Word { get; set; }
        public int Length => Word.Length;

        public char[] Alphabet = new char[] {'A','Ą', 'B', 'C','Ć', 'D', 'E','Ę',
            'F', 'G', 'H', 'I', 'J', 'K', 'L','Ł', 'M', 'N','Ń',
            'O','Ó', 'P', 'Q', 'R', 'S','Ś', 'T', 'U', 'V', 'W',
            'X', 'Y', 'Z','Ź'};

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
    }
}
