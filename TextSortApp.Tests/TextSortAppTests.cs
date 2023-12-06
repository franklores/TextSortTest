namespace TextSortApp.Tests;

using Microsoft.Extensions.Logging;

using TextSortApp.Application;

[TestClass]
public class TextSortAppTests
{
    [TestMethod]
    [DataRow("Zoom Boom", "Boom Zoom")]
    [DataRow("aBba Abba", "Abba aBba")]
    public void TextSortAppGivenInputShouldReturnCorrectlySortedString(string input, string expected)
    {
        //arrange
        var moqLogger = new Moq.Mock<ILogger<TextAnalyzer>>();
        var sut = new TextAnalyzer(moqLogger.Object);

        //act
        var result = sut.CleanAndSortText(input, Array.Empty<char>());

        //assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow("aBba, Abba", "Abba aBba")]
    public void TextSortAppGivenInputWithPunctuationShouldReturnCleanedAndSortedString(string input, string expected)
    {
        //arrange
        //arrange
        var moqLogger = new Moq.Mock<ILogger<TextAnalyzer>>();
        var sut = new TextAnalyzer(moqLogger.Object);

        //act
        var result = sut.CleanAndSortText(input, new char[] { '.', ',', ';', '\'' });

        //assert
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(null)]
    [DataRow("")]
    public void TextSortAppGivenInvalidInputShouldThrowException(string input)
    {
        //arrange
        //arrange
        var moqLogger = new Moq.Mock<ILogger<TextAnalyzer>>();
        var sut = new TextAnalyzer(moqLogger.Object);

        //act & assert
        Assert.ThrowsException<ArgumentNullException>(() => sut.CleanAndSortText(input, Array.Empty<char>()));
    }
}