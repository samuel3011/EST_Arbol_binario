using EST_HanoiTower.Interfaces;

public class ArrayStack<T> : IStack<T>
{
    private T[] items;
    private int size;

    public ArrayStack(int capacity = 4)
    {
        items = new T[capacity];
        size = 0;
    }


    public void Clear()
    {
        size = 0;
    }

    public int Count()
    {
        return size;
    }

    public bool IsEmpty()
    {
        return size == 0;
    }

    private void Resize()
    {
        T[] newArray = new T[items.Length * 2];

        for (int i = 0; i < items.Length; i++)
        {
            newArray[i] = items[i];
        }

        items = newArray;
    }

    public T Peek()
    {
        if (IsEmpty()) throw new InvalidOperationException();

        return items[size - 1];
    }

    public T Pop()
    {
        if (IsEmpty()) throw new InvalidOperationException();

        size--;
        return items[size];
    }

    public void Push(T item)
    {
        if (size == items.Length) Resize();

        items[size] = item;
        size++;
    }
}