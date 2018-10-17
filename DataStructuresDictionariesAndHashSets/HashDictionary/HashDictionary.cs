using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashDictionary
{
    /// <summary> Implementation of <see cref="IDictionary"/> interface 
    /// using hash table. Collisions are resolved by chaining. </summary> 
    /// <typeparam name="TKey">Type of the keys. Keys are required to  
    /// correctly implement Equals() and GetHashCode()</typeparam> 
    /// <typeparam name="TValue">Type of the values</typeparam> 
    public class HashDictionary<TKey, TValue>
          : IEnumerable<KeyValuePair<TKey, TValue>> 
    {
        private const int DEFAULT_CAPACITY = 16;
        private const float DEFAULT_LOAD_FACTOR = 0.75f;

        private List<KeyValuePair<TKey, TValue>>[] table;
        private float loadFactor;
        private int threshold;
        private int size;
        private int initialCapacity;
        /// <summary> Creates an empty has table with the default  
        /// capacity and load factor </summary> 
        public HashDictionary()
          : this(DEFAULT_CAPACITY, DEFAULT_LOAD_FACTOR)
        {
        }

        /// <summary> Creates an empty has table with the given  
        /// capacity and load factor </summary> 
        public HashDictionary(int capacity, float loadFactor)
        {
            this.initialCapacity = capacity;
            this.table = new List<KeyValuePair<TKey, TValue>>[capacity];
            this.loadFactor = loadFactor;

            unchecked
            {
                this.threshold = (int)(capacity * this.loadFactor);
            }
        }

        /// <summary> Clears all elements of the hash table </summary> 
        public void Clear()
        {
            this.table =
              new List<KeyValuePair<TKey, TValue>>[initialCapacity];
            this.size = 0;
        }

        /// <summary> Finds the chain of elements corresponding internally 
        /// to a given key (by its hash code) </summary> 
        /// <param name="createIfMissing">creates an empty list of elements     
        /// if the chain still does not exist</param> 
        /// <returns>a list of elements in the chain or null</returns> 
        private List<KeyValuePair<TKey, TValue>> FindChain(
          TKey key, bool createIfMissing)
        {
            int index = key.GetHashCode();
            index = index & 0x7FFFFFFF; // clear the negative bit 
            index = index % this.table.Length;

            if (this.table[index] == null && createIfMissing)
            {
                this.table[index] = new List<KeyValuePair<TKey, TValue>>();
            }
            return this.table[index] as List<KeyValuePair<TKey, TValue>>;
        }
        /// <summary> Finds the value assigned to given key (extremely fast) </summary> 
        /// <returns>the value found or null when not found</returns> 
        public TValue Get(TKey key)
        {
            var chain = this.FindChain(key, false);

            if (chain != null)
            {
                foreach (var entry in chain)
                {
                    if (entry.Key.Equals(key))
                    {
                        return entry.Value;
                    }
                }
            }

            // Key not found --> return default value (zero / null). Alternatively, you can throw 
            // KeyNotFoundException, like in the Dictionary<TKey, TValue> class in .NET 
            return default(TValue);
        }

        /// <summary> Gets/sets the value by given key. Get returns null 
        /// when the key is not found. Set replaces the existing 
        /// value or creates a new key-value pair if the key 
        /// does not exists. Works very fast. </summary> 
        public TValue this[TKey key]
        {
            get => this.Get(key);
            set => this.Set(key, value);
        }

        /// <summary> Returns the number of key-value pairs in the hash table </summary> 
        public int Count => this.size;

        /// <summary> Assigns a value to certain key. If the key exists,  
        /// its value is replaced. If the key does not exist, 
        /// it is first created. Works very fast. </summary> 
        /// <returns>the old (replaced) value or null</returns> 
        public TValue Set(TKey key, TValue value)
        {
            if (this.size >= this.threshold)
            {
                this.Expand();
            }

            var chain = this.FindChain(key, true);

            for (int i = 0; i < chain.Count; i++)
            {
                KeyValuePair<TKey, TValue> entry = chain[i];

                if (entry.Key.Equals(key))
                {
                    // Key found -> replace its value with the new value 
                    var newEntry = new KeyValuePair<TKey, TValue>(key, value);
                    chain[i] = newEntry;

                    return entry.Value;
                }
            }

            chain.Add(new KeyValuePair<TKey, TValue>(key, value));
            this.size++;

            return default(TValue);
        }

        /// <summary> Expands the underling hash table. Creates 2 times  
        /// bigger table and transfers the old elements into it. 
        /// This is a slow operation: O(n) </summary> 
        private void Expand()
        {
            int newCapacity = 2 * this.table.Length;
            var oldTable = this.table;

            this.table = new List<KeyValuePair<TKey, TValue>>[newCapacity];
            this.threshold = (int)(newCapacity * this.loadFactor);

            foreach (var oldChain in oldTable)
            {
                if (oldChain != null)
                {
                    foreach (var keyValuePair in oldChain)
                    {
                        var chain = FindChain(keyValuePair.Key, true);
                        chain.Add(keyValuePair);
                    }
                }
            }
        }

        /// <summary> Removes a key-value pair specified by certain key 
        /// from the hash table. </summary> 
        /// <returns>true if the pair was found and removed or false  
        /// if the key was not found</returns> 
        public bool Remove(TKey key)
        {
            var chain = this.FindChain(key, false);

            if (chain != null)
            {
                for (int i = 0; i < chain.Count; i++)
                {
                    KeyValuePair<TKey, TValue> entry = chain[i];

                    if (entry.Key.Equals(key))
                    {
                        // Key found -> remove it 
                        chain.RemoveAt(i);
                        this.size--;

                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary> Implements the IEnumerable<KeyValuePair<TKey, TValue> 
        /// to allow iterating over the key-value pairs in the 
        /// hash table in foreach loops </summary> 
        IEnumerator<KeyValuePair<TKey, TValue>>
          IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
        {
            foreach (var chain in this.table)
            {
                if (chain != null)
                {
                    foreach (var entry in chain)
                    {
                        yield return entry;
                    }
                }
            }
        }

        /// <summary> Implements the IEnumerable (non-generic) as part of  
        /// IEnumerable<KeyValuePair<TKey, TValue> </summary> 
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<KeyValuePair<TKey, TValue>>)this)
              .GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
