namespace Shared.BinaryTree
{
    public class Node
    {
        public Node? Left { get; set; }
        public object Value { get; set; }
        public Node? Right { get; set; }

        private Node() { }

        public static Node Create(object value, Node? left = null, Node? right = null)
            => new() { Left = left, Value = value, Right = right };

        public bool ExistLeftNode()
            => Left is not null;

        public bool ExistRightNode()
            => Right is not null;
    }
}