namespace Calculations.Test
{
    public class NameTest
    {
        [Fact]
        public void FullName_GivenTwoStrings_ReturnsFullName()
        {
            var names = new Names();
            var result = names.FullName("Sarah", "Smith");
            Assert.Equal("Sarah Smith", result);
        }

        [Fact]
        public void FullNameWithMrOrMrs_GivenTwoStringsAndBool_ReturnsFullNameWithSalutation()
        {
            var names = new Names();
            var result = names.FullNameWithMrOrMrs("sarah", "Smith", false);
            Assert.Equal("Mrs. Sarah Smith", result, ignoreCase: true);
        }

        [Fact]
        public void FullNameContainsString_GivenTwoString_ReturnsFullName()
        {
            var names = new Names();
            var result = names.FullNameWithMrOrMrs("Sarah", "Smith", true);
            Assert.Contains("Sarah", result, StringComparison.CurrentCultureIgnoreCase);
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result);
        }

        [Fact]
        public void NickName_MustBeNull()
        {
           var names = new Names();
           Assert.Null(names.NickName);
        }

        [Fact]
        public void FullName_AlwaysReturnsValue()
        {
            var names = new Names();
            var result = names.FullName("Sarah", "Smith");
            Assert.NotNull(result);
            Assert.False(string.IsNullOrEmpty(result));
        }
    }
}
