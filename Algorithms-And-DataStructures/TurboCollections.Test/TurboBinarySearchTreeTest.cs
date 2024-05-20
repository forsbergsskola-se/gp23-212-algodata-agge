namespace TurboCollections.Test;

public class TurboBinarySearchTreeTest
{
    [Test]
    public void InsertTest()
    {
        var tree = new TurboBinarySearchTree<int>();

        tree.Insert(5);
        tree.Insert(2);
        tree.Insert(4);
        tree.Insert(8);
        tree.Insert(3);
        
        Assert.Pass();
    }
        
}