using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using HangmanLib;

namespace Hangman
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class HangmanWindow : Window
    {
        private List<Label> LabelsForWord { get; set; }
        private List<Label> LabelsForAlpha { get; set; }

        private string placeholderGuess = "Guess the word";
        private string placeholderLetter = "Letter";
        string oneLetter;
        string guessedWord;
        Game newGame;


        public HangmanWindow()
        {
            InitializeComponent();    
            LabelsForWord = new List<Label>();
            LabelsForAlpha = new List<Label>();
            var wordsFile = File.ReadAllText("words.txt").Split(',');
            var randomWordIndex = new Random().Next(0, wordsFile.Length - 1);
            newGame = new Game(wordsFile[randomWordIndex]);
            

            CreateLabel(newGame.Length, LabelWord);
            CreateLabelForAlph(newGame.Alphabet.Length, lowercaseLetters);
           
        }
        private void CreateLabel(int lenght, Grid grid)
        {
            for (int i = 0; i < lenght; i++)
            {
                Label label = new Label();
                label.FontSize = 20;
                label.FontFamily = new FontFamily("Cooper Black");
                label.Foreground = Brushes.DarkSlateGray;
                label.FontWeight = FontWeight;
                label.HorizontalContentAlignment = HorizontalAlignment.Center;
                label.VerticalContentAlignment = VerticalAlignment.Center;
                label.BorderThickness = new Thickness(2, 2, 2, 2);
                label.BorderBrush = new SolidColorBrush(Color.FromArgb(0xFF, 96, 125, 139));
                label.Height = label.Width = 38;
                label.HorizontalAlignment = HorizontalAlignment.Left;
                label.VerticalAlignment = VerticalAlignment.Top;
                label.Name = "Character" + i.ToString();
                label.Margin = new Thickness(i * label.Width, 0d, 0d, 0d);

                LabelsForWord.Add(label);
                grid.Children.Add(label);
            }
        }
        private void CreateLabelForAlph(int lenght, Grid grid)
        {
            for (int i = 0; i < lenght; i++)
            {
                Label label = new Label();
                label.FontSize = 10;
                label.FontWeight = FontWeight;
                label.FontFamily = new FontFamily("Cooper Black");
                label.Foreground = Brushes.DarkSlateGray;
                label.HorizontalContentAlignment = HorizontalAlignment.Center;
                label.VerticalContentAlignment = VerticalAlignment.Center;
                label.Height = label.Width = 25;
                label.HorizontalAlignment = HorizontalAlignment.Left;
                label.VerticalAlignment = VerticalAlignment.Top;
                label.Name = "Character" + i.ToString();
                label.Margin = new Thickness(i * label.Width, 0d, 0d, 0d);
                label.Content = newGame.Alphabet[i];
                
                LabelsForAlpha.Add(label);
                grid.Children.Add(label);
            }
        }

        private void resetTextboxValue(object sender, MouseButtonEventArgs e)
        {

            if (GuessWord.Text == placeholderGuess)
            {
                GuessWord.Text = "";
                GuessWord.Foreground = Brushes.Black;
            }
            
        }
                       
        private void resetPlaceholder(object sender, RoutedEventArgs e)
        {
            if (GuessWord.Text == "")
            {
                GuessWord.Text = placeholderGuess;
                GuessWord.Foreground = Brushes.Gray;
            }
        }

        private void resetTxtboxValue2(object sender, MouseButtonEventArgs e)
        {
            if(Letter.Text == placeholderLetter)
            {
                Letter.Text = "";
                Letter.Foreground = Brushes.Black;

            }
        }

        private void resetPlaceholderLetter(object sender, RoutedEventArgs e)
        {
            if (Letter.Text == "")
            {
                Letter.Text = placeholderLetter;
                Letter.Foreground = Brushes.Gray;
            }

        }

        private void Button_ClickOneLetter(object sender, RoutedEventArgs e)
        {
            oneLetter = Letter.Text.ToUpper();
            Letter.Text = "";
            if (oneLetter.Length > 1 || oneLetter == "")
                MessageBox.Show("You need to enter one letter", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            else
            {
                int[] temp = newGame.CheckLetter(oneLetter[0]);
                RevealLetters(temp);
            }   
        }

        private void Button_ClickWord(object sender, RoutedEventArgs e)
        {
            guessedWord = GuessWord.Text.ToUpper();
            GuessWord.Text = "";
            if (guessedWord.Length <= 2 || guessedWord == null)
                MessageBox.Show("You need to enter  at least two letters", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            else if (newGame.Guess(guessedWord))
            {
                RevealWord();
                MessageBox.Show("You win!");
                NewWindow();
            }
            else
                WrongGuess();
            
        }
        private void ChangeColorOfLetter(List<Label> labels, string searchedLetter, SolidColorBrush color)
        {
            for (int j = 0; j < labels.Count; j++)
            {
                if (labels[j].Content.ToString() == searchedLetter)
                    labels[j].Background = color;
            }
        }

        private void RevealLetters(int[] tempArray)
        {
            if (tempArray.Contains(1))
            {

                for (int i = 0; i < tempArray.Length; i++)
                {
                    if (tempArray[i] == 1)
                    {
                        LabelsForWord[i].Content = newGame.Word.ToUpper()[i];
                    }
                }
                AddPoint();
                ChangeColorOfLetter(LabelsForAlpha, oneLetter, Brushes.YellowGreen);
                if (LabelsForWord.Count(l => l.Content == null) == 0)
                {
                    MessageBox.Show("You win!");
                    NewWindow();
                }
            }
            else
                WrongGuess();            
        }

        private void RevealWord()
        {
            
            for (int i = 0; i < LabelsForWord.Count; i++)
            {
                LabelsForWord[i].Content = newGame.Word.ToUpper()[i];
            }
        }

        private BitmapImage GetStageImage()
        {
            return new BitmapImage(new Uri(System.IO.Path.Combine(Environment.CurrentDirectory,$"Images/{newGame.Stage}.jpg")));
        }

        private void mainMenuButtonClickFunction(object sender, RoutedEventArgs e)
        {
            NewWindow();
        }

        private void NewWindow()
        {
            HangmanWindow objSecondWindow = new HangmanWindow();
            objSecondWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Close();
            objSecondWindow.Show();
        }

        private void NextStage()
        {
            newGame.Stage++;
            img.Source = GetStageImage();
        }

        private void AddPoint()
        {
            newGame.Points++;
            score.Content = newGame.Points;
            score.FontFamily = new FontFamily("Cooper Black");
            score.Foreground = Brushes.DarkSlateGray;
            score.FontSize = 25;
            score.HorizontalAlignment = HorizontalAlignment.Left;
            score.VerticalAlignment = VerticalAlignment.Top;

        }
        private void WrongGuess()
        {
            if (newGame.IsGameOver())
            {
                NextStage();
                MessageBox.Show("You lose!");
                NewWindow();
            }
            else
            {
                NextStage();
                ChangeColorOfLetter(LabelsForAlpha, oneLetter, Brushes.LightSalmon);
            }
        }

        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            HangmanWindow objSecondWindow = new HangmanWindow();
            objSecondWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Close();
            objSecondWindow.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

