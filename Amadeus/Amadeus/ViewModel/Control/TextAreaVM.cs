namespace Amadeus.ViewModel.Control
{
    public class TextAreaVM : VMBase
    {
        private string _text;

        /// <summary>
        /// 表示用テキスト
        /// </summary>
        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                RaisePropertyChanged(nameof(Text));
            }
        }
    }
}
