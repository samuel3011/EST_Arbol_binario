using System.Collections;

namespace EST_HanoiTower.Interfaces;

interface IStack<T>
    {
        void Push(T item);
        T Pop();
        T Peek();
        bool IsEmpty();
        int Count();
        void Clear();
    }