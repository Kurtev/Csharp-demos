using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemsVIII_X
{
    class Program
    {
        static void Main(string[] args)
        {

            Matrix<int> Matrix1 = new Matrix<int>(3,3);
            Matrix<int> Matrix2 = new Matrix<int>(3,3);

           
            Console.WriteLine("Fill the first Matrix");
            for (int i = 0; i < Matrix1.Rows; i++)
            {
                
                for (int j = 0; j < Matrix1.Cols; j++)
                {
                    Console.Write("[{0}][{1}]= ", i, j);
                    Matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("{0}", Matrix1);
   

            Console.WriteLine("\n\nFill the second Matrix");
            for (int i = 0; i < Matrix2.Rows; i++)
            {

                for (int j = 0; j < Matrix2.Cols; j++)
                {
                    Console.Write("[{0}][{1}]= ", i, j);
                    Matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("{0}", Matrix2);

            Console.WriteLine("\n\nSum of the Matrixes");
            Matrix<int> MatrixSum = Matrix1 + Matrix2;
            Console.WriteLine(MatrixSum);

            Console.WriteLine("Subtract of the Matrixes");
            Matrix<int> MatrixSub = Matrix1 - Matrix2;
            Console.WriteLine(MatrixSub);

            Console.WriteLine("Product of the Matrixes");
            Matrix<int> Matrix3 = Matrix1 * Matrix2;
            Console.WriteLine(Matrix3);
          
            Console.WriteLine("Show element at index [2,1]: {0} ",Matrix3[2,1]);

            if (Matrix1)
            {
             Console.WriteLine("The matrix does not contain zero elements");
            }
            else
            {
                Console.WriteLine("The matrix contains zero element(s)");
            }
           
        }
    }
}
