
using System.IO;
using System.Linq;

namespace CompareCSV
{
    public class CompareCsv
    {
        public static bool IsEqual(string filePath1, string filePath2)
        {
            var actual = File.ReadLines(filePath1);
            var expected = File.ReadLines(filePath2);
            var response = actual.SequenceEqual(expected);
            return response;
        }
    }
}
