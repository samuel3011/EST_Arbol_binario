public class NodeTree<T>
{
    public T Value;
    public NodeTree<T> left;
    public NodeTree<T> right;
    public int Height = 1;

    public NodeTree(T value)
    {
        Value = value;
        left = null;
        right = null;
    }
}