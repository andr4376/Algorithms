using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class MyLinkedList<T> : IEnumerable
    {

        private Node headNode; //the first node in the list


        public MyLinkedList()
        {
            headNode = null;
        }

        public Node Last()
        {
            return headNode;
        }

        public void AddToEnd(object node)
        {
            //if this is the last one
            if (headNode == null)
            {
                headNode = new Node(node);
            }
            else
            {
                //try next one
                headNode.AddToEnd(node);

            }

        }

        

        public void AddToBeginning(object node)
        {

            if (headNode == null)//if there's not a node in the beginning
            {
                headNode = new Node(node);

            }
            else
            {
                //puts this node in the beginning and move the previous "First node" a step down

                Node tmp = new Node(node);

                tmp.Next = headNode;

                headNode = tmp;
            }


        }

        public void Print()
        {
            if (headNode != null)
            {
                headNode.Print();
            }
        }

        /// <summary>
        /// Returns each of the nodes in the "collection"
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            Node current = headNode;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

    


    }
}
