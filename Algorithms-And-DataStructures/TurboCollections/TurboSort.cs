namespace TurboCollections;

public static class TurboSort
{
    public static void Selection(List<int> list)
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            int lowestValueIndex = i;
            
            for (int n = i + 1; n < list.Count; n++)
            {
                if (list[lowestValueIndex] > list[n])
                    lowestValueIndex = n;
            }

            (list[lowestValueIndex], list[i]) = (list[i], list[lowestValueIndex]);
        }
    }
}