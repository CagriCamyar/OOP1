﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T> //Tek Generic kullanıyosak T yazarız
    {
        T[] items;
        // ctor - constructor - Genericler arka planda array tuttugu için newlememiz gerekiyor

        public MyList()
        {
                items = new T[0];
        }
        public void Add(T item) 
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; 
        
        }
    }
}