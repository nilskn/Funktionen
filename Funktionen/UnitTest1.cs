using System;
using Xunit;

namespace Funktionen
{
    public class UnitTest1
    {

        Rechnung r = new Rechnung();
        double pi = (double)Math.PI;
        [Fact]
        public void sinus()
        {
            var actual = r.sinus(pi);
            var expected = 0;
            Assert.Equal(expected, actual, 5);
        }

        [Fact]
        public void Cosinus()
        {
            var actual = r.Cosinus(pi);
            var expected = -1;
            Assert.Equal(expected, actual, 5);

        }

        [Fact]
        public void Tangens()
        {
            var actual = r.Tangens(pi);
            var expected = 0;
            Assert.Equal(expected, actual, 5);

        }
    }
}
