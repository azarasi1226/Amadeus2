using System.Collections.ObjectModel;
using System.Windows;

namespace Amadeus.ViewModel
{
    public class MainVM : VMBase
    {
        private double _profit;
        /// <summary>
        /// 損益
        /// </summary>
        public double Profit
        {
            get => _profit;
            set
            {
                _profit = value;
                RaisePropertyChanged(nameof(Profit));
            }
        }

        private bool _isSubScreen;
        /// <summary>
        /// サブ画面フラグ
        /// </summary>
        public bool IsSubScreen
        {
            get => _isSubScreen;
            set
            {
                _isSubScreen = value;
                RaisePropertyChanged(nameof(IsSubScreen));
            }
        }

        /// <summary>
        /// 現在選択されている通貨ペア
        /// </summary>
        public ObservableCollection<string> CurrencyPair { get; set; } =  new ObservableCollection<string>();

        public MainVM()
        {
            IsSubScreen = true;
            CurrencyPair.Add("USDJPY");
            CurrencyPair.Add("EURJPY");
            CurrencyPair.Add("EURJPY");
            CurrencyPair.Add("EURJPY");
            CurrencyPair.Add("EURJPY");
            CurrencyPair.Add("EURJPY");
        }
    }
}
