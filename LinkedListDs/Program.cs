using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDs
{
    public class program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            //linkedList.AddReverse(70);
            //linkedList.AddReverse(30);
            //linkedList.AddReverse(56);
            //linkedList.Display();
            //linkedList.Insert(1, 30);;
            //linkedList.Display();
            //linkedList.RemoveFirstElement();
            //linkedList.Display();
            //linkedList.RemoveLastNode();
            //linkedList.Display();
            //linkedList.Search(30);
            //linkedList.Display();
            int position = linkedList.Search(30);
            linkedList.Insert(position, 40);
            linkedList.Display();

        }
    }
}
