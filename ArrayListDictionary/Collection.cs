using System;
using System.Collections;

class Collection
{
    public void ArrayLit()
    {
        // create an ArrayList 
        ArrayList myArrayList = new ArrayList();

        // add some data to the ArrayList
        myArrayList.Add("apple");
        myArrayList.Add("banana");
        myArrayList.Add("cherry");

        // read data from the ArrayList
        Console.WriteLine("The first item in the ArrayList is: " + myArrayList[0]);

        // update data in the ArrayList
        myArrayList[1] = "pear";

        // delete data from the ArrayList
        myArrayList.RemoveAt(2);

        // print the remaining data in the ArrayList
        Console.WriteLine("The items in the ArrayList are:");
        foreach (string item in myArrayList)
        {
            Console.WriteLine(item);
        }
        Console.ReadLine();
    }
}
