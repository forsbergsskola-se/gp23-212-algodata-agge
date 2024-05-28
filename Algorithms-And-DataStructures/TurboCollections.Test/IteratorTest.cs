namespace TurboCollections.Test;

public class IteratorTest
{
    [Test]
    public static void IterateTest()
    {
        List<int> list = new List<int> { 1, 1, 2, 3, 5};
        P1_3_Iterator.PrintSum(list);
        
        Assert.Pass();
    }
}