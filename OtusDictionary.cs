using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Basic_11_L035;

internal class OtusDictionary()
{
    public static int Capacity = 32;
    public static int Size; 
   
    private struct Entry
    {
        public int Key;
        public string? Value;
    }
    private Entry[] _words = new Entry[Capacity];    
    public string? this[int k]
    {
        get
        { 
            return Get(k);            
        }
        set
        {
            Add(k, value);
        }
    }
    private int GetHashKey(int key)
    {
        return key % Capacity;        
    }
    public void Add(int key, string? value) 
    {
        if (value is not null)
        {
            int hashKey = GetHashKey(key);
            if (_words[hashKey].Value is null)
            {
                _words[hashKey].Key = key;
                _words[hashKey].Value = value;
                Size++;
            }
            else
            {
                var buffer = new Entry[Capacity];
                Array.Copy(_words, 0, buffer, 0, Capacity - 1);

                Capacity *= 2;
                _words = new Entry[Capacity];
                                
                foreach (var word in buffer)
                {
                    _words[GetHashKey(word.Key)] = word;                    
                }
                Add(key, value);
            }
        }
    }
    public string? Get(int key)
    {
        return _words[GetHashKey(key)].Value;       
    }    
}
