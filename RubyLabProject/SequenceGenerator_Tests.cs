using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyLabProject
{
    [TestFixture]
    public class SequenceGenerator_Tests
    {
        private void CheckSequence(List<string> seq)
        {
            var buffer = new StringBuilder();
            for (int i = 1; i < seq.Count; i++)
            {
                buffer.Clear();
                for (int j = 0; j < seq[i].Length; j+=2)
                {
                    int count = seq[i][j] - '0';
                    char digit = seq[i][j + 1];
                    buffer.Append(new string(digit, count));
                }
                Assert.AreEqual(seq[i - 1], buffer.ToString());
            }
        }

        [Test]
        public void ManualTest15()
        {
            var expected = new string[] { "1", "11", "21", "1211"
                , "111221", "312211", "13112221", "1113213211"
                , "31131211131221", "13211311123113112211",
                "11131221133112132113212221", "3113112221232112111312211312113211"
                , "1321132132111213122112311311222113111221131221"
                , "11131221131211131231121113112221121321132132211331222113112211"
                , "311311222113111231131112132112311321322112111312211312111322212311322113212221"
            };
            var actual = new SequenceGenerator().Generate(15).ToArray();
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void AutoTest50()
        {
            CheckSequence(new SequenceGenerator().Generate(50).ToList());
        }
    }
}
