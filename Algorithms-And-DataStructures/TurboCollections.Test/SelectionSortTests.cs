namespace TurboCollections.Test;

public static class SelectionSortTests
{
    [Test]
    public static void SelectionTest()
    {
        List<int> list = new List<int> { 3, 5, 2, 1, 8, 4, 6, 7 };
        TurboSort.Selection(list);
        
        CollectionAssert.AreEqual(new []{1, 2, 3, 4, 5, 6, 7, 8}, list);
    }
}