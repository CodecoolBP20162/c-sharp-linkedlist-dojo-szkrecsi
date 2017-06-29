using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDojo
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.Add(1);
            list.Add(3);
            list.printLinkedListElements();
        }
    }
}
