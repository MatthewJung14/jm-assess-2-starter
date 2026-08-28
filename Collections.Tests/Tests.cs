using Xunit;
using Skills2;

namespace Skills2.Tests;

public class TestCollectionsMethods
{
    [Fact]
    public void CountWords_ReturnWordCounts()
    {
        var text = "how are you";

        var result = CollectionsSkills.CountWords(text);

        Assert.Contains(result, x => x.Key == "how" && x.Value == 1);
        Assert.Contains(result, x => x.Key == "are" && x.Value == 1);
        Assert.Contains(result, x => x.Key == "you" && x.Value == 1);
    }

    [Fact]
    public void CountWords_TotalCountIsCorrect()
    {
        var text = "how are you";

        var result = CollectionsSkills.CountWords(text);

        Assert.Equal(3, result.Count);
    }

    [Fact]
    public void CountWords_DuplicateWords()
    {
        var text = "how are you how";

        var result = CollectionsSkills.CountWords(text);

        Assert.Contains(result, x => x.Key == "how" && x.Value == 2);
        Assert.Contains(result, x => x.Key == "are" && x.Value == 1);
        Assert.Contains(result, x => x.Key == "you" && x.Value == 1);
    }

    [Fact]
    public void GetMelonTypesAtPrice_ReturnsCorrectTypes()
    {
        var price = 2.5;

        var result = CollectionsSkills.GetMelonTypesAtPrice(price);

        Assert.Contains("honeydew", result);
        Assert.Contains("cantaloupe", result);
    }

    [Fact]
    public void GetMelonTypesAtPrice_ReturnsEmptyList()
    {
        var price = 1.5;

        var result = CollectionsSkills.GetMelonTypesAtPrice(price);

        Assert.Empty(result);
    }

    [Theory]
    [InlineData("professor excuse your students", "foul blaggart arr yer swabbies")]
    [InlineData("the restroom is a hotel for germs", "the head be a fleabag inn for germs")]
    public void TranslateToPirate_ReturnsCorrectTranslation(string english, string expected)
    {
        var result = CollectionsSkills.TranslateToPirate(english);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void CreateWordChain_ReturnsCorrectChain()
    {
        var words = new List<string> { "env", "at", "end", "vital" };

        var result = CollectionsSkills.CreateWordChain(words);

        Assert.Equal(new List<string> { "env", "vital" }, result);
    }

    [Fact]
    public void CreateWordChain_ReturnsLongChain()
    {
        var words = new List<string> { "cute", "antsy", "etcetera", "karat", "yak" };

        var result = CollectionsSkills.CreateWordChain(words);

        Assert.Equal(new List<string> { "cute", "etcetera", "antsy", "yak", "karat" }, result);
    }

    [Fact]
    public void CreateWordChain_ReturnFirstWord()
    {
        var words = new List<string> { "barry", "apple", "coco" };

        var result = CollectionsSkills.CreateWordChain(words);

        Assert.Equal(new List<string> { "barry" }, result);
    }

    [Fact]
    public void CreateWordChain_HandlesMultipleCandidates()
    {
        var words = new List<string> { "nathan", "noon", "neen" };

        var result = CollectionsSkills.CreateWordChain(words);

        Assert.Equal(new List<string> { "nathan", "noon", "neen" }, result);
    }
}
