namespace Calculations.Test
{
    public static class ShareDataTest
    {
        public static IEnumerable<object[]> TestData => new List<object[]>
        {
            new object[] { 1, true },
            new object[] { 200, false },
            new object[] { 301, true },
        };
    }
}
