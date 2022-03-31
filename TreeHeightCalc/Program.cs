using Shared.BinaryTree;

var root = Node.Create(10);

root.Add(Node.Create(13));
root.Add(Node.Create(2));
root.Add(Node.Create(7));
root.Add(Node.Create(22));
root.Add(Node.Create(23));
root.Add(Node.Create(1));

Console.WriteLine(CalcTreeHeight(root));

int CalcTreeHeight(Node root)
{
    int countLeft = 0;
    int countRight = 0;

    if (root.ExistLeftNode())
    {
        countLeft = CalcTreeHeight(root.Left);
    }
    if (root.ExistRightNode())
    {
        countRight = CalcTreeHeight(root.Right);
    }

    if (countLeft > countRight)
        return (countLeft + 1);
    else
        return (countRight + 1);
}