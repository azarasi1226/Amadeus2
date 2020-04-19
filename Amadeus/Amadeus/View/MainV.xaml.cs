using System;
using System.Threading;
using System.Windows;

namespace Amadeus.View
{
    /// <summary>
    /// MainV.xaml の相互作用ロジック
    /// </summary>
    public partial class MainV : Window
    {
        public MainV()
        {
            InitializeComponent();
            DataContext = new ViewModel.MainVM();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (EventWaitHandle ewh = EventWaitHandle.OpenExisting("test_event_pokemon_go"))
            {

                // イベント通知
                ewh.Set();
            }
        }

        private void BUtton_Click1(object sender, RoutedEventArgs e)
        {
            using (EventWaitHandle ewh = EventWaitHandle.OpenExisting("test_event_pokemon_gogo"))
            {

                // イベント通知
                ewh.Set();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            using (EventWaitHandle ewh = EventWaitHandle.OpenExisting("全通貨決済"))
            {

                // イベント通知
                ewh.Set();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            using (EventWaitHandle ewh = EventWaitHandle.OpenExisting("現通貨決済"))
            {

                // イベント通知
                ewh.Set();
            }
        }

        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }



        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            _nixieTubeMeter.ShowNumber(new Random().NextDouble() + new Random().Next(3030)) ;
        }

        /// <summary>
        /// シャットダウンボタン押下
        /// </summary>
        private void Shutdown_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
