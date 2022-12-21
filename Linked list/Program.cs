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
            list.Addnote(70);
            list.Addnote(30);
            list.Addnote(56);
            list.Display();
        }
    }
}