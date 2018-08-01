using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.Collections
{
    public class Matrix : IEnumerable
    {
        private Position[] _matrix;

        public Matrix()
        {
            this._matrix = (Position[])Array.CreateInstance(typeof(Position), 0);
        }

        public void AddItem(Position newPosition)
        {
            CommonFunc.AddItem<Position>(_matrix, newPosition);
        }

        public void RemoveItem(int index)
        {
            CommonFunc.RemoveItem<Position>(_matrix, index);
        }

        public void ClearAll()
        {
            CommonFunc.DefaultInit(this._matrix);
        }

        public IEnumerator GetEnumerator()
        {
            return _matrix.GetEnumerator();
        }

        public int Length
        {
            get { return _matrix.Length; }
        }

        public Position this[int index]
        {
            get { return _matrix[index]; }
            set { _matrix[index] = value; }
        }
    }
}
