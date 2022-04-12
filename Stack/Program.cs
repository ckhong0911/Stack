using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
  internal class Program
  {
    /// <summary>
    /// Stack features: last in first out or first in last out.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
      int size = 5;
      StackByArray stack = new StackByArray(size);
      Console.WriteLine("Please enter {0} number data to stack:", size);

      int value;
      for (int i = 0; i < size; i++)
      {
        value = int.Parse(Console.ReadLine());
        stack.push(value);
      }

      Console.WriteLine("\nStack pop up sequence:");

      while (!stack.empty())
      {
        Console.WriteLine(stack.pop());
      }

      Console.ReadLine();
    }
  }
}
