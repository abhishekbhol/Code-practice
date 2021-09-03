using CodePractice.Exceptions;
using CodePractice.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice.Cache
{
    public class LRUCache : ICache
    {
        private DLLCache dll;
        private IDictionary<string, DoublyNodeCache> dict;

        public LRUCache(int cacheSize)
        {
            dll = new DLLCache(cacheSize);
            dict = new Dictionary<string, DoublyNodeCache>();
        }

        public object Peek()
        {
            var node = dll.head;
            if(node == null)
            {
                return null;
            }
            return node.value;
        }

        public object Get(string key)
        {
            if(!dict.ContainsKey(key))
            {
                return null;
            }

            var node =  dict[key];
            dll.DeleteNode(node);
            dict.Remove(node.key);

            dll.InsertAtStart(key, node.value);
            dict.Add(key, dll.head);

            return node.value;
        }

        public void Set(string key, object value)
        {
            if (!dict.ContainsKey(key))
            {
                try
                {
                    dll.InsertAtStart(key, value);
                    var node = dll.head;
                    dict.Add(key, node);
                }
                catch(LinkedListFullException e)
                {
                    var nodeToBeDeleted = dll.tail;
                    dll.DeleteFromEnd();
                    dict.Remove(nodeToBeDeleted.key);

                    dll.InsertAtStart(key, value);                    
                    dict.Add(key, dll.head);
                }
            }
            else
            {
                var node = dict[key];
                dll.DeleteNode(node);
                dict.Remove(node.key);

                dll.InsertAtStart(key, value);
                dict.Add(key, dll.head);
            }
        }
    }
}
