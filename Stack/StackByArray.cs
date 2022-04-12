using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
  internal class StackByArray
  {
    // Member variable.
    private int[] _stack;
    private int _top;

    // Constructors.
    public StackByArray(int size)
    {
      _stack = new int[size]; // create array
      _top = -1;              // it's means empty of stack
    }

    /// <summary>
    /// When you push data into stack, check the stack is full or not.
    /// </summary>
    /// <param name="data">import data.</param>
    /// <returns>true or false.</returns>
    public bool push(int data)
    {
      if (_top >= _stack.Length)
      {
        Console.WriteLine("Stack is full!!");
        return false;
      }
      else
      {
        _stack[++_top] = data;
        return true;
      }
    }

    /// <summary>
    /// Check the stack is empty or not.
    /// </summary>
    /// <returns>true or false.</returns>
    public bool empty()
    {
      return (_top == -1 ? true : false);
    }

    /// <summary>
    /// When you pop up data from the stack, check the stack is empty or not.
    /// </summary>
    /// <returns>array index.</returns>
    public int pop()
    {
      return (empty() ? -1 : _stack[_top--]);
    }
  }
}
