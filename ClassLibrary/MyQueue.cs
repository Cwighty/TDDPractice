namespace MyCollections
{
    public class MyQueue
    {
        private int size;
        private int tail = -1;
        private int head = 0;
        private int count = 0;
        private int[] numbers;
        public MyQueue(int size)
        {
            this.size = size;
            numbers = new int[size];
        }
        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException();
            }
            else
            {
                int item = numbers[head];
                head = (head + 1) % size;
                count--;
                return item;
            }
        }

        public void Enqueue(int num)
        {
            if (IsFull())
            {
                throw new InvalidOperationException();
            }
            else
            {
                tail = (tail + 1) % size;
                numbers[tail] = num;
                count++;
            }
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public bool IsFull()
        {
            return count == size;
        }
    }
}