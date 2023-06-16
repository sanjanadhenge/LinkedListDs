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
            linkedList.Display();

        }
    }
}
