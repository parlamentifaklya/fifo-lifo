using fifo_lifo;

class Program
{
    static void Main(string[] args)
    {
        LIFO stack = new LIFO(5);

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine($"Popped element: {stack.Pop()}");
        Console.WriteLine($"Popped element: {stack.Pop()}");

        Console.WriteLine($"Stack length: {stack.Length()}");
        Console.WriteLine($"Stack size: {stack.GetSize()}");

        stack.Clear();
        Console.WriteLine($"Stack length after clear: {stack.Length()}");

        Console.WriteLine("-----");

        FIFO queue = new FIFO(5);

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Console.WriteLine($"Front of the queue: {queue.Peek()}");

        Console.WriteLine($"Dequeued element: {queue.Dequeue()}");
        Console.WriteLine($"Dequeued element: {queue.Dequeue()}");

        Console.WriteLine($"Queue length: {queue.Length()}");
        Console.WriteLine($"Queue size: {queue.GetSize()}");

        queue.Clear();
        Console.WriteLine($"Queue length after clear: {queue.Length()}");
    }
}