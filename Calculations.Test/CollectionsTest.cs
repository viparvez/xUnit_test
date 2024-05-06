using Xunit.Abstractions;

namespace Calculations.Test
{
    public class CollectionsFixture : IDisposable
    {
        public Collections collections => new Collections();

        public void Dispose()
        {
            //dispose
        }
    }

    public class CollectionsTest : IClassFixture<CollectionsFixture>, IDisposable
    {
        private readonly CollectionsFixture _collectionsFixture;
        private readonly ITestOutputHelper _output;
        private MemoryStream memoryStream;
        public CollectionsTest(CollectionsFixture collectionsFixture, ITestOutputHelper output)
        {
            _collectionsFixture = collectionsFixture;
            _output = output;
            memoryStream = new MemoryStream();
            _output.WriteLine("CollectionsTest constructor");
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotIncludeZero()
        {
            _output.WriteLine("Run FiboDoesNotIncludeZero");
            var collections = _collectionsFixture.collections;
            Assert.All(collections.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboIncludesThirteen()
        {
            _output.WriteLine("Run FiboIncludesThirteen");
            var collections = _collectionsFixture.collections;
            Assert.Contains(13, collections.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotIncludeFour()
        {
            _output.WriteLine("Run FiboDoesNotIncludeFour");
            var collections = _collectionsFixture.collections;
            Assert.DoesNotContain(4, collections.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void CheckCollection()
        {
            _output.WriteLine("Run CheckCollection");
            var expectedCollection = new List<int> { 1, 1, 2, 3, 5, 8, 13 };
            var collections = _collectionsFixture.collections;
            Assert.Equal(expectedCollection, collections.FiboNumbers);
        }

        [Theory]
        [MemberData(nameof(ShareDataTest.TestData), MemberType = typeof(ShareDataTest))]
        public void IsOdd_Test(int value, bool expected)
        {
            var collections = _collectionsFixture.collections;
            var result = collections.IsOdd(value);
            Assert.Equal(expected,result);
        }

        public void Dispose()
        {
            memoryStream.Dispose();
        }
    }
}
