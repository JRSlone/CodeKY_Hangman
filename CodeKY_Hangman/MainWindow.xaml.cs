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

/*
-THINGS TO DO
-make the wordDictionary a list from a external source
-add hangman image along with logic to fill in the hangman (done)
-gameover also add a play again to start the thing over
-add a you win if you actually guess
*/

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
        List<char> solvedLetters = new List<char>();
        List<String> wordDictionary = new List<string> { "SOPHIE", "PYRUS", "GALLICK", "REMNANT", "LIRU", "STORM", "MORGAN", "ASH", "TASHA" };

        int amountOfTimesWrong = 0;
        int amountOfTimesRight = 0; //useless atm
        bool correctGuess = false;

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
                hangmanAppear();
        }


        public void setWord()
        {
            int rand1 = RandomNumber.rand.Next(0, wordDictionary.Count());
            string randomWord = wordDictionary[rand1];

            wordLetters.AddRange(randomWord);

            for (int i = 0; i < wordLetters.Count(); i++)
            {
                if (i < wordLetters.Count())
                {
                    solvedLetters.AddRange("_");
                    wordDisplayTB.Text += $"{solvedLetters[i]} ";
                }
            }
        }

        public void checkWord()
        {

            
            for (int i = 0; i < wordLetters.Count(); i++)
            {
                if (wordLetters[i] == alphabet[clickedButton])
                {
                    correctGuess = true;
                    solvedLetters[i] = wordLetters[i];
                    wordDisplayTB.Clear();

                    for (int j = 0; j < wordLetters.Count(); j++)
                    {
                        wordDisplayTB.Text += $"{solvedLetters[j]} ";
                        amountOfTimesRight++;
                    }
                }
            }

            if (correctGuess != true)
            {
                amountOfTimesWrong++;
            }

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
            checkWord();
            hangmanAppear();

            if (amountOfTimesWrong == 5)
            {
                alphaButtons[0].Visibility = Visibility.Hidden;
                alphaButtons[1].Visibility = Visibility.Hidden;
                alphaButtons[2].Visibility = Visibility.Hidden;
                alphaButtons[3].Visibility = Visibility.Hidden;
                alphaButtons[4].Visibility = Visibility.Hidden;
                alphaButtons[5].Visibility = Visibility.Hidden;
                alphaButtons[6].Visibility = Visibility.Hidden;
                alphaButtons[7].Visibility = Visibility.Hidden;
                alphaButtons[8].Visibility = Visibility.Hidden;
                alphaButtons[9].Visibility = Visibility.Hidden;
                alphaButtons[10].Visibility = Visibility.Hidden;
                alphaButtons[11].Visibility = Visibility.Hidden;
                alphaButtons[12].Visibility = Visibility.Hidden;
                alphaButtons[13].Visibility = Visibility.Hidden;
                alphaButtons[14].Visibility = Visibility.Hidden;
                alphaButtons[15].Visibility = Visibility.Hidden;
                alphaButtons[16].Visibility = Visibility.Hidden;
                alphaButtons[17].Visibility = Visibility.Hidden;
                alphaButtons[18].Visibility = Visibility.Hidden;
                alphaButtons[19].Visibility = Visibility.Hidden;
                alphaButtons[20].Visibility = Visibility.Hidden;
                alphaButtons[21].Visibility = Visibility.Hidden;
                alphaButtons[22].Visibility = Visibility.Hidden;
                alphaButtons[23].Visibility = Visibility.Hidden;
                alphaButtons[24].Visibility = Visibility.Hidden;
                alphaButtons[25].Visibility = Visibility.Hidden;
                wordDisplayTB.Clear();
                for (int j = 0; j < wordLetters.Count(); j++)
                {
                    wordDisplayTB.Text += $"{wordLetters[j]} ";
                }
            }

            else if (amountOfTimesWrong < 5 && amountOfTimesRight == wordLetters.Count) //doesnt work
            {
                hangmanImageLB.Items.Add("-------YOU WIN!-------");
                alphaButtons[0].Visibility = Visibility.Hidden;
                alphaButtons[1].Visibility = Visibility.Hidden;
                alphaButtons[2].Visibility = Visibility.Hidden;
                alphaButtons[3].Visibility = Visibility.Hidden;
                alphaButtons[4].Visibility = Visibility.Hidden;
                alphaButtons[5].Visibility = Visibility.Hidden;
                alphaButtons[6].Visibility = Visibility.Hidden;
                alphaButtons[7].Visibility = Visibility.Hidden;
                alphaButtons[8].Visibility = Visibility.Hidden;
                alphaButtons[9].Visibility = Visibility.Hidden;
                alphaButtons[10].Visibility = Visibility.Hidden;
                alphaButtons[11].Visibility = Visibility.Hidden;
                alphaButtons[12].Visibility = Visibility.Hidden;
                alphaButtons[13].Visibility = Visibility.Hidden;
                alphaButtons[14].Visibility = Visibility.Hidden;
                alphaButtons[15].Visibility = Visibility.Hidden;
                alphaButtons[16].Visibility = Visibility.Hidden;
                alphaButtons[17].Visibility = Visibility.Hidden;
                alphaButtons[18].Visibility = Visibility.Hidden;
                alphaButtons[19].Visibility = Visibility.Hidden;
                alphaButtons[20].Visibility = Visibility.Hidden;
                alphaButtons[21].Visibility = Visibility.Hidden;
                alphaButtons[22].Visibility = Visibility.Hidden;
                alphaButtons[23].Visibility = Visibility.Hidden;
                alphaButtons[24].Visibility = Visibility.Hidden;
                alphaButtons[25].Visibility = Visibility.Hidden;
            }
        }

        public void hangmanAppear()
        {
            hangmanImageLB.Items.Clear();
            if (amountOfTimesWrong == 0)
            {
                hangmanImageLB.Items.Add("\n+---+");
                hangmanImageLB.Items.Add("     |");
                hangmanImageLB.Items.Add("     |");
                hangmanImageLB.Items.Add("     |");
                hangmanImageLB.Items.Add("     |");
                hangmanImageLB.Items.Add("    ===");
            }

            else if (amountOfTimesWrong == 1)
            {
                hangmanImageLB.Items.Add("\n+---+");
                hangmanImageLB.Items.Add("0    |");
                hangmanImageLB.Items.Add("     |");
                hangmanImageLB.Items.Add("     |");
                hangmanImageLB.Items.Add("     |");
                hangmanImageLB.Items.Add("    ===");
            }

            else if (amountOfTimesWrong == 2)
            {
                hangmanImageLB.Items.Add("\n+---+");
                hangmanImageLB.Items.Add(" 0    |");
                hangmanImageLB.Items.Add("/|    |");
                hangmanImageLB.Items.Add("      |");
                hangmanImageLB.Items.Add("      |");
                hangmanImageLB.Items.Add("     ===");
            }

            else if (amountOfTimesWrong == 3)
            {
                hangmanImageLB.Items.Add("\n+---+");
                hangmanImageLB.Items.Add(" 0    |");
                hangmanImageLB.Items.Add("/|\\  |");
                hangmanImageLB.Items.Add("      |");
                hangmanImageLB.Items.Add("      |");
                hangmanImageLB.Items.Add("     ===");
            }

            else if (amountOfTimesWrong == 4)
            {
                hangmanImageLB.Items.Add("\n+---+");
                hangmanImageLB.Items.Add(" 0    |");
                hangmanImageLB.Items.Add("/|\\  |");
                hangmanImageLB.Items.Add("/     |");
                hangmanImageLB.Items.Add("      |");
                hangmanImageLB.Items.Add("     ===");
            }

            else if (amountOfTimesWrong == 5)
            {
                hangmanImageLB.Items.Add("\n+---+");
                hangmanImageLB.Items.Add(" 0    |");
                hangmanImageLB.Items.Add("/|\\  |");
                hangmanImageLB.Items.Add("/ \\  |");
                hangmanImageLB.Items.Add("      |");
                hangmanImageLB.Items.Add("     ===");
                hangmanImageLB.Items.Add("-------YOU LOSE!-------");
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
