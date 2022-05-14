using FluentAssertions;
using FluentAssertions.Equivalency;
using NUnit.Framework;
using OnceLeetCodePerDay.Implements;

namespace OnceLeetCodePerDay
{
    //https://leetcode.com/problems/flipping-an-image/
    public class L832FlippingAnImageTests
    {
        [Test]
        public void Example1_Should_Work_As_Expected()
        {
            var l832FlippingAnImage = new L832FlippingAnImage();
            var image = new int[][]{new []{1, 1, 0}, new []{1, 0,1}, new []{0,0,0}};
            var expected = new int[][]{new []{1, 0, 0}, new []{0, 1,0}, new []{1,1,1}};
            l832FlippingAnImage.FlipAndInvertImage(image).Should()
                               .BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }
    }
}