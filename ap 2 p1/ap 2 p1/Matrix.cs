using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ap_2_p1
{
    public class Matrix<_Type> :
            IEnumerable<Vectors<_Type>>
    {
        public readonly int RowCount;
        public readonly int ColumnCount;

        protected readonly Vectors<_Type>[] Rows;
        protected int RowAddIndex = 0;

        public Matrix(int rowCount, int columnCount)
        {
            this.RowCount = rowCount;
            this.ColumnCount = columnCount;
            Rows = new Vectors<_Type>[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                Rows[i] = new Vectors<_Type>(columnCount);
            }
        }



        public void Add(Vectors<_Type> row)
        {
            this.Rows[RowAddIndex++] = row;
        }

        public Vectors<_Type> this[int index]
        {
            get { return this.Rows[index]; }
            set { this.Rows[index] = value; }
        }

        public _Type this[int row, int col]
        {
            get { return Rows[row][col]; }
            set { Rows[row][col] = value; }
        }


        public static Matrix<_Type> operator +(Matrix<_Type> m1, Matrix<_Type> m2)
        {
            Matrix<_Type> sum = new Matrix<_Type>(m1.RowCount, m1.ColumnCount);
            if (m1.RowCount != m2.RowCount || m1.ColumnCount != m2.ColumnCount)
                throw new InvalidOperationException();
            for (int i = 0; i < m1.RowCount; i++)
            {
                sum[i] = m1.Rows[i] + m2.Rows[i];
            }
            return sum;
        }

        public static Matrix<_Type> operator *(Matrix<_Type> m1, Matrix<_Type> m2)
        {

            Matrix<_Type> multiple = new Matrix<_Type>(m1.RowCount, m2.ColumnCount);

            if (m1.ColumnCount != m2.RowCount)
            {
                throw new InvalidOperationException();
            }
            for (int k = 0; k < m1.RowCount; k++)
            {

                for (int i = 0; i < m2.ColumnCount; i++)
                {
                    int result = 0;
                    for (int j = 0; j < m1.ColumnCount; j++)
                    {

                        result += (dynamic)m1[k][j] * (dynamic)m2[j][i];
                    }
                    multiple[k][i] = (dynamic)result;
                }
            }
            return multiple;
        }


        protected IEnumerable<_Type> GetColumnEnumerator(int col)
        {
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < Rows.Length; j++)
                {
                    yield return this.Rows[i][j];
                }
            }
        }

        public static bool operator ==(Matrix<_Type> m1, Matrix<_Type> m2)
        {
            if (m1.ColumnCount != m2.ColumnCount || m1.RowCount != m2.RowCount)
                return false;
            for (int i = 0; i < m1.RowCount; i++)
            {
                for (int j = 0; j < m1.ColumnCount; j++)
                {
                    if ((dynamic)m1[i][j] != (dynamic)m2[i][j])
                        return false;
                }
            }
            return true;
        }

        public static bool operator !=(Matrix<_Type> m1, Matrix<_Type> m2)
        {
            return !(m1 == m2);
        }

        public bool Equals(Matrix<_Type> other)
        {
            return this == other;
        }

        public override bool Equals(object obj)
        {
            return this == (Matrix<_Type>)obj;
        }

        public override int GetHashCode()
        {
            return 1;
        }

        public IEnumerator<Vectors<_Type>> GetEnumerator()
        {
            return ((IEnumerable<Vectors<_Type>>)Rows).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Vectors<_Type>>)Rows).GetEnumerator();
        }
    }
}