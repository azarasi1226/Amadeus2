﻿using System;
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


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
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
    }
}