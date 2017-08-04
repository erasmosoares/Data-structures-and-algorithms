using System;

namespace DataStructure
{
    public class Queue
    {
        const int _MAXIMUM_ = 10;
        
        int _newestIndex = 0;

        public int[] _storage;

        public Queue()
        {
            _storage = new int[_MAXIMUM_];
        }

        public void enqueue(int data)
        {

            if(_newestIndex != _MAXIMUM_)
            {
                this._storage[this._newestIndex] = data;
                this._newestIndex++;
            }
            else
            {
                throw new QueueException("Attempting to enqueue but the queue is full");
            }
        }

        public int dequeue()
        {
            int deletedData = this._storage[0];

            if (this._newestIndex != 0)
            {
                this._newestIndex--;

                if (this._storage.Length <= 1)
                {
                    this._storage[0] = 0;
                }
                else
                {
                    updateTheQueue();
                }
            }
            else
            {
                throw new QueueException("Attempting to dequeue but the queue is empty");
            }
           
           return deletedData;
        }

        private void updateTheQueue()
        {
            int position = 0;

            for (int x = 0; x < this._storage.Length - 1; x++)
            {
                this._storage[position] = this._storage[position + 1];

                position++;
            }
        }

        public void print()
        {
            for(int x = 0; x < this._storage.Length; x++)
            {
                Console.Write(" " + this._storage[x]);
            }
        }
    }

    public class QueueException : Exception
    {
        public QueueException():base(){}
        public QueueException(string message): base(message){}
        public QueueException(string message, Exception inner): base(message, inner){}
    }

}