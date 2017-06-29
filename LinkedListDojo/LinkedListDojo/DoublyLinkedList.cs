﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDojo
{
    public class DoublyLinkedList
    {
        private Node head;

        public void printLinkedListElements()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
            Console.ReadKey();
        }

        public DoublyLinkedList() { }

        public void Add(Object value) {
            if (head == null)
            {
                Node newData = new Node();
                newData.value = value;
                newData.next = head;
                newData.prevoius = null;
                head = newData;
            }
            else
            {
                Node newData = new Node();
                newData.value = value;
              
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                    Node previous = current.prevoius;
                }
                current.next = newData;
            }
        }

        public void Remove(Object value) { }

        public void Insert(int index, Object value) { }

        public void Reverse() { }
    }
}
