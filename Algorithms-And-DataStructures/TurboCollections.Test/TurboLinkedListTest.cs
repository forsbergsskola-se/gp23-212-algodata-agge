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
    
    [Test]
    public void TestRemove()
    {
        var list = new TurboLinkedList<int>();
        
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Remove(2);

        CollectionAssert.AreEqual(new []{1, 3}, list);
    }
    
    [Test]
    public void TestRemoveAt()
    {
        var list = new TurboLinkedList<int>();
        
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.RemoveAt(1);

        CollectionAssert.AreEqual(new []{1, 3}, list);
    }
    
    [Test]
    public void TestCount()
    {
        var list = new TurboLinkedList<int>();
        
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);

        Assert.That(list.Count(), Is.EqualTo(4));
    }
}