using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemsVIII_X
{
  public class Matrix<T>
    {
        private int cols;
        private int rows;
        private T[,] genMatrix;

        public Matrix(T[,] matrix)
        {
            this.Rows=matrix.GetLength(0);
            this.Cols=matrix.GetLength(1);
            genMatrix = new T[this.Rows, this.Cols];
            genMatrix = matrix;
        }


        public Matrix(int mRows, int mCols)
        {
            this.Rows = mRows;
            this.Cols = mCols;
            genMatrix = new T[mRows, mCols];
        }


        public int Cols
        {
            get { return this.cols; }
            private set { this.cols = value; }
        }

        public int Rows
        {
            get { return this.rows; }
            private set { this.rows = value; }
        }

        public T this[int Rows, int Cols]
        {
            get
            {
                if (Rows > this.rows - 1 || Rows < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                if (Cols > this.cols - 1 || Cols < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                T index = this.genMatrix[Rows, Cols];
                return index;
            }
            set
            {
                if (Rows > this.rows - 1 || Rows < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                if (Cols > this.cols - 1 || Cols < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                this.genMatrix[Rows, Cols] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> A, Matrix<T> B)
        {
            if (A.Rows != B.Rows || A.Cols != B.Cols)
            {
                throw new ArgumentException("Matrix A size and Matrix B size must be equal.");
            }
            Matrix<T> sumMatrix = new Matrix<T>(A.Rows, A.Cols);
            for (int i = 0; i < A.Rows; i++)
            {
                for (int j = 0; j < A.Cols; j++)
                {
                   sumMatrix[i,j] = (dynamic)A[i, j] + B[i, j];
                }
            }
            return sumMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> A, Matrix<T> B)
        {
            if (A.Rows != B.Rows || A.Cols != B.Cols)
            {
                throw new ArgumentException("Matrix A size and Matrix B size must be equal.");
            }
            Matrix<T> subMatrix = new Matrix<T>(A.Rows, A.Cols);
            for (int i = 0; i < A.Rows; i++)
            {
                for (int j = 0; j < A.Cols; j++)
                {
                    subMatrix[i, j] = (dynamic)A[i, j] - B[i, j];
                }
            }
            return subMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> A, Matrix<T> B)
        {
            if (A.Cols != B.Rows)
            {
                throw new ArgumentException("Matrix A Rows and Matrix B Cols must be equal.");
            }
            Matrix<T> prodMatrix = new Matrix<T>(A.Rows, A.Cols);
            T tempRes = (dynamic)0;
            for (int i = 0; i < A.Rows; i++)
            {
                for (int j = 0; j < B.Cols; j++)
                {
                    for (int index = 0; index < A.Cols; index++)
                    {
                        tempRes += (dynamic)A[i, index] * B[index, j];
                    }
                    prodMatrix[i, j] = tempRes;
                    tempRes = (dynamic)0;
                }
               
            }
            return prodMatrix;
        }

        public static bool operator true(Matrix<T> M)
        {
            bool NonZero = true;
            
            for (int i = 0; i < M.Rows; i++)
            {
                for (int j = 0; j < M.Cols; j++)
                {
                    if (M[i,j] == (dynamic)0)
                    {
                        NonZero = false;
                    }
                }

            }
            return NonZero;
        }

        public static bool operator false(Matrix<T> M)
        {
            bool NonZero = true;

            for (int i = 0; i < M.Rows; i++)
            {
                for (int j = 0; j < M.Cols; j++)
                {
                    if (M[i, j] == (dynamic)0)
                    {
                        NonZero = false;
                    }
                }

            }
            return NonZero;
        }

        public override string ToString()
        {
            StringBuilder strMatrix = new StringBuilder();
            for(int i =0;i < this.Rows; i++)
            {
                Console.WriteLine();
                for (int j=0;j<this.Cols;j++)
                {
                   strMatrix.Append(String.Format("{0,-4}", this.genMatrix[i, j]));
                }
                strMatrix.Append("\n");
            }
            return strMatrix.ToString();
        }
    }
}
