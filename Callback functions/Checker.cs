using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callback_functions
{
    public class Checker<T>
    {
        public List<T> ResultList(T[] massive, Func<T, bool> predicate)
        {
            List<T> resultList = new List<T>();
            foreach (T num in massive)
            {
                if (predicate(num))
                {
                    resultList.Add(num);
                }
            }
            return resultList;
        }
    }
}
