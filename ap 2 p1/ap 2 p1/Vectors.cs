using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ap_2_p1
{
    public class Vectors<_Type> :
        IEnumerable<_Type>
    {

        protected _Type[] Data;
        protected int AddIndex = 0;
        public int Size => Data.Length;


        public void Add(_Type v)
        {
            Data[AddIndex++] = v;
        }


        public Vectors(int length)
        {
            this.Data = new _Type[length];
        }

        public _Type this[int index]
        {
            get { return Data[index]; }
            set { Data[index] = value; }
        }

        public static Vectors<_Type> operator +(Vectors<_Type> v1, Vectors<_Type> v2)
        {
            Vectors<_Type> sum = new Vectors<_Type>(v1.Count());
            if (v1.Count() != v2.Count())
            {
                throw new InvalidDataException();
            }
            else
            {
                for (int i = 0; i < v2.Count(); i++)
                {
                    sum.Add((dynamic)v2.Data[i] + (dynamic)v1.Data[i]);
                }
            }
            return sum;
        }
        public static _Type operator *(Vectors<_Type> v1, Vectors<_Type> v2)
        {
            _Type multiple = default(_Type);
            if (v1.Count() != v2.Count() || v1.GetType() != typeof(int) || v2.GetType() != typeof(int))
            {
                throw new InvalidDataException();
            }
            else
            {
                for (int i = 0; i < v2.Count(); i++)
                {
                    multiple += ((dynamic)v1[i] * (dynamic)v2[i]);
                }

            }
            return multiple;

        }

        public static bool operator ==(Vectors<_Type> v1, Vectors<_Type> v2)
        {
            bool equal = true;

            if (v1.Count() != v2.Count())
                return false;


            for (int i = 0; i < v2.Count(); i++)
            {
                equal = ((dynamic)v1[i] == (dynamic)v2[i]);
                if (equal == false)
                    return equal;
            }


            return equal;
        }
        public static bool operator !=(Vectors<_Type> v1, Vectors<_Type> v2)
        {
            return !(v1 == v2);
        }

        public override bool Equals(object obj)
        {

            return (Vectors<_Type>)obj == this;

        }
        public bool Equals(Vectors<_Type> other)
        {
            return this == other;
        }

        public override int GetHashCode()
        {
            return 1;
        }

        public IEnumerator<_Type> GetEnumerator()
        {
            foreach (var a in this.Data)
            {
                yield return a;
            }
            //return (IEnumerator) GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {

            return (IEnumerator)GetEnumerator();
        }

        //public int CompareTo(object obj)
        //{
        //    int result = 0;
        //   for(int i = 0; i < this.Count(); i++)
        //    {
        //        if()
        //    }
        //}
    }

}
