namespace ScriptureMemorization
{
    class Word
    {
        private string _text;
        public bool IsHidden { get; private set; }

        public Word(string text)
        {
            _text = text;
            IsHidden = false;
        }

        public void Hide()
        {
            IsHidden = true;
        }

        public string Display()
        {
            return IsHidden ? new string('_', _text.Length) : _text;
        }
    }
}
