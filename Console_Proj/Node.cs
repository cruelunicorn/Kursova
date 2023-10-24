using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListClasses;

namespace TimetableDemonstration
{
    internal class Node
    {
        // Массив з двох елементів, перший по чисельнику, другий по знаменнику
        private string[] lessons, links = new string[2];
        public Node? next, previous;
        public Node(string[] lessons, string[] links, Node? next = null, Node? prev = null)
        {
            this.lessons = lessons;
            this.links = links;
        }
        public string[] GetLesson() {  return this.lessons; }
        public string[] GetLink() { return this.links; }
    }
}
