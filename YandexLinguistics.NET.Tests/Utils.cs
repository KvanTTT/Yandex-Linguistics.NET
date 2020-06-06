using System.IO;
using System.Runtime.CompilerServices;

namespace YandexLinguistics.NET.Tests
{
    public class Utils
    {
        public static string PredictorKey { get; private set; }
        public static string DictionaryKey { get; private set; }
        public static string TranslatorKey { get; private set; }

        static Utils()
        {
            InitKeys();
        }

        static void InitKeys([CallerFilePath] string callerFilePath = "")
        {
            var keysData = File.ReadLines(Path.Combine(Path.GetDirectoryName(callerFilePath), "TestKeys"));

            foreach (string key in keysData)
            {
                if (key.StartsWith("pdct"))
                {
                    PredictorKey = key;
                }
                else if (key.StartsWith("dict"))
                {
                    DictionaryKey = key;
                }
                else if (key.StartsWith("trnsl"))
                {
                    TranslatorKey = key;
                }
            }
        }
    }
}