using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_16
{
  class Program
  {
    static int SumElements(int[] array, int i = 0)
    {
      int sum = 0;
      if( i != array.Length)
      {
        sum += array[i];
        i++;
        SumElements(array);
      }
      return sum;
    }

    static void Main(string[] args)
    {
      int[] myArray = new int[5] { 1, 2, 3, 4, 5 };
      Console.WriteLine(SumElements(myArray));
      Console.ReadLine();

    }
  }
}
