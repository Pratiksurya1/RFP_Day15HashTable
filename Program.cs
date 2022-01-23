using System;
using System.Collections.Generic;
using System.Linq;

namespace HashTableAndBst
{
    class Program
    {
        static void Main(string[] args)
        {
            HashNode<string, int> myMapNode = new HashNode<string, int>(6);
            string[] words = { "to", "be", "or", "not", "to", "be" };
            int count = 1;
            foreach (string i in words)
            {
                count = myMapNode.CheckHash(i);
                if (count > 1)
                {
                    myMapNode.Add(i, count);
                }
                else
                {
                    myMapNode.Add(i, 1);
                }
            }
            IEnumerable<string> uniqueItems = words.Distinct<string>();
            foreach (var i in uniqueItems)
            {
                myMapNode.Display(i);
            }
        }
    }
}