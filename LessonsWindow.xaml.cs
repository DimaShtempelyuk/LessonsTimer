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

namespace LessonsTimerRealOne
{
    /// <summary>
    /// Interaction logic for LessonsWindow.xaml
    /// </summary>
    public partial class LessonsWindow : Window
    {
        public LessonsWindow()
        {
            InitializeComponent();
        }

        private void TwB_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Do_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DoW_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DoW_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
