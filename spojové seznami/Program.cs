using System.Diagnostics.Tracing;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;

namespace spojové_seznami;

class Program
{
    static void Main(string[] args)
    {
        Node uzlik = new Node(7);
        
    }
    class Node
    {
        public Node(int value)//konstrukor třídy Node
        {
            Value = value;
        }
        public int Value { get; }
        public Node Next { get; set; }
    }
    class LInkedList
    {
        public Node Head { get; set; }

        public void Add(int value)//p5idat prvek do seznamu
        {
            if (Head == null)//kdyz seznam je atim  prazdny
                Head = new Node(value)
            else
            {
                Node newNode = new Node(vaule);
                newNode.Next = Head;
                Head = newNode;
            }

        }

    }
    public bool Find(int value)
    {
        if (Header == null)//prazdny sezxnam
            return false;
        Node node = Header;
        while (node != null) 
        {
            if (node.Value == value)
                return true;
            node = node.Next;
        }
        return false;
    }
}



