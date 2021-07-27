using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun4.Odev5.MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] dictionaryKey;
        TValue[] dictionaryValue;

        TKey[] tempKey;
        TValue[] tempValue;

        public MyDictionary()
        {
            dictionaryKey = new TKey[0];
            dictionaryValue = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            tempKey = dictionaryKey;
            tempValue = dictionaryValue;

            dictionaryKey = new TKey[dictionaryKey.Length + 1];
            dictionaryValue = new TValue[dictionaryValue.Length + 1];

            for(int i = 0; i < tempKey.Length; i++)
            {
                dictionaryKey[i] = tempKey[i];
                dictionaryValue[i] = tempValue[i];
            }

            dictionaryKey[dictionaryKey.Length - 1] = key;
            dictionaryValue[dictionaryValue.Length - 1] = value;
        }

        //public int Count
        //{
        //    get { return dictionaryKey.Length; }
        //}
    }
}
