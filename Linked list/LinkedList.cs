using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linked_list
{
    public class LinkedList
    {
        Node head;
        public void Addnote(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("List contains");
                Console.ResetColor();
                Node tempnode = head;
                while (tempnode != null)
                {
                    Console.WriteLine( tempnode.data  );
                    tempnode = tempnode.Next;
                }
                Console.WriteLine("\n");
            }
        }
        public void Addreverse(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                head = node;
                head.Next = temp;

            }
        }
        public void insert (int Position,int data)
        {
           Node node=new Node(data);
            if(Position == 1)
            {
                node.Next= head;
                head= node;
            }
            else
            {
                Node temp = head;
                while(Position>2)
                {
                    temp=temp.Next;
                    Position--;
                }
                node.Next= temp.Next;
                temp.Next = node;
            }

        }
        public void deleteFirst ()
        {
            Node node = head;
            if (head!= null)
            {
                node = head;
                head = head.Next;
                node = null;
            }
            
        }
        public void deleteLast ()
        {
            Node node = head;
            Node lastnode= node.Next;
            if(head!=null)
            {
                node = node.Next;
                node.Next = null;
                lastnode = null;

            }
        }
    }
}
