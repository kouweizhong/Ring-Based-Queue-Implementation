using System;

namespace CollectionEnvironment
{
    public class RingQueue<T>
    {
        private RingQueue() { }

        public RingQueue(GrowthStrategy strategy)
        {
            _array = new T[1];
            Size = 0;
            _strategy = strategy;
            _leftPointer = 0;
            _rightPointer = 0;
        }

        private T[] _array;
        private int _leftPointer;
        private int _rightPointer;
        public int Size { get; private set; }
        private readonly GrowthStrategy _strategy;

        public void Enqueue(T item)
        {
            if ((_rightPointer != _leftPointer) || (Size == 0))
            {
                _array[_rightPointer] = item;
                _rightPointer = (_rightPointer + 1) % _array.Length;
                Size++;
            }
            else
            {
                T[] buffer = _array;
                _array = new T[_strategy.GetSize(buffer.Length)];

                for (int i = 0; i < buffer.Length; i++)
                {
                    _array[i] = buffer[(_leftPointer + i)%buffer.Length];
                }

                _leftPointer = 0;
                _rightPointer = buffer.Length;

                Enqueue(item);
            }
        }

        public T Dequeue()
        {
            if (Size == 0)
            {
                throw new IndexOutOfRangeException();
            }

            T toReturn = _array[_leftPointer];
            _array[_leftPointer] = default(T);

            _leftPointer = (_leftPointer + 1) % _array.Length;
            Size--;

            return toReturn;
        }
    }
}
