using Xunit;
using System;
using System.IO;
using System.Text;
using System.Linq;

namespace csharpcore
{
    public class ApprovalTest
    {
        [Fact]
        public void ThirtyDays()
        {
            var lines = File.ReadAllLines("ThirtyDays.txt");
            lines = lines.Where(line => line != "").ToArray();

            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main(new string[] { });
            string output = fakeoutput.ToString();

            var outputLines = output.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries );
            for (var i = 0; i < Math.Min(lines.Length, outputLines.Length); i++)
            {
                Assert.Equal(lines[i], outputLines[i]);
            }
        }
    }
}
