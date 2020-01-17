using System;
using System.Collections.Generic;

public class CircularBuffer<T>
{
    int Capacity;
    Queue<T> Buffer;


    public CircularBuffer(int capacity)
    {
        this.Capacity = capacity;
        this.Buffer = new Queue<T>(capacity);
    }

    public T Read() // Read() means REMOVE!!!
    {

        //check to see if the size of the Buffer is empty
        if (this.Buffer.Count == 0)
        {
            throw new InvalidOperationException();
        }
        else
        {
            return this.Buffer.Dequeue();
        }

    }

    public void Write(T value)
    {
        if (this.Buffer.Count >= Capacity)
        {
            throw new InvalidOperationException();
        }
        else
        {
            this.Buffer.Enqueue(value);
        }
    }

    public void Overwrite(T value)
    {
        if (this.Buffer.Count<Capacity)
        {
            this.Buffer.Enqueue(value);
        }
        else
        {
            this.Buffer.Dequeue();
            this.Buffer.Enqueue(value);
        }
    }

    public void Clear()
    {
        this.Buffer.Clear();
    }
}