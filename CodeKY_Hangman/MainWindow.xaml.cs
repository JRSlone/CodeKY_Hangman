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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CodeKY_Hangman
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[] alphaButtons = new Button[26];
        char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        int clickedButton;
        List<char> guessedLetters = new List<char>();
        List<char> wordLetters = new List<char>(); 
        List<String> wordDictionary = new List<string> { "sophie", "pyrus", "gallick", "remnant", "liru", "storm", "morgan", "ash", "tasha" };

        

        public MainWindow()
        {
            InitializeComponent();

            alphaButtons[0] = AKey;
            alphaButtons[1] = BKey;
            alphaButtons[2] = CKey;
            alphaButtons[3] = DKey;
            alphaButtons[4] = EKey;
            alphaButtons[5] = FKey;
            alphaButtons[6] = GKey;
            alphaButtons[7] = HKey;
            alphaButtons[8] = IKey;
            alphaButtons[9] = JKey;
            alphaButtons[10] = KKey;
            alphaButtons[11] = LKey;
            alphaButtons[12] = MKey;
            alphaButtons[13] = NKey;
            alphaButtons[14] = OKey;
            alphaButtons[15] = PKey;
            alphaButtons[16] = QKey;
            alphaButtons[17] = RKey;
            alphaButtons[18] = SKey;
            alphaButtons[19] = TKey;
            alphaButtons[20] = UKey;
            alphaButtons[21] = VKey;
            alphaButtons[22] = WKey;
            alphaButtons[23] = XKey;
            alphaButtons[24] = YKey;
            alphaButtons[25] = ZKey;

            setWord();
        }

        public void setWord()
        {
            int rand1 = RandomNumber.rand.Next(0, wordDictionary.Count());
            string randomWord = wordDictionary[rand1];

            wordLetters.AddRange(randomWord);

            foreach (char letter in wordLetters)
            {
                int i = 0;
                if (i < wordLetters.Count() - 1)
                {
                    wordDisplayTB.Text += $"{letter} ";
                    i++;
                }
            }

            //for (int i = 0; i < wordLetters.Count(); i++)
            //{
            //    wordDisplayTB.Text += randomWord;
            //}
        }

        public void buttonClick()
        {
            alphaButtons[clickedButton].Visibility = Visibility.Hidden;

            guessedLetters.Add(alphabet[clickedButton]);
            usedLettersLB.Items.Clear();
            for (int i = 0; i < guessedLetters.Count(); i++)
            {
                usedLettersLB.Items.Add(guessedLetters[i]);
            }
        }

        private void AKey_Click(object sender, RoutedEventArgs e)
        {
            clickedButton = 0;
            buttonClick();
        }

        private void BKey_Click(object sender, RoutedEventArgs e)
        {
            clickedButton = 1;
            buttonClick();
        }

        private void CKey_Click(object sender, RoutedEventArgs e)
        {
            clickedButton = 2;
            buttonClick();
        }

        private void DKey_Click(object sender, RoutedEventArgs e)
        {
            clickedButton = 3;
            buttonClick();
        }

        private void EKey_Click(object sender, RoutedEventArgs e)
        {
            clickedButton = 4;
            buttonClick();
        }

        private void FKey_Click(object sender, RoutedEventArgs e)
        {
            clickedButton = 5;
            buttonClick();
        }

        private void GKey_Click(object sender, RoutedEventArgs e)
        {
            clickedButton = 6;
            buttonClick();
        }

        private void HKey_Click(object sender, RoutedEventArgs e)
        {
            clickedButton = 7;
            buttonClick();
        }

        private void IKey_Click(object sender, RoutedEventArgs e)
        {
            clickedButton = 8;
            buttonClick();
        }

        private void JKey_Click(object sender, RoutedEventArgs e)
        {
            clickedButton = 9;
            buttonClick();
        }

        private void KKey_Click(object sender, RoutedEventArgs e)
        {
            clickedButton = 10;
            buttonClick();
        }

        private void LKey_Click(object sender, RoutedEventArgs e)
        {
            clickedButton = 11;
            buttonClick();
        }

        private void MKey_Click(object sender, RoutedEventArgs e)
        {
            clickedButton = 12;
            buttonClick();
        }

        private void NKey_Click(object sender, RoutedEventArgs e)
        {
            clickedButton = 13;
            buttonClick();
        }

        private void OKey_Click(object sender, RoutedEventArgs e)
        {
            clickedButton = 14;
            buttonClick();
        }

        private void PKey_Click(object sender, RoutedEventArgs e)
        {
            clickedButton = 15;
            buttonClick();
        }

        private void QKey_Click(object sender, RoutedEventArgs e)
        {
            clickedButton = 16;
            buttonClick();
        }

        private void RKey_Click(object sender, RoutedEventArgs e)
        {
            clickedButton = 17;
            buttonClick();
        }

        private void SKey_Click(object sender, RoutedEventArgs e)
        {
            clickedButton = 18;
            buttonClick();
        }

        private void TKey_Click(object sender, RoutedEventArgs e)
        {
            clickedButton = 19;
            buttonClick();
        }

        private void UKey_Click(object sender, RoutedEventArgs e)
        {
            clickedButton = 20;
            buttonClick();
        }

        private void VKey_Click(object sender, RoutedEventArgs e)
        {
            clickedButton = 21;
            buttonClick();
        }

        private void WKey_Click(object sender, RoutedEventArgs e)
        {
            clickedButton = 22;
            buttonClick();
        }

        private void XKey_Click(object sender, RoutedEventArgs e)
        {
            clickedButton = 23;
            buttonClick();
        }

        private void YKey_Click(object sender, RoutedEventArgs e)
        {
            clickedButton = 24;
            buttonClick();
        }

        private void ZKey_Click(object sender, RoutedEventArgs e)
        {
            clickedButton = 25;
            buttonClick();
        }
    }
}
