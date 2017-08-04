using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructure.Tests
{
    
    [TestClass()]
    public class QueueTests
    {
        [TestMethod()]
        public void StackPushTest()
        {
            int firstDataExpected = 1;
            int LastDataExpected = 5;

            Stack stack = new Stack();
            stack.push(1);
            stack.push(2);
            stack.push(3);
            stack.push(4);
            stack.push(5);

            int firstData;
            int lastData;

            firstData = stack._storage[0];
            lastData = stack._storage[4];

            Assert.AreEqual(firstDataExpected, firstData);
            Assert.AreEqual(LastDataExpected, lastData);
        }

        [TestMethod()]
        [ExpectedException(typeof(StackException))]
        public void StackPushMoreThanMaximumTest()
        {
            Stack stack = new Stack();
            stack.push(1);
            stack.push(2);
            stack.push(3);
            stack.push(4);
            stack.push(5);
            stack.push(6);
            stack.push(7);
            stack.push(8);
            stack.push(9);
            stack.push(10);
            stack.push(11);
        }

        [TestMethod()]
        public void StackPopTest()
        {
            int firstDataExpected = 3;
            int LastDataExpected = 1;

            Stack stack = new Stack();
            stack.push(1);
            stack.push(2);
            stack.push(3);
            stack.push(4);
            stack.push(5);

            stack.pop();
            stack.pop();

            int firstData;
            int lastData;

            lastData = stack._storage[0];
            firstData = stack._storage[2];

            Assert.AreEqual(firstDataExpected, firstData);
            Assert.AreEqual(LastDataExpected, lastData);
        }

        [TestMethod()]
        [ExpectedException(typeof(StackException))]
        public void StackPophMoreThanMaximumTest()
        {
            Stack stack = new Stack();
            stack.pop();
            stack.pop();
            stack.pop();
            stack.pop();
            stack.pop();
            stack.pop();
            stack.pop();
            stack.pop();
            stack.pop();
            stack.pop();
            stack.pop();
        }

        [TestMethod()]
        public void QeueuEnqueueTest()
        {
            Queue queue = new Queue();
            queue.enqueue(1);
            queue.enqueue(2);
            queue.enqueue(3);
            queue.enqueue(4);
            queue.enqueue(5);

            int firstDataExpected = 1;
            int LastDataExpected = 5;

            int firstData;
            int lastData;

            firstData = queue._storage[0];
            lastData = queue._storage[4];

            Assert.AreEqual(firstDataExpected, firstData);
            Assert.AreEqual(LastDataExpected, lastData);

        }

        [TestMethod()]
        [ExpectedException(typeof(QueueException))]
        public void QeueuEnqueueMoreThanMaximum()
        {
            Queue queue = new Queue();
            queue.enqueue(1);
            queue.enqueue(2);
            queue.enqueue(3);
            queue.enqueue(4);
            queue.enqueue(5);
            queue.enqueue(6);
            queue.enqueue(7);
            queue.enqueue(8);
            queue.enqueue(9);
            queue.enqueue(10);
            queue.enqueue(11);

        }

        [TestMethod()]
        public void QeueuDequeueTest()
        {
            int firstDataExpected = 3;

            Queue queue = new Queue();
            queue.enqueue(1);
            queue.enqueue(2);
            queue.enqueue(3);
            queue.enqueue(4);
            queue.enqueue(5);
            queue.enqueue(6);
            queue.enqueue(7);

            queue.dequeue();            
            queue.dequeue();

            queue.enqueue(1);
            queue.enqueue(2);

            int firstData;
            firstData = queue._storage[0];

            Assert.AreEqual(firstDataExpected, firstData);
        }

        [TestMethod()]
        public void QeueuDequeueAfterCleaningTest()
        {
            int firstDataExpected = 1;

            Queue queue = new Queue();
            queue.enqueue(1);
            queue.enqueue(2);
           
            queue.dequeue();
            queue.dequeue();

            queue.enqueue(1);

            int firstData;
            firstData = queue._storage[0];

            Assert.AreEqual(firstDataExpected, firstData);
        }

        [TestMethod()]
        [ExpectedException(typeof(QueueException))]
        public void QeueuDequeueMoreThanMinimumTest()
        {
            Queue queue = new Queue();
            queue.enqueue(1);
            queue.enqueue(2);

            queue.dequeue();
            queue.dequeue();
            queue.dequeue();
        }

        [TestMethod()]
        public void QeueuDequeueSimpleTest()
        {
            int firstDataExpected = 0;

            Queue queue = new Queue();
            queue.enqueue(1);

            queue.dequeue();            

            int firstData;
            firstData = queue._storage[0];

            Assert.AreEqual(firstDataExpected, firstData);
        }

    }
}