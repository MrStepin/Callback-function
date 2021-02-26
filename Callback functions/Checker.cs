using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

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

    public static class MassiveExtentions
    {
        public static bool AnyNum(this int[] massive, Func<int, bool> predicate)
        {
            foreach (int num in massive)
            {
                if (predicate(num))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool AllNum(this int[] massive, Func<int, bool> predicate)
        {
            foreach (int num in massive)
            {
                if (!predicate(num))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
