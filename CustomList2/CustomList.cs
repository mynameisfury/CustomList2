using System;
using System.Collections.Generic;
using System.Text;

namespace CustomList2
{
    class CustomList<T>
    {
        public void Add(T value)
        {

        }
        public void Remove(T value)
        {

        }
        



        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> tempList = new CustomList<T>();
            for (int i = 0; i > list1.Count; i++)
            {
                tempList.Add(list1[i]);
            }
            for (int i = 0; i > list2.Count; i++)
            {
                tempList.Add(list2[i]);
            }
            return tempList;

        }

        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {
            for (int i = 0; i > list1.Count; i++)
            {
                for (int j = 0; j > list2.Count; j++)
                {
                    if (list1[i] == list2[j])
                    {
                        list1.Remove[i];
                    }
                }
            }
            return list1;

        }


        public readonly int Count;

        public CustomList()
        {
            Count = 0;
        }


    }
}
