using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TimetableDemonstration
{
    internal class TimeTableList
    {
        private Node head, last;
        private int lenght;
        private readonly string day;
        public TimeTableList(string day, string[] lessons, string[] links)
        {
            this.day = day;
            head = new Node(lessons, links, head, head);
            head.next = head;
            head.previous = head;
            last = head;
            lenght = 1;
        }

        public void Add(string[] lessons, string[] links)
        {

            if (head is null)
            {
                head = new Node(lessons, links);
            }
            else
            {
                Node newNode = new(lessons, links, head, last);
                last.next = newNode;
                last = newNode;
            }

            lenght++;
        }
        public void Remove(int pairNumber)
        {
            if (head is null) return;
            if (pairNumber < 1 || pairNumber > 6) { return; }
            if (pairNumber == 1)
            {
                head = (Node)head.next!;
                head.previous = last;
                last.next = head;
                lenght--;
                return;
            }
            if (pairNumber == lenght)
            {
                last = (Node)last.previous!;
                last.next = head;
                head.previous = last;
                lenght--;
                return;
            }

            Node? current = head;

            for (int i = 1; i < lenght ; i++)
            {
                if (i == pairNumber) break;
                current = current!.next;
            }

            current!.previous!.next = current.next;
            current!.next!.previous = current.previous;
            current.next = null;
            current.previous = null;
            lenght--;

        }
        
        public int GetLenght()
        {
            return lenght;
        }
    }
}