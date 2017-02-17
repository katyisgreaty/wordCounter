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
        // private int _counter;

        public RepeatCounter (string phrase, string word)
        {
            _phraseInput = phrase;
            _wordInput = word;
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
    }
}
