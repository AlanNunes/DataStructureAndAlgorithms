namespace Shared.BinaryTree
{
    public static class BinarySearchTree
    {
        public static void Add(this Node root, Node node)
        {
            if (!root.ExistLeftNode())
            {
                if ((int)node.Value <= (int)root.Value)
                    root.Left = node;
            }
            else
            {
                if ((int)node.Value <= (int)root.Value)
                    Add(root.Left, node);
            }
            if (!root.ExistRightNode())
            {
                if ((int)node.Value > (int)root.Value)
                    root.Right = node;
            }
            else
            {
                if ((int)node.Value > (int)root.Value)
                    Add(root.Right, node);
            }
        }
    }
}