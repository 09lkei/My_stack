using System;

namespace My_stack
{
	class Program
	{
		static void Main(string[] args)
		{
			stack<int> myStack = new stack<int>(10);
			for (int i = 0; i < 11; i++)
			{
				Console.WriteLine(i);
				myStack.push(i);
			}

			for (int i = 0; i < 11; i++)
			{
				Console.WriteLine(myStack.pop().ToString() +" popped!");
			}
			for (int i = 0; i < 11; i++)
			{
				Console.WriteLine(i);
				myStack.push(i);
			}
			for (int i = 0; i < 11; i++)
			{
				Console.WriteLine(myStack.pop().ToString() +" popped!");
			}
		}
	}

	class stack<T>
	{
		private int top;
		private int maxSize;
		private T[] data;
		
		public stack(int maxSize)
		{
			top = 0;
			this.maxSize = maxSize;
			data = new T[maxSize];
		}

		private bool isEmpty()
		{
			return top == 0;
		}

		private bool isFull()
		{
			return top == maxSize;
		}
		public void push(T inputItem)
		{
			if (!isFull())
			{
				data[top] = inputItem;
				top++;
			}
			else
			{
				Console.WriteLine("Full stack");
			}
		}

		public T pop()
		{
			if (!isEmpty())
			{
				top -= 1;
				return data[top];
			}
			else
			{
				Console.WriteLine("Empty stack");
				return default(T);
			}
		}

		public T peek()
		{
			if (!isEmpty())
			{
				return data[top];
			} else
			{
				Console.WriteLine("Empty stack");
				return default(T);
			}
		}
	}

	class plate
	{
		private string color;

		public plate(string color)
		{
			this.color = color;
		}
	}
}