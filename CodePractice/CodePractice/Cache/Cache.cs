using CodePractice.Exceptions;
using CodePractice.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice.Cache
{
    public class LRUCache : ICache
    {
        public DLLCache dll;
        public IDictionary<string, DoublyNodeCache> dict;

        public LRUCache(int cacheSize)
        {
            dll = new DLLCache(cacheSize);
            dict = new Dictionary<string, DoublyNodeCache>();
        }

        public string Get(string key)
        {
            if(!dict.ContainsKey(key))
            {
                return null;
            }

            var node =  dict[key];
            dll.DeleteNode(node);
            dll.InsertAtStart(node.data);
            return node.data;
        }

        public void Set(string key, string value)
        {
            if (!dict.ContainsKey(key))
            {
                try
                {
                    dll.InsertAtStart(value);
                    var node = dll.head;
                    dict.Add(key, node);
                }
                catch(LinkedListFullException e)
                {
                    dll.DeleteFromEnd();
                    dll.InsertAtStart(value);
                    var node = dll.head;
                    dict.Add(key, node);
                }
            }
            else
            {
                var node = dict[key];
                dll.DeleteNode(node);
                dll.InsertAtStart(value);
            }
        }
    }
}
