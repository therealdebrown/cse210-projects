
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorization
{
    class Scripture
    {
        private Reference _reference;
        private List<Word> _words;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = text.Split(' ').Select(word => new Word(word)).ToList();
        }

        public void HideRandomWords(int count)
        {
            var visibleWords = _words.Where(word => !word.IsHidden).ToList();
            var random = new Random();

            for (int i = 0; i < count && visibleWords.Count > 0; i++)
            {
                var wordToHide = visibleWords[random.Next(visibleWords.Count)];
                wordToHide.Hide();
                visibleWords.Remove(wordToHide);
            }
        }

        public string Display()
        {
            string scriptureText = string.Join(" ", _words.Select(word => word.Display()));
            return $"{_reference}\n{scriptureText}";
        }

        public bool IsFullyHidden()
        {
            return _words.All(word => word.IsHidden);
        }
    }
}
