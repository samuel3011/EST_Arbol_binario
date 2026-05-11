using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace EST_HanoiTower.Structures.Trees
{
    public class AVLTree<T> : ITree<T> where T : IComparable<T>
    {
        public NodeTree<T> Root;

        public void Clear()
        {
            Root = null;
        }

        public bool Contains(T data)
        {
            return Contains(Root, data);
        }

        private bool Contains(NodeTree<T> node, T data)
        {
            if (node == null)
            {
                return false;
            }

            if (data.CompareTo(node.Value) == 0)
            {
                return true;
            }

            if (data.CompareTo(node.Value) < 0)
            {
                return Contains(node.left, data);
            }

            return Contains(node.right, data);
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
            if (node == null) return 0;

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
            Root = Insert(Root, data);
        }

        private NodeTree<T> Insert(NodeTree<T> node, T data)
        {
            if (node == null)
            {
                return new NodeTree<T>(data);
            }

            if (data.CompareTo(node.Value) < 0)
            {
                node.left = Insert(node.left, data);
            }
            else if (data.CompareTo(node.Value) > 0)
            {
                node.right = Insert(node.right, data);
            }
            else
            {
                return node;
            }

            int leftHeight = Height(node.left);
            int rightHeight = Height(node.right);

            if (leftHeight > rightHeight)
            {
                node.Height = leftHeight + 1;
            }
            else
            {
                node.Height = rightHeight + 1;
            }

            int balance = BalanceFactor(node);

            //LL
            if (balance > 1 && data.CompareTo(node.left.Value) < 0)
            {
                return RotateRight(node);
            }

            //RR
            if (balance < -1 && node.right != null && data.CompareTo(node.right.Value) > 0)
            {
                return RotateLeft(node);
            }

            //LR
            if (balance > 1 && node.left != null && data.CompareTo(node.left.Value) > 0)
            {
                node.left = RotateLeft(node.left);
                return RotateRight(node);
            }

            //RL
            if (balance < -1 && node.right != null && data.CompareTo(node.right.Value) < 0)
            {
                node.right = RotateRight(node.right);
                return RotateLeft(node);
            }

            return node;
        }

        private int BalanceFactor(NodeTree<T> node)
        {
            if (node == null) return 0;

            return Height(node.left) - Height(node.right);
        }

        private NodeTree<T> RotateRight(NodeTree<T> y)
        {
            NodeTree<T> x = y.left;
            NodeTree<T> T2 = x.right;

            x.right = y;
            y.left = T2;

            y.Height = Height(y);
            x.Height = Height(x);

            return x;
        }

        private NodeTree<T> RotateLeft(NodeTree<T> x)
        {
            NodeTree<T> y = x.right;
            NodeTree<T> T2 = y.left;

            y.left = x;
            x.right = T2;

            x.Height = Height(x);
            y.Height = Height(y);

            return y;
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
            NodeTree<T> current = Root;

            while (current.right != null)
            {
                current = current.right;
            }

            return current.Value;
        }

        public T Min()
        {
            NodeTree<T> current = Root;

            while (current.left != null)
            {
                current = current.left;
            }

            return current.Value;
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
            if (node.left == null && node.right == null)
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
}
