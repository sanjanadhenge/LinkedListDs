using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDs
{
    internal class LinkedList
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Linked List", node.data);
        }
        public void AddReverse(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
                head.next = temp;
            }
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + "  ");
                temp = temp.next;
            }

        }
        public void Insert(int Position, int data)
        {
            Node node1 = new Node(data);
            if (this.head == null)
            {
                this.head = node1;
            }
            if (Position == 0)
            {
                node1.next = this.head;
                this.head = node1;
                return;
            }
            Node prev = null;
            Node current = this.head;
            int count = 0;
            while (current != null && count < Position)
            {
                prev = current;
                current = current.next;
                count++;

            }
            node1.next = prev.next;
            prev.next = node1;
        }
        public void RemoveFirstElement()
        {
            if (this.head == null)
            {
                Console.WriteLine("List is Empty");
            }

            this.head = this.head.next;
        }
        public void RemoveLastNode()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            Node node2 = head;
            if (head.next == null)
            {
                this.head = null;
            }
            while (node2.next.next != null)
            {
                node2 = node2.next;
            }
            node2.next = null;
        }
        public int Search(int value)
        {
            Node node = this.head;
            int count = 0;
            while (node.next != null)
            {
                if (node.data.Equals(value))
                {
                    Console.WriteLine(count);
                }
                node = node.next;
                count++;

            }
            return count;

        }
        public void DeleteNodeAtParticularPosition(int position)
        {
            if (this.head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Node temp = this.head;
            if (position == 0)
            {
                this.head = temp.next;
            }
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }
            if (temp == null || temp.next == null)
            {
                return;
            }
            Node next = temp.next.next;
            temp.next = next;
            Size();
        }
        public void Size()
        {
            int count = 0;
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine("Size is " + count);
        }

    }
}
