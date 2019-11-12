using System;
using System.Collections.Generic;
using System.Text;

namespace useful_extentions
{
    public static class ListExtensions
    {
        public static int LastIndex<T>(this List<T> list)
        {
            return list.Count - 1;
        }
        public static T Last<T>(this List<T> list)
        {
            return list[list.Count - 1];
        }
    }
}
