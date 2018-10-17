using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashDictionary
{
    /// <summary> A structure holding a pair {key, value} </summary> 
    /// <typeparam name="TKey">the type of the keys</typeparam> 
    /// <typeparam name="TValue">the types of the values</typeparam> 
    public struct KeyValuePair<TKey, TValue>
    {
        /// <summary> Constructs a pair by given key and value </summary> 
        public KeyValuePair(TKey key, TValue value)
        {
            this.Key = key;
            this.Value = value;
        }

        /// <summary> Holds the key of the key-value pair </summary> 
        public TKey Key { get; private set; }

        /// <summary> Holds the value of the key-value pair </summary> 
        public TValue Value { get; private set; }

        /// <summary> Converts the key-value pair to a printable text </summary>  
        public override string ToString() => $"[{this.Key}, {this.Value}]";
    }
}
