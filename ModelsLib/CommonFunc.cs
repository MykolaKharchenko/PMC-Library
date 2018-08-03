using ModelsLib.Collections;
using ModelsLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib
{
    class CommonFunc
    {
        public static void DefaultInit<T>(out T[] AnyStructure)
        {
            AnyStructure = (T[])Array.CreateInstance(typeof(T), 0);
        }

        public static void AddItem<T>(T[] CurrentObject, T AddingItem)
        {
            T[] tempCurrentObject = new T[CurrentObject.Length + 1];
            for (int i = 0; i < CurrentObject.Length; i++)
                tempCurrentObject[i] = CurrentObject[i];
            tempCurrentObject[tempCurrentObject.Length - 1] = AddingItem;
            CurrentObject = tempCurrentObject;
        }

        public static void AddNewContainers(IContainers [] CurrentObject, IContainers AddingItem)
        {
            IContainers[] tempCurrentObject = new IContainers[CurrentObject.Length + 1];
            for (int i = 0; i < CurrentObject.Length; i++)
                tempCurrentObject[i] = CurrentObject[i];
            tempCurrentObject[tempCurrentObject.Length - 1] = AddingItem;
            CurrentObject = tempCurrentObject;
        }

        public static void RemoveItem<T>(T[] CurrentObject, int index)
        {
            if (index >= CurrentObject.Length)
                return;
            T[] tempCurrentObject = new T[CurrentObject.Length - 1];
            for (int i = 0, j =0; i < CurrentObject.Length; i++, j++)
            {
                if (index == i)
                    j--;
                else
                    tempCurrentObject[j] = CurrentObject[i];
            }
            CurrentObject = tempCurrentObject;
        }

        public bool CheckTypes<U>(U _x)
        {
            Type t = _x.GetType();
            return (t.Equals(typeof(Int32)) || t.Equals(typeof(decimal)) || t.Equals(typeof(double)));
        }
    }
}
