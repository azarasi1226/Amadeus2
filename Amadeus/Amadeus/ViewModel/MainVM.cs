using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Amadeus.ViewModel
{
    public class MainVM : VMBase
    {
        /// <summary>
        /// 損益
        /// </summary>
        private double _profit = 0;
        public double Profit { get; set; }


       


        /// <summary>
        /// 現在選択されている通貨ペア
        /// </summary>
        public ObservableCollection<string> CurrencyPair { get; set; } =  new ObservableCollection<string>();

        public MainVM()
        {
            CurrencyPair.Add("USDJPY");
            CurrencyPair.Add("EURJPY");
            CurrencyPair.Add("EURJPY");
            CurrencyPair.Add("EURJPY");
            CurrencyPair.Add("EURJPY");
            CurrencyPair.Add("EURJPY");
        }
    }
}
