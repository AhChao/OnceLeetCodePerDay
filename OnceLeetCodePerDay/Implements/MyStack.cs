using System.Collections.Generic;

namespace OnceLeetCodePerDay.Implements;

public class MyStack
{
    private Queue<int> _queue;
    private int _topElement;

    public MyStack()
    {
        _queue = new Queue<int>();
    }

    public void Push(int x)
    {
        _queue.Enqueue(x);
        _topElement = x;
    }

    public int Pop()
    {
        var tempQueue = new Queue<int>();
        var dequeued = 0;
        while(_queue.Count > 0)
        {
            dequeued = _queue.Dequeue();
            if(_queue.Count > 0)
            {
                tempQueue.Enqueue(dequeued);
                _topElement = dequeued;
            }
        }

        _queue = tempQueue;
        return dequeued;
    }

    public int Top()
    {
        return _topElement;
    }

    public bool Empty()
    {
        return _queue.Count == 0;
    }
}