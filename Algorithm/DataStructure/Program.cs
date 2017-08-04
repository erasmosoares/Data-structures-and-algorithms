using System;

namespace DataStructure
{
    class Program
    {
        /**
         * Assumin 0 for empty 
         **/
         static void Main(string[] args)
        {

            /**
             * 
             * TEST STACK
             * 
             * */
            Console.WriteLine("TEST STACK");

            Console.ReadKey();
            Console.Clear();

            Stack myStack = new Stack();
            myStack.push(1);
            myStack.push(2);
            myStack.push(3);
            myStack.push(4);
            myStack.push(5);

            myStack.print();

            Console.WriteLine("");

            Console.WriteLine(" Pop -> " + myStack.pop());
            Console.WriteLine(" Pop -> " + myStack.pop());

            myStack.print();

            myStack.push(1);
            myStack.push(2);

            Console.WriteLine("");

            Console.WriteLine(" Push -> 1");
            Console.WriteLine(" Push -> 2");

            myStack.print();

            Console.ReadKey();
            Console.Clear();

            /**
            * 
            * TEST QUEUE
            * 
            * */
            Console.WriteLine("TEST QUEUE");

            Console.ReadKey();
            Console.Clear();

            Queue queue = new Queue();
            queue.enqueue(1);
            queue.enqueue(2);
            queue.enqueue(3);
            queue.enqueue(4);
            queue.enqueue(5);

            queue.print();

            Console.WriteLine("");

            Console.WriteLine(" enqueue -> 6");
            Console.WriteLine(" enqueue -> 7");

            queue.enqueue(6);
            queue.enqueue(7);

            queue.print();

            Console.WriteLine("");
            Console.WriteLine(" dequeue ");
            queue.dequeue();

            queue.print();

            Console.WriteLine("");
            Console.WriteLine(" dequeue ");
            queue.dequeue();

            queue.print();

            Console.WriteLine("");

            Console.WriteLine(" enqueue -> 1");
            Console.WriteLine(" enqueue -> 2");

            queue.enqueue(1);
            queue.enqueue(2);

            queue.print();

            Console.ReadKey();
        }
    }
}
