using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice.Tree
{
    public class WordDictionary
    {

        public TrieNode root;

        /** Initialize your data structure here. */
        public WordDictionary()
        {
            root = new TrieNode();
        }

        public void AddWord(string word)
        {
            int length = word.Length;
            int index;

            TrieNode tmp = root;

            for (int level = 0; level < length; level++)
            {
                index = word[level] - 'a';

                if (tmp.children[index] == null)
                {
                    tmp.children[index] = new TrieNode();
                }
                tmp = tmp.children[index];
            }
            tmp.endOfWord = true;
        }

        public bool Search(string word)
        {
            return SearchHelper(word, 0, root);
        }

        private bool SearchHelper(string word, int index, TrieNode node)
        {
            if (node == null)
                return false;

            if (index == word.Length)
                return node.endOfWord;

            bool res = false;

            if (word[index] == '.')
            {
                for (int i = 0; i < 26; i++)
                {
                    res = res || SearchHelper(word, index + 1, node.children[i]);
                }
            }
            else
            {
                var j = word[index] - 'a';

                if (node.children[j] == null)
                    return false;

                res = res || SearchHelper(word, index + 1, node.children[j]);
            }

            return res;
        }
    }

    public class TrieNode
    {
        public bool endOfWord { get; set; }
        public TrieNode[] children = new TrieNode[26];

        public TrieNode()
        {
            endOfWord = false;
            for (int i = 0; i < 26; i++)
            {
                children[i] = null;
            }
        }
    }

    /**
     * Your WordDictionary object will be instantiated and called as such:
     * WordDictionary obj = new WordDictionary();
     * obj.AddWord(word);
     * bool param_2 = obj.Search(word);
     */
}
