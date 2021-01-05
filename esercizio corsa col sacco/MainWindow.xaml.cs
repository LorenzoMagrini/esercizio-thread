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
using System.Threading;

namespace esercizio_corsa_col_sacco
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Random r = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        public void muoviConcorrente1()
        {
            int concorrente1 = 195;

            Thread.Sleep(TimeSpan.FromSeconds(0.5));

            while (concorrente1 < 700)
            {
                concorrente1 += 30;

                Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(100, 501)));

                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    imgConcorrente1.Margin = new Thickness(330, concorrente1, 0, 0);
                }));
            }
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                lstClassifica.Items.Add("Gioele (concorrente numero 1)");
            }));
        }

        public void muoviConcorrente2()
        {
            int concorrente2 = 195;

            Thread.Sleep(TimeSpan.FromSeconds(0.5));

            while (concorrente2 < 700)
            {
                concorrente2 += 30;

                Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(100,501)));

                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    imgConcorrente2.Margin = new Thickness(417,concorrente2 , 0, 0);
                }));
            }
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                lstClassifica.Items.Add("Riccardo (concorrente numero 2)");
            }));
        }

        public void muoviConcorrente3()
        {
            int concorrente3 = 195;

            Thread.Sleep(TimeSpan.FromSeconds(0.5));

            while (concorrente3 < 700)
            {
                concorrente3 += 30;

                Thread.Sleep(TimeSpan.FromMilliseconds(r.Next(100, 501)));

                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    imgConcorrente3.Margin = new Thickness(503, concorrente3, 0, 0);
                }));
            }
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                lstClassifica.Items.Add("Filippo (concorrente numero 3)");
            }));
        }

        private void Via_Click(object sender, RoutedEventArgs e)
        {

            lstClassifica.Items.Clear();

            imgConcorrente1.Margin = new Thickness(330, 195, 0, 0);

            imgConcorrente2.Margin = new Thickness(417, 195, 0, 0);

            imgConcorrente3.Margin = new Thickness(503, 195, 0, 0);

            Thread t1 = new Thread(new ThreadStart(muoviConcorrente1));

            t1.Start();

            Thread t2 = new Thread(new ThreadStart(muoviConcorrente2));


            t2.Start();

            Thread t3 = new Thread(new ThreadStart(muoviConcorrente3));

            t3.Start();
        }
    }
}

