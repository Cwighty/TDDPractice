using MyCollections;

namespace TDDPractice
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void QueueIsEmpty()
        {
            var queue = new MyQueue(0);
            Assert.That(queue.IsEmpty());
        }
        [Test]
        public void QueueIsNotEmpty()
        {
            var queue = new MyQueue(1);
            queue.Enqueue(1);
            Assert.That(!queue.IsEmpty());
        }

        [Test]
        public void EnqueueBeyondCapacity()
        {
            var queue = new MyQueue(1);
            queue.Enqueue(1);
            Assert.Throws<InvalidOperationException>(() => queue.Enqueue(2));
        }

        [Test]
        public void CantDequeueWhenEmpty()
        {
            var queue = new MyQueue(0);
            Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
        }

        [Test]
        public void CanDequeueWhenNotEmpty()
        {
            var queue = new MyQueue(1);
            queue.Enqueue(1);
            Assert.That(queue.Dequeue() == 1);
        }

        [Test]
        public void CantDequeueWhenEmpty2()
        {
            var queue = new MyQueue(1);
            queue.Enqueue(1);
            queue.Dequeue();
            Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
        }

        [Test]
        public void CanEnqueueTwice()
        {
            var queue = new MyQueue(2);
            queue.Enqueue(1);
            queue.Enqueue(2);
            Assert.That(queue.Dequeue() == 1);
            Assert.That(queue.Dequeue() == 2);
        }

        [Test]
        public void CanEnqueueAndDequeue()
        {
            var queue = new MyQueue(3);
            queue.Enqueue(1);
            queue.Enqueue(2);
            Assert.That(queue.Dequeue() == 1);
            queue.Enqueue(3);
            queue.Enqueue(4);
            Assert.That(queue.Dequeue() == 2);
            Assert.That(queue.Dequeue() == 3);
        }
    }
}