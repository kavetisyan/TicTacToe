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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int clickCount = 0;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Content == "") 
            {
                if (clickCount % 2 == 0)
                {
                    btn.Content = "X";
                    clickCount++;
                    if (clickCount >= 5) CheckTheWinner(btn.Content.ToString());
                }
                else
                {
                    btn.Content = "O";
                    clickCount++;
                    if (clickCount >= 6) CheckTheWinner(btn.Content.ToString());
                }
            }
            
        }

        private void CheckTheWinner(string s)
        {
            if ((b1.Content.ToString() == s && b2.Content.ToString() == s && b3.Content.ToString() == s) ||
                (b4.Content.ToString() == s && b5.Content.ToString() == s && b6.Content.ToString() == s) ||
                (b7.Content.ToString() == s && b8.Content.ToString() == s && b9.Content.ToString() == s) ||
                (b1.Content.ToString() == s && b4.Content.ToString() == s && b7.Content.ToString() == s) ||
                (b2.Content.ToString() == s && b5.Content.ToString() == s && b8.Content.ToString() == s) ||
                (b3.Content.ToString() == s && b6.Content.ToString() == s && b9.Content.ToString() == s) ||
                (b1.Content.ToString() == s && b5.Content.ToString() == s && b9.Content.ToString() == s) ||
                (b3.Content.ToString() == s && b5.Content.ToString() == s && b7.Content.ToString() == s) )
            {
                MessageBox.Show(s + " Wins!!");
                this.Close();
            }
            else if (clickCount == 9)
            {
                MessageBox.Show("Draw!!");
                this.Close();
            }
        }
    }
}
