using System.Collections;
using System.Xml.Linq;

public class BinaryTree<T> : ITree<T> where T : IComparable<T>
{
    public NodeTree<T> Root;

    public void Clear()
    {
        Root = null;
    }

    public bool Contains(T data)
    {
        if (Root == null) return false;

        Queue<NodeTree<T>> queue = new Queue<NodeTree<T>>();
        queue.Enqueue(Root);

        while (queue.Count > 0)
        {
            NodeTree<T> current = queue.Dequeue();

            if (current.Value.Equals(data)) return true;

            if (current.left != null) queue.Enqueue(current.left);

            if (current.right != null) queue.Enqueue(current.right);
        }

        return false;
    }

    public int Count()
    {
        return CountNodes(Root);
    }


    private int CountNodes(NodeTree<T> node)
    {
        if (node == null) return 0;

        return 1 + CountNodes(node.left) + CountNodes(node.right);
    }

    public NodeTree<T>? GetRoot()
    {
        return Root;
    }

    public int Height()
    {
        return Height(Root);
    }

    private int Height(NodeTree<T> node)
    {
        if (node == null)  return 0;
        
        // Altura izquierda
        int Heightleft = Height(node.left);

        // Altura derecha
        int Heightright = Height(node.right);

        if (Heightleft > Heightright)
        {
            return Heightleft + 1;
        }
        else
        {
            return Heightleft + 1;
        }
    }

    public void InOrder()
    {
        InOrder(Root);
    }

    public void InOrder(NodeTree<T> node)
    {
        if (node == null) return;

        InOrder(node.left);
        Console.WriteLine(node.Value);
        InOrder(node.right);
    }

    public void Insert(T data)
    {
        NodeTree<T> newNode = new NodeTree<T>(data);

        if (Root == null)
        {
            Root = newNode;
            return;
        }

        Queue<NodeTree<T>> queue = new Queue<NodeTree<T>>();
        queue.Enqueue(Root);

        while (queue.Count > 0)
        {
            NodeTree<T> current = queue.Dequeue();

            if (current.left == null)
            {
                current.left = newNode;
                return;
            }
            else
            {
                queue.Enqueue(current.left);
            }

            if (current.right == null)
            {
                current.right = newNode;
                return;
            }
            else
            {
                queue.Enqueue(current.right);
            }

        }
    }

    public bool IsEmpty()
    {
        return (Root == null);
    }

    public void LevelOrder()
    {
        if (Root == null) return;

        Queue<NodeTree<T>> queue = new Queue<NodeTree<T>>();
        queue.Enqueue(Root);

        while (queue.Count > 0)
        {
            NodeTree<T> current = queue.Dequeue();
            Console.WriteLine(current.Value);

            if (current.left != null)
            {
                queue.Enqueue(current.left);
            }

            if (current.right != null)
            {
                queue.Enqueue(current.right);
            }
        }
    }

    public T Max()
    {
        if (Root == null)
            throw new Exception("El árbol está vacío");

        T max = Root.Value;

        Queue<NodeTree<T>> queue = new Queue<NodeTree<T>>();
        queue.Enqueue(Root);

        while (queue.Count > 0)
        {
            NodeTree<T> current = queue.Dequeue();

            // Comparar
            if (current.Value.CompareTo(max) > 0)
            {
                max = current.Value;
            }

            if (current.left != null)
                queue.Enqueue(current.left);

            if (current.right != null)
                queue.Enqueue(current.right);
        }

        return max;
    }

    public T Min()
    {
        if (Root == null)
            throw new Exception("El árbol está vacío");

        T min = Root.Value;

        Queue<NodeTree<T>> queue = new Queue<NodeTree<T>>();
        queue.Enqueue(Root);

        while (queue.Count > 0)
        {
            NodeTree<T> actual = queue.Dequeue();

            // Comparar
            if (actual.Value.CompareTo(min) < 0)
            {
                min = actual.Value;
            }

            if (actual.left != null)
                queue.Enqueue(actual.left);

            if (actual.right != null)
                queue.Enqueue(actual.right);
        }

        return min;
    }

    public void PostOrder()
    {
        PostOrder(Root);
    }

    public void PostOrder(NodeTree<T> node)
    {
        if (node == null) return;

        PostOrder(node.left);
        PostOrder(node.right);
        Console.WriteLine(node.Value);
    }

    public void PreOrder()
    {
        PreOrder(Root);
    }

    public void PreOrder(NodeTree<T> node)
    {
        if (node == null) return;

        Console.WriteLine(node.Value);
        PreOrder(node.left);
        PreOrder(node.right);
    }

    public T remove(T data)
    {
        if (Root == null) return default;

        Queue<NodeTree<T>> queue = new Queue<NodeTree<T>>();
        queue.Enqueue(Root);

        NodeTree<T> NodeToDelete = null;
        NodeTree<T> Last = null;

        while (queue.Count > 0)
        {
            Last = queue.Dequeue();

            if (Last.Value.Equals(data))
            {
                NodeToDelete = Last;
            }

            if (Last.left != null) queue.Enqueue(Last.left);
            if (Last.right != null) queue.Enqueue(Last.right);
        }

        if (NodeToDelete == null) return default;

        T Deleted = NodeToDelete.Value;

        NodeToDelete.Value = Last.Value;

        RemoveLast(Last);

        return Deleted;
    }

    public void RemoveLast(NodeTree<T> node)
    {
        if (node == null) return;
        
        Queue<NodeTree<T>> queue = new Queue<NodeTree<T>>();
        queue.Enqueue(Root);

        while (queue.Count > 0)
        {
             NodeTree<T> current = queue.Dequeue();

            if (current.left == node)
            {
                 current.left = null;
                 return;
            }
             if (current.right == node)
            {
                current.right = null;
                return;
            }

            if (current.left != null)
             {
                queue.Enqueue(current.left);
             }

            if (current.right != null)
            {
                 queue.Enqueue(current.right);
            }
        }
        
    }
}