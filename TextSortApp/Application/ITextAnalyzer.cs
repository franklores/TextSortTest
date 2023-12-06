namespace TextSortApp.Application;

public interface ITextAnalyzer
{
    string CleanAndSortText(string textToClean, char[] charactersToRemove);
}