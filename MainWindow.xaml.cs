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
using System.Timers;
using System.Media;


using System.Windows.Threading;

namespace LessonsTimerRealOne
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // SoundPlayer player = new SoundPlayer(@"F:\rabochiy stol\Dima\Škola\3. rocnik\PVA\LessonsTimerRealOne\obj\TimerSound.wav");
        SoundPlayer player = new SoundPlayer(LessonsTimerRealOne.Properties.Resources.TimerSound);
        DispatcherTimer t;
        double BaseHr;
        double BaseMin;
        double BaseSec;
        public MainWindow() 
        {
            InitializeComponent();
            StoB.Visibility = Visibility.Hidden;
            PauseB.Visibility = Visibility.Hidden;
            ResumeB.Visibility = Visibility.Hidden;
        }
            
        private void StaB_Click(object sender, RoutedEventArgs e)
        {
            double incrHr = UpDHr.Value;
            double incrMin = UpDMin.Value;
            double incrSec = UpDSec.Value;

            BaseHr = incrHr;
            BaseMin = incrMin;
            BaseSec = incrSec;
            
            t = new DispatcherTimer();
            HrL.Content = incrHr;
            MinL.Content = incrMin;
            SecL.Content = incrSec;
            t.Tick += new EventHandler(t_Tick);
            t.Interval = new TimeSpan(0,0,1);
            t.Start();
            VisibilityBut(false);
        }
        private void t_Tick(object sender, EventArgs e)
        {
            double incrHr = UpDHr.Value;
            double incrMin = UpDMin.Value;
            double incrSec = UpDSec.Value;
            if (incrSec == 0)
            {
                if (incrMin == 0)
                {
                    if (incrHr == 0)
                    {
                        player.Load();
                        player.PlayLooping();
                        MessageBoxResult dr = MessageBox.Show("Yes - Stop, No - Repeat", "Timer!!!", MessageBoxButton.YesNo);
                        if (dr == MessageBoxResult.Yes)
                        {
                            player.Stop();
                            t.Stop();
                            UpDHr.Value = BaseHr;
                            UpDMin.Value = BaseMin;
                            UpDSec.Value = BaseSec;
                            VisibilityBut(true);
                        }
                        else if (dr == MessageBoxResult.No)
                        {
                            player.Stop();
                            t.Stop();
                            UpDHr.Value = BaseHr;
                            UpDMin.Value = BaseMin;
                            UpDSec.Value = BaseSec;
                            HrL.Content = UpDHr.Value;
                            MinL.Content = UpDMin.Value;
                            SecL.Content = UpDSec.Value;
                            t.Start();    //do something else
                        }

                    }
                    else
                    {
                        
                        UpDHr.Value--;
                        incrHr--;
                        UpDMin.Value = 59;
                        UpDSec.Value = 59;
                        incrSec = 59;
                        incrMin = 59;
                        HrL.Content = incrHr;
                        MinL.Content = incrMin;
                        SecL.Content = incrSec;
                    }
                }
                else
                {
                    UpDMin.Value--;
                    incrMin--;
                    UpDSec.Value = 59;
                    incrSec = 59;
                    HrL.Content = incrHr;
                    MinL.Content = incrMin;
                    SecL.Content = incrSec;
                }
            }
            else
            {
                UpDSec.Value--;
                incrSec--;
                HrL.Content = incrHr;
                MinL.Content = incrMin;
                SecL.Content = incrSec;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            t.Stop();
            UpDHr.Value = BaseHr;
            UpDMin.Value = BaseMin;
            UpDSec.Value = BaseSec;
            VisibilityBut(true);
        }

        private void PauseB_Click(object sender, RoutedEventArgs e)
        {
            t.Stop();
            VisibilityBut(false);
            PauseB.Visibility = Visibility.Hidden;
            ResumeB.Visibility = Visibility.Visible;
        }
        private void VisibilityBut(bool x)
        {
            if (x == true)
            {
                HrL.Content = "";
                MinL.Content = "";
                SecL.Content = "";
                UpDHr.Visibility = Visibility.Visible;
                UpDMin.Visibility = Visibility.Visible;
                UpDSec.Visibility = Visibility.Visible;
                StaB.Visibility = Visibility.Visible;
                StoB.Visibility = Visibility.Hidden;
                PauseB.Visibility = Visibility.Hidden;
                ResumeB.Visibility = Visibility.Hidden;
            }
            else
            {
                UpDHr.Visibility = Visibility.Hidden;
                UpDMin.Visibility = Visibility.Hidden;
                UpDSec.Visibility = Visibility.Hidden;
                StaB.Visibility = Visibility.Hidden;
                StoB.Visibility = Visibility.Visible;
                PauseB.Visibility = Visibility.Visible;
                ResumeB.Visibility = Visibility.Hidden;
            }
        }

        private void ResumeB_Click(object sender, RoutedEventArgs e)
        {
            t.Start();
            PauseB.Visibility = Visibility.Visible;
            ResumeB.Visibility = Visibility.Hidden;

        }

        private void LWShow_Click(object sender, RoutedEventArgs e)
        {
            LessonsWindow lw = new LessonsWindow();
            lw.Owner = this;
            lw.ShowDialog();
        }
    }
}
