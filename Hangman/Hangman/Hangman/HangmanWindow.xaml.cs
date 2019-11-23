using System;
using System.Collections.Generic;
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

namespace Hangman
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class HangmanWindow : Window
    {
        private List<Label> Labels { get; set; }
        private string placeholderGuess = "Guess the word";
        private string placeholderLetter = "Letter";

        public HangmanWindow()
        {
            InitializeComponent();
            Labels = new List<Label>();
            CreateLabel(6);
        }
        private void CreateLabel(int lenght)
        {
            for (int i = 0; i < lenght; i++)
            {
                Label label = new Label();
                label.FontSize = 20;
                label.FontWeight = FontWeight;
                label.HorizontalContentAlignment = HorizontalAlignment.Center;
                label.VerticalContentAlignment = VerticalAlignment.Center;
                label.BorderThickness = new Thickness(1, 1, 1, 1);
                label.BorderBrush = new SolidColorBrush(Color.FromArgb(0xFF, 0x2D, 0x2D, 0x30));
                label.Height = label.Width = 38;
                label.HorizontalAlignment = HorizontalAlignment.Left;
                label.VerticalAlignment = VerticalAlignment.Top;

                label.Name = "Character" + i.ToString();

                label.Margin = new Thickness(i * label.Width, 0d, 0d, 0d);

                Labels.Add(label);

                LabelWord.Children.Add(label);
            }
        }

        private void GuessWord_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
       
        
        //placeholdery bardzo fajne Panie Molenda
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
        /***********************/

    }
    }

