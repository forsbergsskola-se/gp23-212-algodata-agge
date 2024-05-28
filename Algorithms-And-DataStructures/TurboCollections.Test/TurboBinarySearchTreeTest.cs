namespace TurboCollections.Test;

public class TurboBinarySearchTreeTest
{
    [Test]
    public void SearchTest()
    {
        var tree = new TurboBinarySearchTree<int>();

        tree.Insert(5);
        tree.Insert(2);
        tree.Insert(4);
        tree.Insert(8);
        tree.Insert(3);

        Assert.That(tree.Search(3), Is.EqualTo(true));
        Assert.That(tree.Search(7), Is.EqualTo(false));
    }
    
    [Test]
    public void DeleteNoChildTest()
    {
        var tree = new TurboBinarySearchTree<int>();

        tree.Insert(5);
        tree.Insert(2);
        tree.Insert(4);
        tree.Insert(8);
        tree.Insert(3);


        Assert.That(tree.Search(8), Is.EqualTo(true));
        bool deleted = tree.Delete(8);
        
        Assert.That(deleted, Is.EqualTo(true));
        Assert.That(tree.Search(8), Is.EqualTo(false));
    }
    
    [Test]
    public void DeleteOneChildTest()
    {
        var tree = new TurboBinarySearchTree<int>();

        tree.Insert(5);
        tree.Insert(2);
        tree.Insert(4);
        tree.Insert(8);


        bool deleted = tree.Delete(2);
        
        Assert.That(deleted, Is.EqualTo(true));
        Assert.That(tree.Search(4), Is.EqualTo(true));
    }
    
    [Test]
    public void DeleteDoubleChildTest()
    {
        var tree = new TurboBinarySearchTree<int>();

        tree.Insert(6);
        tree.Insert(2);
        tree.Insert(4);
        tree.Insert(8);
        tree.Insert(1);
        tree.Insert(3);


        bool deleted = tree.Delete(2);
        
        Assert.That(deleted, Is.EqualTo(true));
        Assert.That(tree.Search(1), Is.EqualTo(true));
    }
    
    
    [Test]
    public void DeleteRootTest()
    {
        var tree = new TurboBinarySearchTree<int>();

        tree.Insert(6);
        tree.Insert(2);
        tree.Insert(4);
        tree.Insert(8);
        tree.Insert(7);
        tree.Insert(9);


        bool deleted = tree.Delete(6);
        
        Assert.That(deleted, Is.EqualTo(true));
        Assert.That(tree.root!.value, Is.EqualTo(7));
        Assert.That(tree.root.left.value, Is.EqualTo(2));
        Assert.That(tree.root.right.value, Is.EqualTo(8));

    }
    
    [Test]
    public void TreeTest()
    {
        var tree = new TurboBinarySearchTree<int>();

        tree.Insert(6);
        tree.Insert(2);
        tree.Insert(4);
        tree.Insert(8);
        tree.Insert(7);
        tree.Insert(9);

        foreach (var t in tree)
        {
            Console.Write(t+ " ");
        }

        Assert.Pass();

    }
}