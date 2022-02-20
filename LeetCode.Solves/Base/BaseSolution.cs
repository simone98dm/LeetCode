using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solves.Base
{
    public abstract class BaseSolution
    {
    }
    public abstract class BaseSolution<P1> : BaseSolution, IBaseSolution<P1>
    {
        public abstract void Solve(P1 param);
    }
    public abstract class BaseSolution<P1, R> : BaseSolution, IBaseSolution<P1, R>
    {
        public abstract R Solve(P1 param);
    }
    public abstract class BaseSolution<P1, P2, R> : BaseSolution, IBaseSolution<P1, P2, R>
    {
        public abstract R Solve(P1 param1, P2 param2);
    }
    public abstract class BaseSolution<P1, P2, P3, R> : BaseSolution, IBaseSolution<P1, P2, P3, R>
    {
        public abstract R Solve(P1 param1, P2 param2, P3 param3);
    }
    public abstract class BaseSolution<P1, P2, P3, P4, R> : BaseSolution, IBaseSolution<P1, P2, P3, P4, R>
    {
        public abstract R Solve(P1 param1, P2 param2, P3 param3, P4 param4);
    }
}
