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
            _controlButtons.Parent = this;
        }

        /// <summary>
        /// マウスドラッグに対応
        /// </summary>
        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
