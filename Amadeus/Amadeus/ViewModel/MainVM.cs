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


        ///ニキシー管の画像を管理する配列
        private Image[] _nixieImages;

        //表示用ニキシー管
        private List<Image> _showNixieTube = new List<Image>();
        //public List<Image> ShowNixieTube
        //{
        //    get
        //    {
        //        if(_profit > 0)
        //        {

        //        }






        //        RaisePropertyChanged(nameof(ShowNixieTube));
        //    }
        //}
        //public Image[] NixieImages
        //{
        //    get
        //    {
        //        //利益ならば+
        //        if(Profit > 0)
        //        {
        //            _nixieImages[0] = new 
        //        }
        //    }
        //}


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


            //画像読み込み
            _nixieImages = new Image[]
            {
                new Image{Source = new BitmapImage(new Uri("./Asset/Image/NixieTube/nixie_0", UriKind.Relative))},
                new Image{Source = new BitmapImage(new Uri("./Asset/Image/NixieTube/nixie_1", UriKind.Relative))},
                new Image{Source = new BitmapImage(new Uri("./Asset/Image/NixieTube/nixie_2", UriKind.Relative))},
                new Image{Source = new BitmapImage(new Uri("./Asset/Image/NixieTube/nixie_3", UriKind.Relative))},
                new Image{Source = new BitmapImage(new Uri("./Asset/Image/NixieTube/nixie_4", UriKind.Relative))},
                new Image{Source = new BitmapImage(new Uri("./Asset/Image/NixieTube/nixie_5", UriKind.Relative))},
                new Image{Source = new BitmapImage(new Uri("./Asset/Image/NixieTube/nixie_6", UriKind.Relative))},
                new Image{Source = new BitmapImage(new Uri("./Asset/Image/NixieTube/nixie_7", UriKind.Relative))},
                new Image{Source = new BitmapImage(new Uri("./Asset/Image/NixieTube/nixie_8", UriKind.Relative))},
                new Image{Source = new BitmapImage(new Uri("./Asset/Image/NixieTube/nixie_9", UriKind.Relative))},
                new Image{Source = new BitmapImage(new Uri("./Asset/Image/NixieTube/nixie_dot", UriKind.Relative))},
                new Image{Source = new BitmapImage(new Uri("./Asset/Image/NixieTube/nixie_none", UriKind.Relative))},
            };
        }


        //private List<Image> CreateNixieTube(double profit)
        //{
        //    var nixieTube = new List<Image>();

        //    //利益が出ているのならばプラス
        //    if(profit > 0)
        //    {
        //        nixieTube
        //    }
        //}
    }
}
