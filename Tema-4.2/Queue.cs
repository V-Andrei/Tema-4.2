using System;

namespace Tema_4._2
{
    class Queue<T>
    {
        private int _capacity;
        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }

        private int _length;
        public int Length 
        { get { return _length; }
          set { _length = value; }
        }


        private T[] _elements;
        protected T[] Elements
        {
            get { return _elements; }
            set { _elements = value; }
        }

        private int _frontIndex;
        public int FrontIndex
        {
            get { return _frontIndex; }
            set { _frontIndex = value; }
        }

        public int BackIndex
        {
            get { return (FrontIndex + Length) % Capacity; }
        }

        public Queue()
        {
            Elements = new T[Capacity];
        }

        public Queue(int capacity)
        {
            Capacity = capacity;
            Elements = new T[Capacity];
        }

        public void Enqueue(T element)
        {
            if (this.Length == Capacity)
            {
                IncreaseCapacity();
            }
            Elements[BackIndex] = element;
            Length++;
        }

        public T Dequeue()
        {
            if (this.Length < 1)
            {
                Console.WriteLine("Queue is empty");
            }
            T element = Elements[FrontIndex];
            Elements[FrontIndex] = default(T);
            Length--;
            FrontIndex = (FrontIndex + 1) % Capacity;
            return element;
        }

        protected void IncreaseCapacity()
        {
            this.Capacity++;
            this.Capacity *= 2;
            Queue<T> tempQueue = new Queue<T>(this.Capacity);
            while (this.Length > 0)
            {
                tempQueue.Enqueue(this.Dequeue());
            }
            this.Elements = tempQueue.Elements;
            this.Length = tempQueue.Length;
            this.FrontIndex = tempQueue.FrontIndex;
        }
        public void ElementsQueuePrint()
        {
            foreach (var item in Elements)
            {
                Console.WriteLine(item);
            }
        }
    }


}
