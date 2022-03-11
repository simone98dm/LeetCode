using LeetCode.Solves.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solves.ImplementQueueUsingStacks
{
    public class ImplementQueueUsingStacks : BaseSolution<int[], int[]>
    {
        public override int[] Solve(int[] i)
        {
            MyQueue obj = new MyQueue();
            foreach (var item in i)
            {
                obj.Push(item);
            }
            int param_3 = obj.Peek();
            int param_2 = obj.Pop();
            bool param_4 = obj.Empty();

            return new int[0];
        }
    }


    public class MyQueue
    {
        public Stack<int> Stack1 { get; set; }
        public Stack<int> Stack2 { get; set; }
        public MyQueue()
        {
            Stack1 = new Stack<int>();
            Stack2 = new Stack<int>();
        }

        public void Push(int x)
        {
            Stack1.Push(x);
        }

        public int Pop()
        {
            while (Stack1.Count != 0)
            {
                Stack2.Push(Stack1.Pop());
            }
            int v = Stack2.Peek();
            Stack2.Pop();
            while (Stack2.Count != 0)
            {
                Stack1.Push(Stack2.Pop());
            }

            return v;
        }

        public int Peek()
        {
            while (Stack1.Count != 0)
            {
                Stack2.Push(Stack1.Pop());
            }
            int v = Stack2.Peek();
            while (Stack2.Count != 0)
            {
                Stack1.Push(Stack2.Pop());
            }
            return v;
        }

        public bool Empty()
        {
            return Stack1.Count == 0;
        }
    }
}
