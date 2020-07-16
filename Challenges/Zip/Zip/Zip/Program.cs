using System;
using System.Collections.Generic;
using LinkedListLibrary;

namespace Zip
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lists!");
        }

        /// <summary>
        /// This method takes two linked lists as arguments, zips them together into one, so that the nodes alternate between the two lists
        /// <param name="list1">A first linked list object</param>
        /// <param name="list2">A second linked list object</param>
        /// <returns>A reference to the head of the zipped linked list</returns>
        public static Node ZipLists(LinkedList list1, LinkedList list2)
        {
            LinkedList zippedList = new LinkedList();
            Node current = zippedList.Head;
            list1.Current = list1.Head;
            list2.Current = list2.Head;

            int count = 0;

            while (list1.Current != null && list2.Current != null)
            {
                if (count % 2 == 0)
                {
                    zippedList.Append(list1.Current.Value);
                    list1.Current = list1.Current.Next;
                    count++;
                }
                else
                {
                    zippedList.Append(list2.Current.Value);
                    list2.Current = list2.Current.Next;
                    count++;
                }
            }

            while (list1.Current != null)
            {
                zippedList.Append(list1.Current.Value);
                list1.Current = list1.Current.Next;
            }

            while (list2.Current != null)
            {
                zippedList.Append(list2.Current.Value);
                list2.Current = list2.Current.Next;
            }

            zippedList.Current = zippedList.Head;
            return zippedList.Head;
        }
    }
}
