public interface ITree<T>
{
    void Insert(T data);
    T remove(T data);
    bool Contains(T data);
    T Min();
    T Max();
    int Count();
    int Height();
    bool IsEmpty();
    void Clear();
    string PreOrder();
    string InOrder();
    string PostOrder();
    string LevelOrder();
    NodeTree<T>? GetRoot();
    string Classification();
}