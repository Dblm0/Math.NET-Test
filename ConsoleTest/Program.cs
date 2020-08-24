using System;
using MathNet.Numerics.Data.Text;
using MathNet.Numerics.Data.Matlab;
using MathNet.Numerics.LinearAlgebra;
namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Matrix<double>.Build.Random(2, 2);
            DelimitedWriter.Write("123", data);
            MatlabWriter.Write("123", Matrix<double>.Build.Random(2, 2), "a");
        }
    }
}
