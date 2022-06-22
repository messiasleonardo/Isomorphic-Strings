using Isomorphic_Strings;
using Xunit;

namespace SolutionTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("egg","add",true)]
        [InlineData("foo","bar",false)]
        [InlineData("paper","title",true)]
        [InlineData("aa","bb",true)]
        [InlineData("bbbaaaba","aaabbbba",false)]
        public void Test1(string s, string t, bool expected)
        {
            Solution solution = new Solution();

            bool actual = solution.IsIsomorphic(s,t);

            Assert.Equal(expected, actual);
        }
    }
}