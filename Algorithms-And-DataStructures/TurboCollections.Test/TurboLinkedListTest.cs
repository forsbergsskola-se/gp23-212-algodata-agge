namespace TurboCollections.Test;

public class TurboLinkedListTest
{
    [Test]
    public void TestAdd()
    {
        var list = new TurboLinkedList<int>();
        
        list.Add(1);
        list.Add(2);
        list.Add(3);

        CollectionAssert.AreEqual(new []{1, 2, 3}, list);
    }
}