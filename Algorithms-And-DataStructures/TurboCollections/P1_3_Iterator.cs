namespace TurboCollections;

public class P1_3_Iterator
{
    public static void PrintSum(List<int> list)
    {
        int sum = 0;
        var enumerator = list.GetEnumerator();
        
        while (enumerator.MoveNext())
        {
            sum += enumerator.Current;
        }
        
        Console.WriteLine(sum);
    }
    
}