﻿using System.Collections;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

var sll = new SiglyLinkedList<string>();
sll.AddToEnd("aaa");
sll.AddToFront("ddd");
sll.Add("ooo");
sll.PrintWholeList();
Console.WriteLine(sll.Contains("aaa"));
Console.WriteLine(sll.Contains("zzz"));
var arr = new string[] {"!","£","$","%","&","*","(",")","-","_","+","="};
Console.WriteLine(string.Join("", arr));
sll.CopyTo(arr, 3);
Console.WriteLine(string.Join("", arr));
Console.WriteLine(sll.Remove("ddd"));
sll.PrintWholeList();
foreach (var item in sll) Console.WriteLine(item);


public class Node<T>
{
    public T? Value { get; set; }

    public Node<T>? Next { get; set; }

    public Node (T? value)
    {
        Value = value;
    }

    public override string ToString() =>
        $"Value: {Value}, " +
        $"Next: {(Next is null ? "null" : Next.Value)} ";
}

public interface ILinkedList<T> : ICollection <T>
{
    void AddToFront (T item);
    void AddToEnd (T item);
}

public class SiglyLinkedList<T> : ILinkedList<T?>
{
    private Node<T>? _head;

    private int _count;

    public SiglyLinkedList ()
    {
        _head = null;
        _count = 0;
    }

    public int Count => _count;

    public bool IsReadOnly => false;

    public void Add(T? item)
    {
        AddToEnd(item);
    }

    public void AddToEnd(T? item)
    {
        var node = new Node<T> (item);
        if (_head == null)
        {
            _head = node;
        }
        else 
        {
            var index = _head;
            while (index.Next != null)
            {
                index = index.Next;
            };
            index.Next = node;

        }
        _count += 1;
    }

    public void AddToFront(T? item)
    {
        var node = new Node<T>(item);
        node.Next = _head;
        _head = node;
        _count += 1;
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(T? item)
    {
        var index = _head;
        while (index != null)
        {
            if (index.Value!.Equals(item)) return true;
            index = index.Next;
        }
        return false;
    }

    public void CopyTo(T?[] array, int arrayIndex)
    {
        try
        {
            var item = _head;
            for (int i = arrayIndex; i < arrayIndex+_count; i++)
            {
                array[i] = item!.Value;
                item = item!.Next;
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine(e);
            throw e;
        }
        
    }

    public bool Remove(T? item)
    {
        if (_head == null) return false;
        if (_head!.Value!.Equals(item))
        {
            _head = _head.Next;
            _count -= 1;
            return true;
        }

        var nodeBeforeOneToDelete = _head;
        while (!nodeBeforeOneToDelete.Next!.Value!.Equals(item) && nodeBeforeOneToDelete.Next != null)
        {
            nodeBeforeOneToDelete = nodeBeforeOneToDelete.Next;
            if (nodeBeforeOneToDelete.Next == null) return false;
        }
        if (nodeBeforeOneToDelete.Next == null) return false;
        else
        {
            nodeBeforeOneToDelete.Next = nodeBeforeOneToDelete.Next.Next;
            _count -= 1;
            return true;

        }

    }

    public IEnumerator<T?> GetEnumerator()
    {
        foreach (var node in GetNodes())
        {
            yield return node.Value;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private IEnumerable<Node<T>> GetNodes()
    {
        if (_head is null) yield break;
        Node<T> node = _head;
        while (node is not null)
        {
            yield return node;
            node = node.Next!;
        }
    }

    public void PrintWholeList()
    {
        var index = _head;
        while (index != null)
        {
            Console.WriteLine(index.ToString());
            index = index.Next;
        }
    }

}
