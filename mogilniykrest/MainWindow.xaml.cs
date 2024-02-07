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

namespace mogilniykrest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
    Button[] buttons;
        bool winX = false;
        bool winO = false;
        public MainWindow()
        {
            InitializeComponent();
            buttons = new Button[9] {_1,_2,_3,_4,_5,_6,_7,_8,_9};
        }


        private void _9_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "X";
            (sender as Button).IsEnabled = false;

            Random random = new Random();
            int nomer = random.Next(0, 9);
            int lol = 0;
            for (int i = 0; i < 9; i++)
            {
                if (buttons[i].IsEnabled == false)
                {
                    lol++;
                };

            }
            if (buttons[0].Content == "X" && buttons[1].Content == "X" && buttons[2].Content == "X")
            {
                winX = true;
            }
            if (buttons[3].Content == "X" && buttons[4].Content == "X" && buttons[5].Content == "X")
            {
                winX = true;
            }
            if (buttons[6].Content == "X" && buttons[7].Content == "X" && buttons[8].Content == "X")
            {
                winX = true;
            }

            if (buttons[0].Content == "X" && buttons[3].Content == "X" && buttons[6].Content == "X")
            {
                winX = true;
            }
            if (buttons[1].Content == "X" && buttons[4].Content == "X" && buttons[7].Content == "X")
            {
                winX = true;
            }
            if (buttons[2].Content == "X" && buttons[5].Content == "X" && buttons[8].Content == "X")
            {
                winX = true;
            }
            if (buttons[0].Content == "X" && buttons[4].Content == "X" && buttons[8].Content == "X")
            {
                winX = true;
            }
            if (buttons[2].Content == "X" && buttons[4].Content == "X" && buttons[6].Content == "X")
            {
                winX = true;
            }


            if (buttons[0].Content == "O" && buttons[1].Content == "O" && buttons[2].Content == "O")
            {
                winO = true;
            }
            if (buttons[3].Content == "O" && buttons[4].Content == "O" && buttons[5].Content == "O")
            {
                winO = true;
            }
            if (buttons[6].Content == "O" && buttons[7].Content == "O" && buttons[8].Content == "O")
            {
                winO = true;
            }

            if (buttons[0].Content == "O" && buttons[3].Content == "O" && buttons[6].Content == "O")
            {
                winO = true;
            }
            if (buttons[1].Content == "O" && buttons[4].Content == "O" && buttons[7].Content == "O")
            {
                winO = true;
            }
            if (buttons[2].Content == "O" && buttons[5].Content == "O" && buttons[8].Content == "O")
            {
                winO = true;
            }
            if (buttons[0].Content == "O" && buttons[4].Content == "O" && buttons[8].Content == "O")
            {
                winO = true;
            }
            if (buttons[2].Content == "O" && buttons[4].Content == "O" && buttons[6].Content == "O")
            {
                winO = true;
            }
            if (lol < 9)
            {
            while (buttons[nomer].IsEnabled == false)
            {
                nomer = random.Next(0, 9);
            }
            buttons[nomer].Content = "O";
            buttons[nomer].IsEnabled = false;

            }
            else
            {
                Ibragim.Text = "ничья";
            }
                if(winX == true) 
                {
                    Ibragim.Text = "победил Х";
                }
                else if(winO == true) {
                    Ibragim.Text = "победил O";
                }
            
            
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            Ibragim.Text = "";
            winO = false;
            winX = false;
            for (int i = 0; i < 9; i++)
            {
                buttons[i].Content = "";
                buttons[i].IsEnabled = true;
            }
        }
    }
}
