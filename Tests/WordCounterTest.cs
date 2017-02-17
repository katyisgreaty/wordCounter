using Xunit;
using System;
using System.Collections.Generic;

namespace RepeatCounterFunction.Objects
{
    public class RepeatCounterTest
    {
        [Fact]
        public void CountRepeats_ReturnInputs_allInputs()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter("this is a phrase", "pickle");
            List<string> expected = new List<string>{"this is a phrase", "pickle"};
            List<string> output = testRepeatCounter.GetInputs();
            Assert.Equal(expected, output);
        }

        [Fact]
        public void CountRepeats_ReturnTrueIfMatch_true()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter("I like rowing", "rowing");
            bool output = testRepeatCounter.TrueFalse();
            Assert.Equal(true, output);
        }

        [Fact]
        public void CountRepeats_ReturnCount_numberOfMatches()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter("Every dog is cute but my favorite kind of dog is a happy dog", "dog");
            int expected = 3;
            int output = testRepeatCounter.CountRepeats();
            Assert.Equal(expected, output);
        }
    }
}
