using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDictionary
{
    internal class Dictionarycrud
    {
        public void Operation()
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            // add some data to the Dictionary
            myDictionary.Add(1, "apple");
            myDictionary.Add(2, "banana");
            myDictionary.Add(3, "cherry");

            // read data from the Dictionary
            string value;
            if (myDictionary.TryGetValue(1, out value))
            {
                Console.WriteLine("The value associated with key 1 is: " + value);
            }

            // update data in the Dictionary
            myDictionary[2] = "pear";

            // delete data from the Dictionary
            myDictionary.Remove(3);

            // print the remaining data in the Dictionary
            Console.WriteLine("The items in the Dictionary are:");
            foreach (KeyValuePair<int, string> item in myDictionary)
            {
                Console.WriteLine("Key: " + item.Key + " Value: " + item.Value);
            }

            // wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
