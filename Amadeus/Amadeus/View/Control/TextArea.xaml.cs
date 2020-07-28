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

namespace Amadeus.View.Control
{
    /// <summary>
    /// TextArea.xaml の相互作用ロジック
    /// </summary>
    public partial class TextArea : UserControl
    {
        public TextArea()
        {
            InitializeComponent();


            _vm.Text = "aaa";
        }

        /// <summary>
        /// テキストセット
        /// </summary>
        /// <param name="text">表示したいテキスト</param>
        public void SetText(string text)
        {
            _vm.Text = text;
        }
    }
}
