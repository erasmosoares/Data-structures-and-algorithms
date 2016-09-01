using System;

namespace DataStructure
{
    public class Stack
    {        
        const int _MAX_VALUE_ = 10;

        int _size;
        public int[] _storage;

        public Stack()
        {
            this._size = -1;
            _storage = new int[_MAX_VALUE_];
        }

        public void push(int data)
        {
            if(this._size <= 8)
            {
                this._size++;
                this._storage[this._size] = data;
            }
            else
            {
                throw new StackException("Attempting to push but the stack is full");                
            }
          
        }

        public int pop()
        {            
            int deletedData;

            if(this._size >= 0)
            {
                deletedData = this._storage[this._size];
                this._storage[this._size] = 0;                
                this._size--;                
            }
            else
            {
                throw new StackException("Attempting to pop but the stack is empty");
            }

            return deletedData;
        }

        public void print()
        {
            for (int x = 0; x < this._storage.Length; x++)
            {
                Console.Write(" " + this._storage[x]);
            }
        }
    }

    public class StackException : Exception
    {
        public StackException() : base() { }
        public StackException(string message) : base(message) { }
        public StackException(string message, Exception inner) : base(message, inner) { }
    }
}
