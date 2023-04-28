using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Collection collection = new Collection();
            collection.ArrayLit();

            Dictionarycrud dictionarycrud = new Dictionarycrud();
            dictionarycrud.Operation();
        }
    }
}
