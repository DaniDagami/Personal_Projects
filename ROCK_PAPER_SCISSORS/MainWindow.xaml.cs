using System;
using System.Windows;
using System.Windows.Input;

namespace ROCK_PAPER_SCISSORS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, Engine
    {
        private Random random = new Random();
        private string computer;
        private static bool gameEnd = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ROCK_Click(object sender, RoutedEventArgs e)
        {
            Run("ROCK");
        }

        private void PAPER_Click(object sender, RoutedEventArgs e)
        {
            Run("PAPER");
        }

        private void SCISSORS_Click(object sender, RoutedEventArgs e)
        {
            Run("SCISSORS");
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!gameEnd)
            {
                Reset();
            }
        }

        /// <summary>
        /// Run the game
        /// </summary>
        /// <param name="player"></param>
        public void Run(string player)
        {
            #region Computer_Choise

            switch (random.Next(1, 7))
            {
                #region Rock

                case 1:
                    computer = "ROCK";
                    cROCK.Visibility = Visibility.Visible;
                    cPAPER.Visibility = Visibility.Hidden;
                    cSCISSORS.Visibility = Visibility.Hidden;
                    break;

                case 4:
                    computer = "ROCK";
                    cROCK.Visibility = Visibility.Visible;
                    cPAPER.Visibility = Visibility.Hidden;
                    cSCISSORS.Visibility = Visibility.Hidden;
                    break;

                #endregion Rock

                #region Paper

                case 2:
                    computer = "PAPER";
                    cPAPER.Visibility = Visibility.Visible;
                    cROCK.Visibility = Visibility.Hidden;
                    cSCISSORS.Visibility = Visibility.Hidden;
                    break;

                case 5:
                    computer = "PAPER";
                    cPAPER.Visibility = Visibility.Visible;
                    cROCK.Visibility = Visibility.Hidden;
                    cSCISSORS.Visibility = Visibility.Hidden;
                    break;

                #endregion Paper

                #region Scissors

                case 3:
                    computer = "SCISSORS";
                    cSCISSORS.Visibility = Visibility.Visible;
                    cPAPER.Visibility = Visibility.Hidden;
                    cROCK.Visibility = Visibility.Hidden;
                    break;

                case 6:
                    computer = "SCISSORS";
                    cSCISSORS.Visibility = Visibility.Visible;
                    cPAPER.Visibility = Visibility.Hidden;
                    cROCK.Visibility = Visibility.Hidden;
                    break;

                    #endregion Scissors
            }

            #endregion Computer_Choise

            #region Player_Choise

            switch (player)
            {
                #region Rock

                case "ROCK":
                    ROCK.Visibility = Visibility.Visible;
                    PAPER.Visibility = Visibility.Hidden;
                    SCISSORS.Visibility = Visibility.Hidden;
                    if (computer == "ROCK")
                    {
                        VS.Content = "DRAW";
                    }
                    if (computer == "PAPER")
                    {
                        VS.Content = "YOU LOST";
                    }
                    if (computer == "SCISSORS")
                    {
                        VS.Content = "YOU WON";
                    }
                    break;

                #endregion Rock

                #region Paper

                case "PAPER":
                    ROCK.Visibility = Visibility.Hidden;
                    PAPER.Visibility = Visibility.Visible;
                    SCISSORS.Visibility = Visibility.Hidden;

                    if (computer == "ROCK")
                    {
                        VS.Content = "YOU WON";
                    }
                    if (computer == "PAPER")
                    {
                        VS.Content = "DRAW";
                    }
                    if (computer == "SCISSORS")
                    {
                        VS.Content = "YOU LOST";
                    }
                    break;

                #endregion Paper

                #region Scissors

                case "SCISSORS":
                    ROCK.Visibility = Visibility.Hidden;
                    PAPER.Visibility = Visibility.Hidden;
                    SCISSORS.Visibility = Visibility.Visible;

                    if (computer == "ROCK")
                    {
                        VS.Content = "YOU LOST";
                    }
                    if (computer == "PAPER")
                    {
                        VS.Content = "YOU WON";
                    }
                    if (computer == "SCISSORS")
                    {
                        VS.Content = "DRAW";
                    }
                    break;

                    #endregion Scissors
            }

            #endregion Player_Choise

            player = "";
            computer = "";
            gameEnd = false;
        }

        private void Reset()
        {
            ROCK.Visibility = Visibility.Visible;
            PAPER.Visibility = Visibility.Visible;
            SCISSORS.Visibility = Visibility.Visible;
            cROCK.Visibility = Visibility.Visible;
            cPAPER.Visibility = Visibility.Visible;
            cSCISSORS.Visibility = Visibility.Visible;
            VS.Content = "VS";
        }
    }
}