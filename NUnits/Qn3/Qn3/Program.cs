using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qn3
{
    class Program
    {
        static void Main(string[] args)
        {
            ListManager listManager = new ListManager();
            List<int> list = new List<int>();
            listManager.AddElement(list, 1);
            listManager.AddElement(list, 2);
            listManager.AddElement(list, 3);
            listManager.AddElement(list, 4);
            listManager.AddElement(list, 5);
            Console.WriteLine("Size of list: " + listManager.GetSize(list));
            listManager.RemoveElement(list, 3);
            Console.WriteLine("Size of list after removing element: " + listManager.GetSize(list));
        }
    }
}
