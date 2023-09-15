namespace ConsoleAppNet7
{
    internal class StackandQueue
    {

        public void StackProcess()
        {
            Stack<int> stackOfInt = new Stack<int>();
            stackOfInt.Push(0);
            stackOfInt.Push(1);
            stackOfInt.Push(2);
            stackOfInt.Push(3);

            stackOfInt.Pop();

            Console.WriteLine("--Stack process--");
            foreach (int i in stackOfInt)
            {
                Console.WriteLine(i);
            }

        }

        public void QueueProcess()
        {
            Queue<int> queueOfInt = new Queue<int>();

            queueOfInt.Enqueue(0);
            queueOfInt.Enqueue(1);
            queueOfInt.Enqueue(2);

            queueOfInt.Dequeue();

            Console.WriteLine("--Queue process--");
            foreach (int i in queueOfInt)
            {
                Console.WriteLine(i);
            }

        }

        
    }
}
