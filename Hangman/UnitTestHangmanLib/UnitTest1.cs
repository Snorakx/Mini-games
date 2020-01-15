using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HangmanLib;

namespace UnitTestHangmanLib
{
    [TestClass]
    public class UnitTestHangmanLib
    {
        [TestMethod]
        public void TestCheckLetter()
        {
            Game newGame = new Game();
            newGame.Word = "kameleon";
            newGame.CheckLetter('a');
        }

        [DataTestMethod]
        [DataRow("AFRODYTA", "afrodyta", true)]
        [DataRow("MUMINEK", "kameleon", false)]
        [DataRow("LEŻAK", "leżak", true)]
        public void TestGuess(string guessedWord, string realWord, bool expectedBool)
        {
            Game newGame = new Game();
            newGame.Word = realWord;
            Assert.AreEqual(newGame.Guess(guessedWord), expectedBool);
        }

        [DataTestMethod]
        [DataRow(1, false)]
        [DataRow(7, true)]
        [DataRow(3, true)]
        public void TestIsGameOver(string guessedWord, string realWord, bool expectedBool)
        {
            
        }
    }
}
