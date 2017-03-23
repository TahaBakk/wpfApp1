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
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DispatcherTimer dispatcherTimer;
        DateTimeOffset lastTime;
        DateTimeOffset startTime;


        public MainWindow(){
            InitializeComponent();
            DispatcherTimerSetup();
        }


        public void DispatcherTimerSetup()
        {
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);//actualiza
            startTime = DateTimeOffset.Now;
            lastTime = startTime;
            dispatcherTimer.Start();//inicializar el programa (dispatcher)

        }

        void dispatcherTimer_Tick(object sender, object e)
        {
            string[] horaActual = DateTime.Now.ToString().Split(' ');
            horaText.Text = horaActual[1];

            string[] hhmm = horaActual[1].Split(':');

            if (hora.Equals(hhmm[0]) && minutos.Equals(hhmm[1]))
            {

            }

        }

        private void activarAlarma_Click(object sender, RoutedEventArgs e)
        {
            if (hora.IsEnabled){
                hora.IsEnabled = false;
            }else
                hora.IsEnabled = true;

            if (minutos.IsEnabled){
                minutos.IsEnabled = false;
            }else
                minutos.IsEnabled = true;
        }

        private void ayuda(object sender, RoutedEventArgs e)
        {
            //Meter un popUp para que salga una miniInformacion
        }

        private void salir(object sender, RoutedEventArgs e)
        {
            //Meter popUp que pregunte si desea salir

        }
    }
}
