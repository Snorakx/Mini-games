using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HangmanLib;

namespace UnitTestHangmanLib
{
    [TestClass]
    public class UnitTestHangmanLib
    {
        [DataTestMethod]
        [DataRow("banan", 5)]
        [DataRow("truskawka", 9)]
        [DataRow("poduszka", 8)]
        public void TestConstructor(string word, int expectedLength)
        {
            Game newGame = new Game(word);
            Assert.AreEqual(newGame.Word, word);
            Assert.AreEqual(newGame.Length, expectedLength);
            Assert.AreEqual(newGame.Points, 0);
            Assert.AreEqual(newGame.Stage, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructor1()
        {
            Game newGame = new Game("a"); 
        }

        [TestMethod]
        public void TestCheckLetter()
        {
            Game newGame = new Game("karma");
            int[] expectedTemp = { 0, 1, 0, 0, 1 };
            int[] temp = newGame.CheckLetter('A');
            for(int i = 0; i < temp.Length; i++)
            {
                Assert.AreEqual(temp[i], expectedTemp[i]);
            }
        }

        [DataTestMethod]
        [DataRow("AFRODYTA", "afrodyta", true)]
        [DataRow("MUMINEK", "kameleon", false)]
        [DataRow("LEŻAK", "leżak", true)]
        public void TestGuess(string guessedWord, string realWord, bool expectedBool)
        {
            Game newGame = new Game(realWord);
            Assert.AreEqual(newGame.Guess(guessedWord), expectedBool);
        }

        [DataTestMethod]
        [DataRow(1, false)]
        [DataRow(12, true)]
        [DataRow(3, false)]
        public void TestIsGameOver(int stage, bool expectedBool)
        {
            Game newGame = new Game("kolka");
            newGame.Stage = stage;
            Assert.AreEqual(newGame.IsGameOver(), expectedBool);
        }
    }
}
