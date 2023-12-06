namespace TextSortApp.Application;

using System;
using System.Linq;

using Microsoft.Extensions.Logging;

public class TextAnalyzer : ITextAnalyzer
{
    private readonly ILogger<TextAnalyzer> _logger;

    public TextAnalyzer(ILogger<TextAnalyzer> logger)
    {
        this._logger = logger;
    }

    public string CleanAndSortText(string textToClean, char[] charactersToRemove)
    {
        if (string.IsNullOrEmpty(textToClean))
        {
            throw new ArgumentNullException(nameof(textToClean));
        }

        _logger.LogInformation("Starting clean and sort");

        var words = textToClean.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        var cleanedWords = words.Select(word =>
            new string(word.Where(c => !charactersToRemove.Contains(c)).ToArray()));

        var sortedWords = cleanedWords
            .OrderBy(word => word, StringComparer.OrdinalIgnoreCase)
            .ThenByDescending(word => word).ToList();

        return string.Join(' ', sortedWords);
    }
}