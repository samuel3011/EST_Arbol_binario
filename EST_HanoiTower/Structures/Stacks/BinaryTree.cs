using System.Collections;
using System.Xml.Linq;

public class BinaryTree<T> : ITree<T>
{
    public NodeTree<T> Root;

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(T data)
    {
        if (Root == null) return false;

        Queue<NodeTree<T>> queue = new Queue<NodeTree<T>>();
        queue.Enqueue(Root);
        NodeTree<T> current = queue.Dequeue();


        while (queue.Count > 0)
        {
            if (current.Value.Equals(data)) return true;

            if (current.left != null) queue.Enqueue(current.left);

            if (current.right != null) queue.Enqueue(current.right);
        }
        return false;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public int Count()
    {
        throw new NotImplementedException();
    }

    public NodeTree<T>? GetRoot()
    {
        return Root;
    }

    public int Height(  NodeTree<T> value)
    {
         if(Root == null)
         {
         return 0;
         }

        //Altura izq
        int Heightleft = Height(Root.left);
        //Altura der
        int  Heightright = Height(Root.right);

        return Math.Max(Heightleft, Heightright) +1;
       
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
        throw new NotImplementedException();
    }

    public T Min()
    {
        throw new NotImplementedException();
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
        if (Root == null) return default(T);

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

        if (NodeToDelete == null) return default(T);

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