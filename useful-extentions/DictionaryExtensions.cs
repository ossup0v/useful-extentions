using System;
using System.Collections.Generic;
using System.Text;

namespace useful_extentions
{
    public static class DictionaryExtenstions
    {
        public static void RenameKey<TKey, TValue>(this IDictionary<TKey, TValue> dic, TKey fromKey, TKey toKey)
        {
            TValue value = dic[fromKey];
            dic.Remove(fromKey);
            dic.Add(toKey, value);
        }
    }
}
