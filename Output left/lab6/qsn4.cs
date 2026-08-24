using System;
using System.Collections.Generic;

class Test
{
    static void Main()
    {
        List<int> list = new List<int>();
        list.Add(10);
        list.Add(20);

        Stack<int> stack = new Stack<int>();
        stack.Push(10);

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(20);

        LinkedList<int> linked = new LinkedList<int>();
        linked.AddLast(30);

        Dictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(1, "Ram");

        Console.WriteLine(list[0]);
        Console.WriteLine(stack.Pop());
        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(linked.First.Value);
        Console.WriteLine(dict[1]);
    }
}
