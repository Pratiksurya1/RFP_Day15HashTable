using System;
using System.Collections.Generic;
using System.Linq;

namespace HashTableAndBst
{
    class Program
    {
        static void Main(string[] args)
        {
            //HashNode<string, int> myMapNode = new HashNode<string, int>(6);
            //string[] words = { "to", "be", "or", "not", "to", "be" };
            //int count = 1;
            //foreach (string i in words)
            //{
            //    count = myMapNode.CheckHash(i);
            //    if (count > 1)
            //    {
            //        myMapNode.Add(i, count);
            //    }
            //    else
            //    {
            //        myMapNode.Add(i, 1);
            //    }
            //}
            //IEnumerable<string> uniqueItems = words.Distinct<string>();
            //foreach (var i in uniqueItems)
            //{
            //    myMapNode.Display(i);
            //}

            // UC 2


            HashNode<string, int> myMap = new HashNode<string, int>(10);
            string[] Paragraph;
            string input = "are Paranoids are not paranoid because but they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            Paragraph = input.Split(' ');
            int counts = 1;
            foreach (string i in Paragraph)
            {
                counts = myMap.CheckHash(i);
                if (counts > 1)
                {
                    myMap.Add(i, counts);
                }
                else
                {
                    myMap.Add(i, 1);
                }
            }
            Console.WriteLine("\nFrequency of words in paragraph\n");
            IEnumerable<string> distinct = Paragraph.Distinct<string>();
            foreach (var i in distinct)
            {
                myMap.Display(i);
            }



        }
    }
}