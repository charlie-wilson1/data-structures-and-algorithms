using System;
using Xunit;
using CodeChallenge31;
using CodeChallenge31.CC31;

namespace CodeChallenge31Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ReturnsRepeatedWord()
        {
            string a = "Hello World I have news for you. World";
      string b = "This is a test. This";

            Challenge c = new Challenge();
            Assert.Equal("World", c.FindMatch(a));
      Assert.Equal("This", c.FindMatch(b));
        }

    [Fact]
    public void ReturnsNullWhenZeroRepeats()
    {
      string a = "This sentence does not have any repeats.";

            Challenge c = new Challenge();
      Assert.Null(c.FindMatch(a));
    }

    [Fact]
    public void ReturnsWithCollision()
    {
      string a = "Mary had a little lamb, little lamb, little lamb.";

      Challenge c = new Challenge();

      Assert.Equal("little", c.FindMatch(a));
    }
    }
}
