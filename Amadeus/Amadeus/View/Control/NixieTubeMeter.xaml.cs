using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Amadeus.View.Control
{
    public partial class NixieTubeMeter : UserControl
    {
        /// <summary>
        /// 画像データを保持した辞書
        /// </summary>
        private readonly Dictionary<NixieTubeType, BitmapImage> _nixieTubeImages;
        /// <summary>
        /// ニキシー管配列
        /// </summary>
        private readonly Image[] _nixieTubeIMGs;

        public NixieTubeMeter()
        {
            InitializeComponent();

            _nixieTubeIMGs = new Image[]
{
                _nixieTubeIMG8,
                _nixieTubeIMG7,
                _nixieTubeIMG6,
                _nixieTubeIMG5,
                _nixieTubeIMG4,
                _nixieTubeIMG3,
                _nixieTubeIMG2,
                _nixieTubeIMG1,
            };

            _nixieTubeImages = new Dictionary<NixieTubeType, BitmapImage>{
                [NixieTubeType.zero]  = new BitmapImage(new Uri(@"\Asset\Image\NixieTube\nixie_0.png", UriKind.Relative)),
                [NixieTubeType.one] = new BitmapImage(new Uri(@"\Asset\Image\NixieTube\nixie_1.png", UriKind.Relative)),
                [NixieTubeType.two] = new BitmapImage(new Uri(@"\Asset\Image\NixieTube\nixie_2.png", UriKind.Relative)),
                [NixieTubeType.three] = new BitmapImage(new Uri(@"\Asset\Image\NixieTube\nixie_3.png", UriKind.Relative)),
                [NixieTubeType.four] = new BitmapImage(new Uri(@"\Asset\Image\NixieTube\nixie_4.png", UriKind.Relative)),
                [NixieTubeType.five] = new BitmapImage(new Uri(@"\Asset\Image\NixieTube\nixie_5.png", UriKind.Relative)),
                [NixieTubeType.six] = new BitmapImage(new Uri(@"\Asset\Image\NixieTube\nixie_6.png", UriKind.Relative)),
                [NixieTubeType.seven] = new BitmapImage(new Uri(@"\Asset\Image\NixieTube\nixie_7.png", UriKind.Relative)),
                [NixieTubeType.eight] = new BitmapImage(new Uri(@"\Asset\Image\NixieTube\nixie_8.png", UriKind.Relative)),
                [NixieTubeType.nine] = new BitmapImage(new Uri(@"\Asset\Image\NixieTube\nixie_9.png", UriKind.Relative)),
                [NixieTubeType.none] = new BitmapImage(new Uri(@"\Asset\Image\NixieTube\nixie_none.png", UriKind.Relative)),
                [NixieTubeType.dot] = new BitmapImage(new Uri(@"\Asset\Image\NixieTube\nixie_dot.png", UriKind.Relative)),
                [NixieTubeType.plus] = new BitmapImage(new Uri(@"\Asset\Image\NixieTube\nixie_0.png", UriKind.Relative)),
                [NixieTubeType.minus] = new BitmapImage(new Uri(@"\Asset\Image\NixieTube\nixie_0.png", UriKind.Relative)),
            };
        }
        
        /// <summary>
        /// メーターをリセット
        /// </summary>
        private void ResetMeter()
        {
            foreach (var nixieTubeIMG in _nixieTubeIMGs)
            {
                nixieTubeIMG.Source = _nixieTubeImages[NixieTubeType.none];
            }
        }

        /// <summary>
        /// メーターにエラーを表示
        /// </summary>
        public void ShowError()
        {
            ResetMeter();

            _nixieTubeIMGs[4].Source = _nixieTubeImages[NixieTubeType.dot];
            _nixieTubeIMGs[3].Source = _nixieTubeImages[NixieTubeType.dot];
            _nixieTubeIMGs[2].Source = _nixieTubeImages[NixieTubeType.dot];
            _nixieTubeIMGs[1].Source = _nixieTubeImages[NixieTubeType.dot];
            _nixieTubeIMGs[0].Source = _nixieTubeImages[NixieTubeType.dot];
        }

        /// <summary>
        /// メーターに数字を表示
        /// </summary>
        /// <param name="profitAndLoss">表示したい損益</param>
        public void ShowNumber(double profitAndLoss)
        {
            ResetMeter();

            //小数点第一位まで四捨五入し、文字列に置換
            var sign = profitAndLoss < 0 ? "-" : "+";
            var show = sign + Math.Round(profitAndLoss, 1, MidpointRounding.AwayFromZero);

            //ニキシー管メーターの表示限界に達している場合エラー
            if (_nixieTubeIMGs.Length < show.Length)
            {
                ShowError();
                return;
            }

            //表示
            for (int i=0; i<show.Length; i++)
            {
                switch (show[(show.Length - 1) - i])
                {
                    case '0':
                        _nixieTubeIMGs[i].Source = _nixieTubeImages[NixieTubeType.zero]; break;
                    case '1':
                        _nixieTubeIMGs[i].Source = _nixieTubeImages[NixieTubeType.one]; break;
                    case '2':
                        _nixieTubeIMGs[i].Source = _nixieTubeImages[NixieTubeType.two]; break;
                    case '3':
                        _nixieTubeIMGs[i].Source = _nixieTubeImages[NixieTubeType.three]; break;
                    case '4':
                        _nixieTubeIMGs[i].Source = _nixieTubeImages[NixieTubeType.four]; break;
                    case '5':
                        _nixieTubeIMGs[i].Source = _nixieTubeImages[NixieTubeType.five]; break;
                    case '6':
                        _nixieTubeIMGs[i].Source = _nixieTubeImages[NixieTubeType.six]; break;
                    case '7':
                        _nixieTubeIMGs[i].Source = _nixieTubeImages[NixieTubeType.seven]; break;
                    case '8':
                        _nixieTubeIMGs[i].Source = _nixieTubeImages[NixieTubeType.eight]; break;
                    case '9':
                        _nixieTubeIMGs[i].Source = _nixieTubeImages[NixieTubeType.nine]; break;
                    case '.':
                        _nixieTubeIMGs[i].Source = _nixieTubeImages[NixieTubeType.dot]; break;
                    case '+':
                        _nixieTubeIMGs[i].Source = _nixieTubeImages[NixieTubeType.plus]; break;
                    case '-':
                        _nixieTubeIMGs[i].Source = _nixieTubeImages[NixieTubeType.minus]; break;
                    default:
                        _nixieTubeIMGs[i].Source = _nixieTubeImages[NixieTubeType.none]; break;
                }
            }
        }

    }

    /// <summary>
    /// ニキシー管に表示する画像の種類
    /// </summary>
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
