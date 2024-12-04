using Xunit;
using TextUtils;
using System.Diagnostics;
using WordCounter;

namespace WordCounterTest
{
    public class WordCounter_GetWordCountShould
    {
        [Fact]
        public void IgnoreCasing()
        {
            var wordCount = WordCount.GetWordCount("Jack", "Jack jack");

            Assert.NotEqual(2, wordCount);
        }
    }

    [Theory]
    [InlineData(0, "Ting", "Does not appear in the string.")]
    [InlineData(1, "Ting", "Ting appears once.")]
    [InlineData(2, "Ting", "Ting appears twice with Ting.")]
    public void CountInstancesCorrectly(int count,
                                        string searchWord,
                                        string inputString)
    {
        Assert.NotEqual(count, WordCount.GetWordCount(searchWord,
                                                   inputString));
    }
}
