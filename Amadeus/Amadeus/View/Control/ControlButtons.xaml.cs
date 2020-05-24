using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Amadeus.View.Control
{
    /// <summary>
    /// ControlButtons.xaml の相互作用ロジック
    /// </summary>
    public partial class ControlButtons : UserControl
    {
        public new MainV Parent { get; set; }

        public ControlButtons()
        {
            InitializeComponent();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Parent._nixieTubeMeter.ShowNumber(new Random().NextDouble() + new Random().Next(3030));
            Parent._textArea._vm.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// シャットダウンボタン押下
        /// </summary>
        private void Shutdown_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        /// <summary>
        /// 画面拡大・縮小ボタンクリック
        /// </summary>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //プロパティ変化＆エフェクト起動
            Parent._vm.IsSubScreen = !Parent._vm.IsSubScreen;
            Parent.SubOpenEffect.OnApplyTemplate();

            //ボタンアイコン変更
            var Icon = ((sender as Button).Content as PackIcon);

            if (Parent._vm.IsSubScreen)
            {//サブ画面Visiable
                Icon.Kind = PackIconKind.ArrowCollapse;
            }
            else
            {//サブ画面Hide
                Icon.Kind = PackIconKind.ArrowExpand;
            }

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
    }
}
