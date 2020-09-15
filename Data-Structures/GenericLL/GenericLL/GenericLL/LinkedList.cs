using System;
using System.Collections.Generic;
using System.Text;

namespace GenericLL
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Current { get; set; }

        public LinkedList()
        {
            Head = null;
        }
    }
}
