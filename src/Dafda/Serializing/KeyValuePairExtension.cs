using System.Collections.Generic;

namespace Dafda.Serializing
{
    internal static class KeyValuePairExtension
    {
        public static void Deconstruct<TKey, TValue>(this KeyValuePair<TKey, TValue> source, out TKey Key, out TValue Value)
        {
            Key = source.Key;
            Value = source.Value;
        }
    }
}