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
            return Heightright + 1;
        }
    }

    public string InOrder()
    {
        return InOrder(Root);
    }

    public string InOrder(NodeTree<T> node)
    {
        if (node == null) return "";

        return InOrder(node.left) + node.Value + " " + InOrder(node.right);
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

    public string LevelOrder()
    {
        if (Root == null) return "";

        string result = "";

        Queue<NodeTree<T>> queue = new Queue<NodeTree<T>>();
        queue.Enqueue(Root);

        while (queue.Count > 0)
        {
            NodeTree<T> current = queue.Dequeue();

            result += current.Value + " ";

            if (current.left != null)
            {
                queue.Enqueue(current.left);
            }

            if (current.right != null)
            {
                queue.Enqueue(current.right);
            }
        }

        return result;
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

    public string PostOrder()
    {
        return PostOrder(Root);
    }

    public string PostOrder(NodeTree<T> node)
    {
        if (node == null) return "";

        return PostOrder(node.left) + PostOrder(node.right) + node.Value + " ";
    }

    public string PreOrder()
    {
        return PreOrder(Root);
    }

    public string PreOrder(NodeTree<T> node)
    {
        if (node == null) return "";

        return node.Value + " " + PreOrder(node.left) + PreOrder(node.right);
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

    public bool IsDegenerate()
    {
        return IsDegenerate(Root);
    }

    private bool IsDegenerate(NodeTree<T> node)
    {
        if (node == null)
        {
            return true;
        }

        // Tiene dos hijos
        if (node.left != null && node.right != null)
        {
            return false;
        }

        return IsDegenerate(node.left) && IsDegenerate(node.right);
    }

    public bool IsBalanced()
    {
        return IsBalanced(Root);
    }

    private bool IsBalanced(NodeTree<T> node)
    {
        if (node == null)
        {
            return true;
        }

        int leftHeight = Height(node.left);

        int rightHeight = Height(node.right);

        int difference = leftHeight - rightHeight;

        if (difference < 0)
        {
            difference = difference * -1;
        }

        if (difference > 1)
        {
            return false;
        }

        return IsBalanced(node.left) && IsBalanced(node.right);
    }

    public bool IsFull()
    {
        return IsFull(Root);
    }

    private bool IsFull(NodeTree<T> node)
    {
        if (node == null)
        {
            return true;
        }

        // Hoja
        if (node.left == null &&  node.right == null)
        {
            return true;
        }

        // Tiene ambos hijos
        if (node.left != null && node.right != null)
        {
            return IsFull(node.left) && IsFull(node.right);
        }

        return false;
    }

    public bool IsPerfect()
    {
        int h = Height();

        int expected = 1;

        for (int i = 0; i < h; i++)
        {
            expected = expected * 2;
        }

        expected = expected - 1;

        return Count() == expected;
    }

    public string Classification()
    {
        string result = "";

        if (IsPerfect())
        {
            result += "\nPerfect ";
        }

        if (IsFull())
        {
            result += "\nFull ";
        }

        if (IsBalanced())
        {
            result += "\nBalanced ";
        }

        if (IsDegenerate())
        {
            result += "\nDegenerate ";
        }

        return result;
    }
}