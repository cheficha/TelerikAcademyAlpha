using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImplement
{
    public class MyLinked<T> 
    {
        public class Node
        {
            private T value;
            private Node next;
            private Node previous;

            public Node(T value)
            {
                this.value = value;
                this.next = null;
                this.previous = null;
            }
            public Node(T value, Node nextNode)
            {
                this.value = value;
                this.next = nextNode;
            }

            public Node(T value, Node prevNode, Node nextNode)
            {
                this.value = value;
                this.next = nextNode;
                this.previous = prevNode;
            }
            public T Value { get { return this.value; } set { this.value = value; } }
            public Node Next { get { return this.next; } set { this.next = value; } }
            public Node Previous { get { return this.previous; } set { this.previous = value; } }

        }
        private Node head;
        private Node tail;
        private int count;


        public MyLinked()
        {
            head = tail = null;

            count = 0;
        }
        public Node First { get { return this.head; } }

        public Node Last { get { return this.tail; } }

        public int Count { get { return this.count; } }

       

        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public void AddFirst(T data)
        {
            if (IsEmpty() == true)
            {
                this.head = new Node(data);
                this.tail = this.head;
            
            }
            else
            {
                Node temp = head;
                head = new Node(data);
                head.Next = temp;
                temp.Previous = head;
            }
        }
        public void AddLast(T data)
        {
            Node temp = tail;
            tail = new Node(data);
            tail.Previous = temp;
            temp.Next = tail;
            count++;
        }
        public void AddAfter(Node current, T data)
        {
            Node newNode = new Node(data);

            if (current.Equals(tail))
            {
                Node temp = tail;
                tail = newNode;
                tail.Previous = temp;
                temp.Next = tail;
                count++;
            }
          
            else
            {

                newNode.Previous = current;
                newNode.Next = current.Next;
                current.Next = newNode;
                current.Next.Next.Previous = newNode;
                count++;

            }

        }
        public void AddBefore(Node current, T data)
        {
            Node newNode = new Node(data);

            if (current.Equals(head))
            {

                Node temp = head;
                head = newNode;
                head.Next = temp;
                temp.Previous = head;
                count++;

            }
            else
            {
                AddAfter(current.Previous,data);

            }

        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            Node current = head;
            while (current!=null)
            {
                sb.AppendLine($"{current.Value}");
                current = current.Next;
            }
            return sb.ToString().Trim();

        }


    }


}

