using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Qn3
{
    public class ListManager
    {
        public void AddElement(List<int> list, int element)
        {
            if (list == null) throw new ArgumentNullException(nameof(list));
            list.Add(element);
        }

        public bool RemoveElement(List<int> list, int element)
        {
            if (list == null) throw new ArgumentNullException(nameof(list));
            return list.Remove(element);
        }

        public int GetSize(List<int> list)
        {
            if (list == null) throw new ArgumentNullException(nameof(list));
            return list.Count;
        }
    }
}