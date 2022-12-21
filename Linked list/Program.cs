using Linked_list;
using System.Collections.Generic;

namespace LinkedListProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList list= new LinkedList();
            Console.WriteLine("Adding Values in LinkedList");
            //list.Addnote(56);
            //list.Addnote(30);
            //list.Addnote(70);
            //list.Display();

            list.Addreverse(56);
            list.Addreverse(30);
            list.Addreverse(70);
            list.Display();
        }
    }
}