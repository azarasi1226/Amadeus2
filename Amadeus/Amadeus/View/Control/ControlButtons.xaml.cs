using MaterialDesignThemes.Wpf;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace Amadeus.View.Control
{
    public partial class ControlButtons : UserControl
    {
        public new MainV Parent { get; set; }

        public ControlButtons()
        {
            InitializeComponent();
        }

        /// <summary>
        /// スクリーンショットボタン押下
        /// </summary>
        private void Screenshots_Click(object sender, RoutedEventArgs e)
        {
            Parent._textArea.SetText(Controller.NotificationEvent.全通貨決済.ToString());
        }

        /// <summary>
        /// シャットダウンボタン押下
        /// </summary>
        private void Shutdown_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        /// <summary>
        /// 画面拡大・縮小ボタン押下
        /// </summary>
        private void Expand_Click(object sender, RoutedEventArgs e)
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
            using (EventWaitHandle ewh = EventWaitHandle.OpenExisting(Controller.NotificationEvent.全通貨決済.ToString()))
            {

                // イベント通知
                ewh.Set();
            }
        }
    }
}
