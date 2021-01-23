using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionaryy
{
    class MyDictionary<T, D>
    {

        T[] _arrayKey;
        D[] _arrayValue;



        public MyDictionary() //constructor
        {
            _arrayKey = new T[0];
            _arrayValue = new D[0];
        }
        public void Add(T key, D value)
        {
            T[] _tempKey = _arrayKey;
            _arrayKey = new T[_arrayKey.Length + 1];

            D[] _tempValue = _arrayValue;
            _arrayValue = new D[_arrayValue.Length + 1];


            for (int i = 0; i < _tempKey.Length; i++)
            {


                _arrayKey[i] = _tempKey[i];
                _arrayValue[i] = _tempValue[i];
            }
            _arrayKey[_arrayKey.Length - 1] = key;
            

            for (int i = 0; i < _tempValue.Length; i++)
            {


                _arrayValue[i] = _tempValue[i];
                _arrayKey[i] = _tempKey[i];
            }

            _arrayValue[_arrayValue.Length - 1] = value;

           
        }


        public int count
        {
            get { return _arrayKey.Length; }
        }

       

            

       
        
    }
}
