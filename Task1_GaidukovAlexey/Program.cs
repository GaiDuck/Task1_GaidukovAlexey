using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_GaidukovAlexey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double[] value = new double[5];
            double temp;
            double localMax;
            double localMin;
            double arithmeticMean;
            double medianMean;

            Console.WriteLine("Создаем массив случайных чисел:");

            for (int i = 0; i < value.Length; i++)
            {
                value[i] = random.NextDouble() * (1 + Double.Epsilon); 
                //Используем хитрость, чтобы учесть, что по условиям задачи интервал [0, 1], а random.NextDouble генерирует [0, 1).
                Console.WriteLine(value[i]);
            }

            Console.WriteLine("\nОтсортированный массив:");

            for (int i = value.Length-1; i >= 0; i--)
            {
                for (int j = i; j < value.Length-1; j++)
                {
                    if (value[j] > value[j + 1])
                    {
                        temp = value[j+1];
                        value[j+1] = value[j];
                        value[j] = temp;
                    }
                }
            }
            
            for (int i = 0; i < value.Length; i++)
            {
                Console.WriteLine(value[i]);
            }

            Console.WriteLine();

            localMax = value[0];
            localMin = value[0];
            arithmeticMean = value[0];

            for (int i = 1; i < value.Length; i++)
            {
                if (value[i] > localMax)
                {
                    localMax = value[i];
                }

                if (value[i] < localMin)
                {
                    localMin = value[i];
                }

                arithmeticMean += value[i];
            }

            arithmeticMean = arithmeticMean / value.Length;
            medianMean = value[value.Length / 2];
            

            Console.WriteLine($"Максимальное значение: {localMax} \nМинимальное значение: {localMin} \nСреднее арифметическое значение: {arithmeticMean} \nМедианное значение: {medianMean}");

            Console.ReadKey();
        }
    }
}
