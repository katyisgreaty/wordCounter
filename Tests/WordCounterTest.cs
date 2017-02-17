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
    }
}
