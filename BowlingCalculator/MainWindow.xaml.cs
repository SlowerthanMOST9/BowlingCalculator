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

namespace Bowling
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double gameone = 0;
        double gametwo = 0;
        double gamethree = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateBtn_Click(object sender, RoutedEventArgs e)
        {

            Double.TryParse(GameOneScore.Text, out gameone);
            Double.TryParse(GameTwoScore.Text, out gametwo);
            Double.TryParse(GameThreeScore.Text, out gamethree);

            double answer = gameone + gametwo + gamethree;

            double averagegame = (gameone + gametwo + gamethree) / 3;

            double handicap = (200 - averagegame) * .8;

            Series.Text = answer.ToString();
            Average.Text = averagegame.ToString();
            Handicap.Text = handicap.ToString();
        }
        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            GameOneScore.Text = "";
            GameThreeScore.Text = "";
            GameTwoScore.Text = "";
            Series.Text = "";
            Average.Text = "";
            Handicap.Text = "";

        }
    }
}
