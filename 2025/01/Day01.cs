namespace AoC2025
{
    public class Day01
    {
        string filePath = string.Empty;

        public Day01() : this(false)
        {

        }

        public Day01(bool isTest, bool isDebug = false)
        {
            Loader.LoadToCharList(2025, 1, isTest, isDebug);

            var list = new List<LinkedListNode>();
            list.Add(new LinkedListNode)
        }
    }

    static class CircularLinkedList {
    public static LinkedListNode<T> NextOrFirst<T>(this LinkedListNode<T> current)
    {
        return current.Next ?? current.List.First;
    }

    public static LinkedListNode<T> PreviousOrLast<T>(this LinkedListNode<T> current)
    {
        return current.Previous ?? current.List.Last;
    }
}

}

