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
            RepeatCounter testRepeatCounter = new RepeatCounter("pickle", "this is a phrase");
            List<string> expected = new List<string>{"this is a phrase", "pickle"};
            List<string> output = testRepeatCounter.GetInputs();
            Assert.Equal(expected, output);
        }

        [Fact]
        public void CountRepeats_ReturnTrueIfMatch_true()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter("rowing", "I like rowing");
            bool output = testRepeatCounter.TrueFalse();
            Assert.Equal(true, output);
        }

        [Fact]
        public void CountRepeats_ReturnCount_numberOfMatches()
        {
            RepeatCounter testRepeatCounter = new RepeatCounter("boat", "the boat is ugly");
            int expected = 1;
            int output = testRepeatCounter.CountRepeats();
            Assert.Equal(expected, output);
        }
    }
}
