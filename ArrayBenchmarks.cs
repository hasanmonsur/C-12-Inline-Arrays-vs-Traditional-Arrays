using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InlineArryBenchmark
{
    // Define a 10-element inline array struct
    [InlineArray(10)]
    public struct InlineArray10
    {
        private int _element0; // Only one field - compiler handles expansion
    }

    [MemoryDiagnoser]
    public class ArrayBenchmarks
    {
        private const int Iterations = 1000;

        [Benchmark(Baseline = true)]
        public int TraditionalArray()
        {
            int sum = 0;
            for (int i = 0; i < Iterations; i++)
            {
                int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                sum += array[i % 10];
            }
            return sum;
        }

        [Benchmark]
        public int InlineArray()
        {
            int sum = 0;
            for (int i = 0; i < Iterations; i++)
            {
                InlineArray10 array = new();
                for (int j = 0; j < 10; j++) array[j] = j + 1;
                sum += array[i % 10];
            }
            return sum;
        }
    }
}
