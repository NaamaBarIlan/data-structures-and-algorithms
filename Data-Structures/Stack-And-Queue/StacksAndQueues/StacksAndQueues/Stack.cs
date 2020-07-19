﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Stack
    {
        public Node Top { get; set; }

        public void Push(string value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }
    }
}
