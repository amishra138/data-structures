namespace _01_time_complexity
{
    public class Node
    {
        public int Data { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }

        public Node(int data)
        {
            Data = data;
            Left = Right = null;
        }
    }
}
