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

namespace wpf_guess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        int valueToGuess;
        readonly int minValue = 1;
        readonly int maxValue = 1000;

        public MainWindow()
        {
            InitializeComponent();

            valueToGuess = getNewValue();
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            valueToGuess = getNewValue();
        }



        private int getNewValue() => rnd.Next(minValue, maxValue);

        private void Validate_Click(object sender, RoutedEventArgs e)
        {
            int guess = Convert.ToInt32(txtNumber.Text);

            if (guess == valueToGuess)
            {
                txtMessage.Text = "Bravo! Tu as trouvé. Appuie sur Recommencer pour refaire une partie.";
            } else if (guess < valueToGuess)
            {
                txtMessage.Text = "Trop bas!";
            } else
            {
                txtMessage.Text = "Trop haut!";
            }
        }
    }
}
