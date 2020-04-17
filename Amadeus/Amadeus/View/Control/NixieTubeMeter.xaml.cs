using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Amadeus.View.Control
{
    public partial class NixieTubeMeter : UserControl
    {
        private Dictionary<NixieTubeType, Image> _nixieTubeImages;

        public NixieTubeMeter()
        {
            InitializeComponent();

            _nixieTubeImages = new Dictionary<NixieTubeType, Image>{
                [NixieTubeType.zero]  = new Image{ Source = new BitmapImage(new Uri("./Asset/Image/NixieTube/nixie_0")) },
                [NixieTubeType.one]   = new Image{ Source = new BitmapImage(new Uri("./Asset/Image/NixieTube/nixie_1")) },
                [NixieTubeType.two]   = new Image{ Source = new BitmapImage(new Uri("./Asset/Image/NixieTube/nixie_2")) },
                [NixieTubeType.three] = new Image{ Source = new BitmapImage(new Uri("./Asset/Image/NixieTube/nixie_3")) },
                [NixieTubeType.four]  = new Image{ Source = new BitmapImage(new Uri("./Asset/Image/NixieTube/nixie_4")) },
                [NixieTubeType.five]  = new Image{ Source = new BitmapImage(new Uri("./Asset/Image/NixieTube/nixie_5")) },
                [NixieTubeType.six]   = new Image{ Source = new BitmapImage(new Uri("./Asset/Image/NixieTube/nixie_6")) },
                [NixieTubeType.seven] = new Image{ Source = new BitmapImage(new Uri("./Asset/Image/NixieTube/nixie_7")) },
                [NixieTubeType.eight] = new Image{ Source = new BitmapImage(new Uri("./Asset/Image/NixieTube/nixie_8")) },
                [NixieTubeType.nine]  = new Image{ Source = new BitmapImage(new Uri("./Asset/Image/NixieTube/nixie_9")) },
                [NixieTubeType.none]  = new Image{ Source = new BitmapImage(new Uri("./Asset/Image/NixieTube/nixie_none")) },
                [NixieTubeType.dot]   = new Image{ Source = new BitmapImage(new Uri("./Asset/Image/NixieTube/nixie_dot")) },
                [NixieTubeType.plus]  = new Image{ Source = new BitmapImage(new Uri("./Asset/Image/NixieTube/nixie_0")) },
                [NixieTubeType.minus] = new Image{ Source = new BitmapImage(new Uri("./Asset/Image/NixieTube/nixie_0")) },
            };
        }

        public void SetNumber(double param)
        {
            //メーターをリセット
            _meter.Children.OfType<Image>()
                  .ToList()
                  .ForEach((n) =>
                  {
                      n = _nixieTubeImages[NixieTubeType.none];
                  });

            //小数点第一位まで四捨五入し、文字列に置換
            var signStr = param < 0 ? "-" : "+";
            var showStr = signStr + Math.Round(param, 1, MidpointRounding.AwayFromZero);



            showStr.Cast<char>()
                .ToList()
                .ForEach((s) =>
                {
                    switch(s);
                });
            


            var meter = _meter.Children;

            if(param  >= 0)
            {
                meter[0] = _nixieTubeImages[NixieTubeType.plus]; 
            }
            else
            {
                meter[0] = _nixieTubeImages[NixieTubeType.minus];
            }
        }

    }

    public enum NixieTubeType
    {
        zero,
        one,
        two,
        three,
        four,
        five,
        six,
        seven,
        eight,
        nine,
        none,
        dot,
        plus,
        minus
    }
}
