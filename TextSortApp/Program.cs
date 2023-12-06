namespace TextSortApp;

using Microsoft.Extensions.Logging;

internal class Program
{
    private static void Main(string[] args)
    {
        using var loggerFactory = LoggerFactory.Create(builder =>
               {
                   builder.AddConsole();
               });

        var logger = loggerFactory.CreateLogger<Application.TextAnalyzer>();

        logger.LogInformation("Starting TextSortApp");

        var textSorter = new Application.TextAnalyzer(logger);

        var puctuation = new char[] { '.', ',', ';', '\'' };

        var textToSort = "Zerbra Abba";

        var result = textSorter.CleanAndSortText(textToSort, puctuation);

        logger.LogInformation("Result: {result}", result);
    }
}