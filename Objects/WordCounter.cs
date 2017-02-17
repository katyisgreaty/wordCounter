using Nancy;
using System;
using System.Collections.Generic;

namespace RepeatCounterFunction.Objects
{
    public class RepeatCounter
    {
        private string _phraseInput;
        private string _wordInput;
        private List<string> _outputInputs = new List<string>{};
        private int _counter;

        public RepeatCounter (string word, string phrase)
        {
            _phraseInput = phrase;
            _wordInput = word;
            _counter = 0;
        }

        public string GetWord()
        {
            return _wordInput;
        }

        public string GetPhrase()
        {
            return _phraseInput;
        }

        public List<string> GetInputs()
        {
            _outputInputs.Add(_phraseInput);
            _outputInputs.Add(_wordInput);
            return _outputInputs;
        }

        public bool TrueFalse()
        {
            bool result = false;
            string[] phraseWords = _phraseInput.Split(' ');
            foreach(string item in phraseWords)
            {
                if (item == _wordInput)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }

        public int CountRepeats()
        {
            string upperPhrase = _phraseInput.ToUpper();
            string upperWord = _wordInput.ToUpper();
            string[] phraseWords = upperPhrase.Split(' ');
            foreach(string item in phraseWords)
            {
                if (item == upperWord)
                {
                    _counter += 1;
                }
            }
            return _counter;
        }
    }
}
