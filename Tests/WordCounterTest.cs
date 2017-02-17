using Xunit;
using System;
using System.Collections.Generic;

namespace RepeatCounterFunction.Objects
{
    public class RepeatCounterTest
    {
        [Fact]
        public void CountRepeats_ReturnInputs_AllInputs()
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
            string expected = new string("true");
            string output = testRepeatCounter.TrueFalse();
            Assert.Equal(expected, output);
        }
    }
}
