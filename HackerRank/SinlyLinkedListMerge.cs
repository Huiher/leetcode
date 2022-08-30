using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerRank
{
    class SinglyLinkedListNode {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData) {
            this.data = nodeData;
            this.next = null;
        }
    }

    class SinglyLinkedList {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList() {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData) {
            SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

            if (this.head == null) {
                this.head = node;
            } else {
                this.tail.next = node;
            }

            this.tail = node;
        }
    }

    public class SinlyLinkedListMerge
    {
        static SinglyLinkedListNode mergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2) 
        {
            // Check if either of this is null
            if (head1 == null || head2 == null)
            {
                return head1 == null ? head2 : head1;
            }
            
            var linkedListValues = new List<int>();
            
            var cursor1 = head1;
            linkedListValues.Add(head1.data);
            
            while(cursor1.next != null)
            {
                cursor1 = cursor1.next;
                linkedListValues.Add(cursor1.data);
            }
            
            var cursor2 = head2;
            linkedListValues.Add(head2.data);
            while (cursor2.next != null)
            {
                cursor2 = cursor2.next;
                linkedListValues.Add(cursor2.data);
            }
            
            var sortedList = linkedListValues.OrderBy(x => x).ToList();
            var linkedList = new SinglyLinkedList();
            foreach(int v in sortedList)
            {
                linkedList.InsertNode(v);
            }
            
            return linkedList.head;
        }
    }
}