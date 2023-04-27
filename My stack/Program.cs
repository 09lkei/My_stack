using System;

namespace My_stack
{
	class Program
	{
		static void Main(string[] args)
		{
			stack<int> myStack = new stack<int>(10);
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(i);
				myStack.push(i);
			}

			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(myStack.pop().ToString() +" popped!");
			}
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(i);
				myStack.push(i);
			}
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(myStack.peek().ToString() +" peeked!");
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
				throw new InvalidOperationException("Cannot push to full stack");
			}
		}

		public T pop()
		{
			if (!isEmpty())
			{
				return data[top-=1];
			}
			else
			{
				throw new InvalidOperationException("Cannot pop from empty stack");
			}
		}

		public T peek()
		{
			if (!isEmpty())
			{
				return data[top-1];
			} else
			{
				throw new InvalidOperationException("Cannot peek from empty stack");
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