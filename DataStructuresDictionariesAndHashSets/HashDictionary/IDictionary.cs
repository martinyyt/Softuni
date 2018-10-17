using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary> Interface that defines basic methods needed 
/// for a "dictionary" class which maps keys to values </summary> 
/// <typeparam name="TKey">Key type</typeparam> 
/// <typeparam name="TValue">Value type</typeparam> 
public interface IDictionary<TKey, TValue> :
  IEnumerable<KeyValuePair<TKey, TValue>>
{
    /// <summary> Assigns the specified value to the specified key in the dictionary. 
    /// If the key already exists, its value is replaced with the new value and the old 
    /// value is returned. </summary> 
    /// <param name="key">Key for the new value</param> 
    /// <param name="value">Value to be mapped to that key</param> 
    /// <returns>the old value for the specified  
    /// key or null if the key does not exist</returns> 
    TValue Set(TKey key, TValue value);

    /// <summary> Finds the value mapped to the given key </summary> 
    /// <param name="key">the key to be searched</param> 
    /// <returns>value for the specified key if present,  
    /// or null if there is no value with such key</returns> 
    TValue Get(TKey key);

    /// <summary> Gets or sets the value of the entry in the  
    /// dictionary identified by the specified key </summary> 
    /// <remarks>A new entry will be created if the value is set for 
    /// a key that is not currently in the Dictionary</remarks> 
    /// <param name="key">the key to identify the entry</param> 
    /// <returns>The value of the entry in the dictionary 
    /// identified by the provided key</returns> 
    TValue this[TKey key] { get; set; }

    /// <summary> Removes an element in the Dictionary  
    /// identified by a specified key </summary> 
    /// <param name="key">the key identifying the element for removal</param> 
    /// <returns>whether the element that was removed or not</returns> 
    bool Remove(TKey key);

    /// <summary> Returns the number of in the dictionary </summary> 
    int Count { get; }

    /// <summary> Removes all the elements from the dictionary </summary> 
    void Clear();
}
