using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace TicTacToeV2
{
    public partial class MainWindow : Window
    {
        char player =  'O';
        char[,] cells = { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)e.Source;

            if (player == 'O')
            {
                player = 'X';
                PlayerMove.Text = "Second player O";
            }
            else
            {
                player = 'O';
                PlayerMove.Text = "First player X";
            }

            switch (button.Name)
            {
                case "First_Button":
                    First_Button.Content = player;
                    First_Button.IsEnabled = false;
                    cells[0, 0] = player;
                    break;
                case "Second_Button":
                    Second_Button.Content = player;
                    Second_Button.IsEnabled = false;
                    cells[0, 1] = player;
                    break;
                case "Third_Button":
                    Third_Button.Content = player;
                    Third_Button.IsEnabled = false;
                    cells[0, 2] = player;
                    break;

                case "Fourth_Button":
                    Fourth_Button.Content = player;
                    Fourth_Button.IsEnabled = false;
                    cells[1, 0] = player;
                    break;
                case "Fifth_Button":
                    Fifth_Button.Content = player;
                    Fifth_Button.IsEnabled = false;
                    cells[1, 1] = player;
                    break;
                case "Sixth_Button":
                    Sixth_Button.Content = player;
                    Sixth_Button.IsEnabled = false;
                    cells[1, 2] = player;
                    break;

                case "Seventh_Button":
                    Seventh_Button.Content = player;
                    Seventh_Button.IsEnabled = false;
                    cells[2, 0] = player;
                    break;
                case "Eighth_Button":
                    Eighth_Button.Content = player;
                    Eighth_Button.IsEnabled = false;
                    cells[2, 1] = player;
                    break;
                case "Ninth_Button":
                    Ninth_Button.Content = player;
                    Ninth_Button.IsEnabled = false;
                    cells[2, 2] = player;
                    break;
            }

            Logic();
        }

        private void Logic()
        {
            for (int i = 0; i < 3; i++)
            {
                if (cells[i, 0] == cells[i, 1] && cells[i, 1] == cells[i, 2] && cells[i, 1] != ' ')
                {
                    MessageBox.Show("You Win");
                }

                if (cells[0, i] == cells[1, i] && cells[1, i] == cells[2, i]  && cells[1, i] != ' ')
                {
                    MessageBox.Show("You Win");
                }
            }


            if ((cells[0, 0] == cells[1, 1] && cells[1, 1] == cells[2, 2] && cells[1, 1] != ' ') ||
                (cells[0, 2] == cells[1, 1] && cells[1, 1] == cells[2, 0] && cells[1, 1] != ' '))
            {
                MessageBox.Show("You Win");
            }
        }

        private void Two_players_Click(object sender, RoutedEventArgs e)
        {
            Menu.Visibility = Visibility.Collapsed;
            Game.Visibility = Visibility.Visible;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Menu.Visibility = Visibility.Visible;
            Game.Visibility = Visibility.Collapsed;
        }
    }
}
