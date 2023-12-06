//simple test

//Test

namespace SimpleTest
{
    [Obsolete()]
    public static partial class MyTest
    {
        internal class ConsoleLogger : ILogger
        {
            public void Log(string stuff)
            {
                Console.WriteLine(stuff);
            }
        }

        public static string CalculateTotal(string someInput)
        {
            var log = new ConsoleLogger();
            if (someInput == null)
            {
                throw new DataMisalignedException("data not correct");
            }

            log.Log("start CalculateTotal");

            //algorithm
            if (someInput == "Go baby, go")
            {
                return "baby Go go";
            }

            log.Log("end CalculateTotal");
            return someInput;
        }
    }
}