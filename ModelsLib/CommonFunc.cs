using ModelsLib.Collections;
using ModelsLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib
{
    /// <summary>
    /// class which contains all generic methods for all classes-type in ModelsLib
    /// </summary>
    public class CommonFunc
    {
        /// <summary>
        /// imprelement  default array of type
        /// </summary>
        public static void DefaultInit<T>(out T[] AnyStructure)
        {
            AnyStructure = (T[])Array.CreateInstance(typeof(T), 0);
        }

        /// <summary>
        /// add new item in current array of members(generic)
        /// </summary>
        public static void AddItem<T>(ref T[] CurrentObject, T AddingItem)
        {
            T[] tempCurrentObject = new T[CurrentObject.Length + 1];
            for (int i = 0; i < CurrentObject.Length; i++)
                tempCurrentObject[i] = CurrentObject[i];
            tempCurrentObject[tempCurrentObject.Length - 1] = AddingItem;
            CurrentObject = tempCurrentObject;
        }

        public static IContainers[] AddNewContainers(ref IContainers[] CurrentObject, IContainers AddingItem)
        {
            IContainers[] tempCurrentObject = new IContainers[CurrentObject.Length + 1];
            for (int i = 0; i < CurrentObject.Length; i++)
                tempCurrentObject[i] = CurrentObject[i];
            tempCurrentObject[tempCurrentObject.Length - 1] = AddingItem;
            return CurrentObject = tempCurrentObject;
        }

        /// <summary>
        /// remove item from current array of members
        /// </summary>
        public static void RemoveItem<T>(ref T[] CurrentObject, int index)
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
    }
}
