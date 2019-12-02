using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SpeedTestByCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            Console.WriteLine("开始测试10000个数组冒泡排序!");
            for (int i = 0; i < 10; i++)
            {
                watch.Restart();
                maopao();
                watch.Stop();
                Console.WriteLine($"{watch.ElapsedMilliseconds}");
            }

            Console.ReadLine();
        }

        static void maopao()
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 10000; i++)
            {
                numbers.Add(new Random().Next(0, 999999));
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
        }
    }
}