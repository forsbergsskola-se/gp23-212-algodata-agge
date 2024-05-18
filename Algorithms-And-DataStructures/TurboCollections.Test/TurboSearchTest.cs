namespace TurboCollections.Test;

public class TurboSearchTest
{
    [Test]
    public void TestBinarySearch()
    {
        var turboSearch = new TurboSearch<int>();

        IList<int> list = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int index = turboSearch.BinarySearch(list, 8);
        
        Assert.That(index, Is.EqualTo(8));
    }
}