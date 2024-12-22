using System.Collections;
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
sll.CopyTo(arr, 2);
Console.WriteLine(string.Join("", arr));
Console.WriteLine(sll.Remove("ddd"));
sll.PrintWholeList();
foreach (var item in sll) Console.WriteLine(item);
sll.Clear();
sll.PrintWholeList();

public interface ILinkedList<T> : ICollection <T>
{
    void AddToFront (T item);
    void AddToEnd (T item);
}

public class SiglyLinkedList<T> : ILinkedList<T?>
{
    private class Node
    {
        public T? Value { get; set; }

        public Node? Next { get; set; }

        public Node(T? value)
        {
            Value = value;
        }

        public override string ToString() =>
            $"Value: {Value}, " +
            $"Next: {(Next is null ? "null" : Next.Value)} ";
    }

    private Node? _head;

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
        var node = new Node (item);
        if (_head is null)
        {
            _head = node;
        }
        else 
        {
            var tail = GetNodes().Last();
            tail.Next = node;

        }
        _count += 1;
    }

    public void AddToFront(T? item)
    {
        var node = new Node(item);
        node.Next = _head;
        _head = node;
        _count += 1;
    }

    public void Clear()
    {
        var current = _head;
        while (current is not null)
        {
            var temp = current;
            current = current.Next;
            temp = null;
        }
        _head = null;
        _count = 0;
    }

    public bool Contains(T? item)
    {
        if (item is null) return GetNodes().Any(node => node.Value is null);
        return GetNodes().Any(node => node.Value!.Equals(item));
    }

    public void CopyTo(T?[] array, int arrayIndex)
    {
        if (array is null) throw new ArgumentNullException(nameof(array));
        if (arrayIndex < 0 || arrayIndex>= array.Length) throw new ArgumentOutOfRangeException(nameof(arrayIndex));
        if (array.Length < _count + arrayIndex) throw new ArgumentException("Array is not long enough");

        var item = _head;
        for (int i = arrayIndex; i < arrayIndex+_count; i++)
        {
            array[i] = item!.Value;
            item = item!.Next;
        }
        
    }

    public bool Remove(T? item)
    {
        if (_head == null) return false;
        if (_head!.Value!.Equals(item))
        {
            var temp = _head;
            _head = _head.Next;
            temp = null;
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
            var temp = nodeBeforeOneToDelete.Next;
            nodeBeforeOneToDelete.Next = nodeBeforeOneToDelete.Next.Next;
            temp = null;
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

    private IEnumerable<Node> GetNodes()
    {
        if (_head is null) yield break;
        Node node = _head;
        while (node is not null)
        {
            yield return node;
            node = node.Next!;
        }
    }

    public void PrintWholeList()
    {
        var current = _head;
        if (current is null) Console.WriteLine("List is empty - nothing to print!");
        while (current != null)
        {
            Console.WriteLine(current.ToString());
            current = current.Next;
        }
    }

}

